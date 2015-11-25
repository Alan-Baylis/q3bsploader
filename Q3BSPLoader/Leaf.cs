using System.IO;

namespace Bsp
{
    public class Leaf
    {
		int cluster;
		int area;
		int[] min = new int[3];
		int[] max = new int[3];
		int leafFace;
		int numLeafFaces;
		int leafBrush;
		int numLeafBrushes;

        internal void Load(BinaryReader reader)
        {
            cluster = reader.ReadInt32();
            area = reader.ReadInt32();
            min[0] = reader.ReadInt32();
            min[1] = reader.ReadInt32();
            min[2] = reader.ReadInt32();
            max[0] = reader.ReadInt32();
            max[1] = reader.ReadInt32();
            max[2] = reader.ReadInt32();
            leafFace = reader.ReadInt32();
            numLeafFaces = reader.ReadInt32();
            leafBrush = reader.ReadInt32();
            numLeafBrushes = reader.ReadInt32();
        }

        internal static int Size
        {
            get { return sizeof(int) * 12; }
        }
    }
}