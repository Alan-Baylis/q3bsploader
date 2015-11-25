using System.IO;

namespace Bsp
{
    public class MeshVertex
    {
        int offset;

        public MeshVertex(BinaryReader reader)
        {
            offset = reader.ReadInt32();
        }

        public static int Size
        {
            get { return sizeof(int); }
        }
    }
}