using System.IO;

namespace Bsp
{
    public class LeafFace
    {
		int face;

        internal void Load(BinaryReader reader)
        {
            face = reader.ReadInt32();
        }

        public static int Size
        {
            get { return sizeof(int); }
        }
    }
}