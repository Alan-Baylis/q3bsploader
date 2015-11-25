using System.IO;

namespace Bsp
{
    public class Node
    {
        int plane;
        int[] children = new int[2];
        int[] min = new int[3];
        int[] max = new int[3];

        internal void Load(BinaryReader reader)
        {
            plane = reader.ReadInt32();
            children[0] = reader.ReadInt32();
            children[1] = reader.ReadInt32();
            min[0] = reader.ReadInt32();
            min[1] = reader.ReadInt32();
            min[2] = reader.ReadInt32();
            max[0] = reader.ReadInt32();
            max[1] = reader.ReadInt32();
            max[2] = reader.ReadInt32();
        }

        public static int Size
        {
            get { return sizeof(int) * 9; }
        }
    }
}