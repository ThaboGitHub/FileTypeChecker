﻿namespace FileTypeChecker.Types
{
    using FileTypeChecker.Abstracts;

    public class ExtensibleMarkupLanguage : FileType, IFileType
    {
        public const string TypeName = "eXtensible Markup Language";
        public const string TypeExtension = "xml";
        private static readonly byte[][] magicBytesJaggedArray = { new byte[] { 0x3c, 0x3f, 0x78, 0x6d, 0x6c, 0x20, 0x76, 0x65, 0x72, 0x73, 0x69, 0x6F, 0x6E, 0x3D, 0x22, 0x31 }, new byte[] { 0xef, 0xbb, 0xbf, 0x3c, 0x3f, 0x78, 0x6d, 0x6c, 0x20, 0x76, 0x65, 0x72, 0x73, 0x69, 0x6F, 0x6E, 0x3D, 0x22, 0x31 } };

        public ExtensibleMarkupLanguage() : base(TypeName, TypeExtension, magicBytesJaggedArray)
        {
        }
    }
}
