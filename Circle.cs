using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPaperCommunicator
{
    public class Circle
    {
        public Coordinate Point { get; set; }
        public short Radius { get; set; }

        public Circle()
        {
            Point = new Coordinate(0, 0);
            Radius = 0;
        }
        
        public Circle(Coordinate center, short r)
        {
            Point = new Coordinate(center.X, center.Y);
            Radius = r;
        }

        public byte[] ToByteArray()
        {
            List<byte> circle = new List<byte>();
            circle.AddRange(Point.ToByteArray());
            circle.AddRange(BitConverter.GetBytes(Radius).Reverse());
            return circle.ToArray();
        }
    }
}
