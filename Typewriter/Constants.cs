﻿using System.IO;

namespace Typewriter
{
    internal static class Constants
    {
        internal const string Extension = ".tst";
        internal const string ContentType = "tst";
        internal const string LanguageName = "TST";

        internal const string ExtensionPackageId = "45b6b392-ce2f-409c-a39f-bbf90b34349e";
        internal const string LanguageServiceId = "aa5d6809-9c5d-443c-a37c-c29e6af2fe15";

        internal const string BaseDefinition = "code";
        internal const char NewLine = '\n';

        internal static readonly string TempDirectory = Path.Combine(Path.GetTempPath(), "Typewriter");
    }

    internal static class Classifications
    {
        public const string BraceHighlight = "MarkerFormatDefinition/HighlightedReference";
        public const string Comment = "Comment";
        public const string Identifier = "Identifier";
        public const string Keyword = "Keyword";
        public const string Number = "Number";
        public const string Operator = "Operator";
        public const string Property = "Tst/Property";
        public const string String = "String";
        public const string SyntaxError = "syntax error";
    }
}
