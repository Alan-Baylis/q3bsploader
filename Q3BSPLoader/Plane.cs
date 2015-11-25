using System.IO;

namespace Bsp
{
    public class Plane
    {
        float[] normal = new float[3];
        float distance;

        public Plane(BinaryReader reader)
        {
            normal[0] = reader.ReadSingle();
            normal[1] = reader.ReadSingle();
            normal[2] = reader.ReadSingle();
            distance = reader.ReadSingle();
        }

        public static int Size
        {
            get { return sizeof(float) * 4; }
        }
    }
}