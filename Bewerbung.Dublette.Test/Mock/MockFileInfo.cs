using Dublette.Core.Interfaces;

namespace Dublette.Test.Mock
{
    internal class MockFileInfo : IFileInfo
    {

        public MockFileInfo(string path, string fileName, long size)
        { Path = path; FileName = fileName; Size = size; }

        public MockFileInfo(string fileName, long size) : this($@"C:\temp\{Guid.NewGuid()}.tmp", fileName, size) { }
        public MockFileInfo(string fileName) : this($@"C:\temp\{Guid.NewGuid()}.tmp", fileName, 123) { }
        public MockFileInfo(long size) : this($@"C:\temp\{Guid.NewGuid()}.tmp", $"{Guid.NewGuid()}.tmp", size) { }

        public string Path { get; }

        public string FileName { get; }

        public long Size { get; }


    }
}
