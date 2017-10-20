using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPaperCommunicator
{
    public class Line
    {
        public Coordinate StartPoint { get; set; }
        public Coordinate EndPoint { get; set; }
        public bool IsOrthagonal { get; set; }
        public Pen LinePen { get; set; }

        public Line()
        {
            StartPoint = new Coordinate(0, 0);
            EndPoint = new Coordinate(0, 0);
        }

        public Line(Pen pen)
        {
            LinePen = pen;
            StartPoint = new Coordinate(0, 0);
            EndPoint = new Coordinate(0, 0);
        }

        public Line(Coordinate start, Coordinate end)
        {
            StartPoint = new Coordinate(start.X, start.Y);
            EndPoint = new Coordinate(end.X, end.Y);
        }

        public byte[] ToByteArray()
        {
            List<byte> line = new List<byte>();
            line.AddRange(StartPoint.ToByteArray());
            line.AddRange(EndPoint.ToByteArray());
            return line.ToArray();
        }
        
    }
}
