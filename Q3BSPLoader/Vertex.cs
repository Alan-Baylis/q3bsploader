using System.IO;

namespace Bsp
{
    public class Vertex
    {
		float[] position = new float[3];
		float[,] textureCoordinates = new float[2, 2];
		float[] normal = new float[3];
		byte[] color = new byte[4];

        public Vertex(BinaryReader reader)
        {
            position[0] = reader.ReadSingle();
            position[1] = reader.ReadSingle();
            position[2] = reader.ReadSingle();
            textureCoordinates[0, 0] = reader.ReadSingle();
            textureCoordinates[0, 1] = reader.ReadSingle();
            textureCoordinates[1, 0] = reader.ReadSingle();
            textureCoordinates[1, 1] = reader.ReadSingle();
            normal[0] = reader.ReadSingle();
            normal[1] = reader.ReadSingle();
            normal[2] = reader.ReadSingle();
            color[0] = reader.ReadByte();
            color[1] = reader.ReadByte();
            color[2] = reader.ReadByte();
            color[3] = reader.ReadByte();
        }

        internal static int Size
        {
            get { return sizeof(float) * 10 + sizeof(byte) * 4; }
        }
    }
}