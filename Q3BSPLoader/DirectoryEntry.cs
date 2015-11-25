using System.IO;

namespace Bsp
{
    public class DirectoryEntry
    {
		int offset;
		int length;

        #region Properties
        public int Offset
        {
            get { return offset; }
        }

        public int Length
        {
            get { return length; }
        }
        #endregion

        public DirectoryEntry(BinaryReader reader)
        {
            offset = reader.ReadInt32();
            length = reader.ReadInt32();
        }
    }
}