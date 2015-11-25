using System.IO;

namespace Bsp
{
    internal class Model
    {
        int[] min = new int[3];
        int[] max = new int[3];
        int face;
        int numFaces;
        int brush;
        int numBrushes;

        public Model(BinaryReader reader)
        {
            min[0] = reader.ReadInt32();
            min[1] = reader.ReadInt32();
            min[2] = reader.ReadInt32();
            max[0] = reader.ReadInt32();
            max[1] = reader.ReadInt32();
            max[2] = reader.ReadInt32();
            face = reader.ReadInt32();
            numFaces = reader.ReadInt32();
            brush = reader.ReadInt32();
            numBrushes = reader.ReadInt32();   
        }

        public static int Size
        {
            get { return sizeof(int) * 10; }
        }
    }
}