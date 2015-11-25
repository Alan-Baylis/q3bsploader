using System.IO;

namespace Bsp
{
    public class Face
    {
		int texture;
		int effect;
		int type;
		int vertex;
		int numVertices;
		int meshVertex;
		int numMeshVertices;
		int lightmapIndex;
		int[] lightmapStart = new int[2];
        int[] lightmapSize = new int[2];
        float[] lightmapOrigin = new float[3];
        float[,] lightmapVectors = new float[2, 3];
		float[] normal = new float[3];
		int[] size = new int[2];

        public Face(BinaryReader reader)
        {
            texture = reader.ReadInt32();
            effect = reader.ReadInt32();
            type = reader.ReadInt32();
            vertex = reader.ReadInt32();
            numVertices = reader.ReadInt32();
            meshVertex = reader.ReadInt32();
            numMeshVertices = reader.ReadInt32();
            lightmapIndex = reader.ReadInt32();
            lightmapStart[0] = reader.ReadInt32();
            lightmapStart[1] = reader.ReadInt32();
            lightmapSize[0] = reader.ReadInt32();
            lightmapSize[1] = reader.ReadInt32();
            lightmapOrigin[0] = reader.ReadSingle();
            lightmapOrigin[1] = reader.ReadSingle();
            lightmapOrigin[2] = reader.ReadSingle();
            lightmapVectors[0, 0] = reader.ReadSingle();
            lightmapVectors[0, 1] = reader.ReadSingle();
            lightmapVectors[0, 2] = reader.ReadSingle();
            lightmapVectors[1, 0] = reader.ReadSingle();
            lightmapVectors[1, 1] = reader.ReadSingle();
            lightmapVectors[1, 2] = reader.ReadSingle();
            normal[0] = reader.ReadSingle();
            normal[1] = reader.ReadSingle();
            normal[2] = reader.ReadSingle();
            size[0] = reader.ReadInt32();
            size[1] = reader.ReadInt32();
        }

        internal static int Size
        {
            get { return sizeof(int) * 13 + sizeof(float) * 12; }
        }
    }
}