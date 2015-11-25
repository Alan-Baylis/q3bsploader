using System.IO;

namespace Bsp
{
    public class LeafBrush
    {
		int brush;

        public LeafBrush(BinaryReader reader)
        {
            brush = reader.ReadInt32();
        }

        public static int Size
        {
            get { return sizeof(int); }
        }
    }
}