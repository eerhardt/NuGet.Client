// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace NuGet.ProjectModel
{
    /// <summary>
    /// A source-generation compatible converter for IList of IAssetsLogMessage.
    /// Converts to/from List of AssetsLogMessage.
    /// </summary>
    internal sealed class AssetsLogMessageListConverter : JsonConverter<IList<IAssetsLogMessage>>
    {
        public override IList<IAssetsLogMessage>? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType == JsonTokenType.Null)
            {
                return null;
            }

            if (reader.TokenType != JsonTokenType.StartArray)
            {
                throw new JsonException("Expected StartArray token");
            }

            var list = new List<IAssetsLogMessage>();
            while (reader.Read())
            {
                if (reader.TokenType == JsonTokenType.EndArray)
                {
                    break;
                }

                var message = JsonSerializer.Deserialize(ref reader, CacheFileSerializationContext.DefaultWithRelaxedEscaping.AssetsLogMessage);
                if (message != null)
                {
                    list.Add(message);
                }
            }

            return list;
        }

        public override void Write(Utf8JsonWriter writer, IList<IAssetsLogMessage> value, JsonSerializerOptions options)
        {
            if (value == null)
            {
                writer.WriteNullValue();
                return;
            }

            writer.WriteStartArray();
            foreach (var item in value)
            {
                if (item is AssetsLogMessage concreteMessage)
                {
                    JsonSerializer.Serialize(writer, concreteMessage, CacheFileSerializationContext.DefaultWithRelaxedEscaping.AssetsLogMessage);
                }
                else
                {
                    // For other implementations, create an AssetsLogMessage from the interface
                    var message = new AssetsLogMessage(item.Level, item.Code, item.Message)
                    {
                        ProjectPath = item.ProjectPath,
                        WarningLevel = item.WarningLevel,
                        FilePath = item.FilePath,
                        LibraryId = item.LibraryId,
                        TargetGraphs = item.TargetGraphs,
                        StartLineNumber = item.StartLineNumber,
                        StartColumnNumber = item.StartColumnNumber,
                        EndLineNumber = item.EndLineNumber,
                        EndColumnNumber = item.EndColumnNumber
                    };
                    JsonSerializer.Serialize(writer, message, CacheFileSerializationContext.DefaultWithRelaxedEscaping.AssetsLogMessage);
                }
            }
            writer.WriteEndArray();
        }
    }
}
