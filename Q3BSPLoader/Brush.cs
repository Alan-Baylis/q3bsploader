using System.IO;

namespace Bsp
{
    public class Brush
    {
        int brushSide;
        int numBrushSides;
        int texture;

        public Brush(BinaryReader reader)
        {
            brushSide = reader.ReadInt32();
            numBrushSides = reader.ReadInt32();
            texture = reader.ReadInt32();
        }

        public static int Size
        {
            get { return sizeof(int) * 3; }
        }
    }
}