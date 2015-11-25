using System.IO;

namespace Bsp
{
    public class Header
    {
        int magic;
        int version;
        DirectoryEntry[] _directoryEntries;

        public DirectoryEntry[] DirectoryEntries
        {
            get { return _directoryEntries; }
        }

        public Header(BinaryReader reader)
        {
            _directoryEntries = new DirectoryEntry[17];
            magic = reader.ReadInt32();
            version = reader.ReadInt32();
            for (int i = 0; i < 17; i++)
                _directoryEntries[i] = new DirectoryEntry(reader);
        }
    }
}