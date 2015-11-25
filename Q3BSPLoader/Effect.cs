using System.IO;

namespace Bsp
{
    public class Effect
    {
        string name;
		int brush;

        public Effect(BinaryReader reader)
        {
            name = new string(reader.ReadChars(64)).Trim('\0');
            brush = reader.ReadInt32();
        }

        public static int Size
        {
            get { return sizeof(char) * 64 + sizeof(int); }
        }
    }
}