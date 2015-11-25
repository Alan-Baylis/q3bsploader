using System.IO;

namespace Bsp
{
    public class BrushSide
    {
		int plane;
		int texture;

        public BrushSide(BinaryReader reader)
        {
            plane = reader.ReadInt32();
            texture = reader.ReadInt32();
        }

        public static int Size
        {
            get { return sizeof(int) * 2; }
        }
    }
}