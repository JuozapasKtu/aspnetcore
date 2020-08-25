// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.AspNetCore.Components.Web.Extensions
{
    internal static class InputFileInterop
    {
        private const string JsFunctionsPrefix = "_blazorInputFile.";

        public const string Init = JsFunctionsPrefix + "init";

        public const string EnsureArrayBufferReadyForSharedMemoryInterop = JsFunctionsPrefix + "ensureArrayBufferReadyForSharedMemoryInterop";

        public const string ReadFileData = JsFunctionsPrefix + "readFileData";

        public const string ReadFileDataSharedMemory = JsFunctionsPrefix + "readFileDataSharedMemory";

        public const string ToImageFile = JsFunctionsPrefix + "toImageFile";
    }
}
