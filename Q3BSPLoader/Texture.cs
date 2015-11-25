using System.IO;

namespace Bsp
{
    public class Texture
    {
		string name;
		int flags;
		int contents;

        public Texture(BinaryReader reader)
        {
            name = new string(reader.ReadChars(64)).Trim('\0');
            flags = reader.ReadInt32();
            contents = reader.ReadInt32();
        }

        public static int Size
        {
            get { return sizeof(char) * 64 + sizeof(int) * 2; }
        }
    }
}