// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using NuGet.Common;

namespace NuGet.ProjectModel
{
    [JsonSourceGenerationOptions(
        WriteIndented = true,
        PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        NumberHandling = JsonNumberHandling.AllowReadingFromString,
        AllowTrailingCommas = true,
        GenerationMode = JsonSourceGenerationMode.Default)]
    [JsonSerializable(typeof(CacheFile))]
    [JsonSerializable(typeof(AssetsLogMessage))]
    [JsonSerializable(typeof(LogLevel))]
    [JsonSerializable(typeof(NuGetLogCode))]
    [JsonSerializable(typeof(WarningLevel))]
    internal partial class CacheFileSerializationContext : JsonSerializerContext
    {
        private static CacheFileSerializationContext? _defaultWithRelaxedEscaping;

        /// <summary>
        /// Gets a context instance configured with UnsafeRelaxedJsonEscaping encoder.
        /// </summary>
        public static CacheFileSerializationContext DefaultWithRelaxedEscaping
        {
            get
            {
                if (_defaultWithRelaxedEscaping == null)
                {
                    var options = new JsonSerializerOptions(s_defaultOptions)
                    {
                        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                    };
                    _defaultWithRelaxedEscaping = new CacheFileSerializationContext(options);
                }
                return _defaultWithRelaxedEscaping;
            }
        }
    }
}
