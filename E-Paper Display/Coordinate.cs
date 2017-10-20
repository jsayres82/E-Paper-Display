using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPaperCommunicator
{
    public class Coordinate
    {
        public short X { get; set; }
        public short Y { get; set; }

        public Coordinate()
        {
            X = 0;
            Y = 0;
        }

        public Coordinate(short x, short y)
        {
            X = x;
            Y = y;
        }

        public Coordinate(int x, int y)
        {
            X = Convert.ToInt16(x);
            Y = Convert.ToInt16(y);
        }

        public byte[] ToByteArray()
        {
            List<byte> point = new List<byte>();
            point.AddRange(BitConverter.GetBytes(X).Reverse());
            point.AddRange(BitConverter.GetBytes(Y).Reverse());
            return point.ToArray();
        }

    }
}
