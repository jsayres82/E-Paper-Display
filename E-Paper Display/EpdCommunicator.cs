using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPaperCommunicator
{
    public class EpdCommunicator
    {

        private bool comPortConnected = false;
        // Create the serial port with basic settings 
        private SerialPort port; 
        public string ComPortName { get; set; }
        public int ComPortBaudRate { get; set; }
        public int ComPortDataBits { get; set; }
        public StopBits ComPortStopBits { get; set; }
        public Parity ComPortParity { get; set; }
        public bool ComPortConnected { get { return comPortConnected; } }

        public event EventHandler EpdConnected;

        public delegate void onEpdConnected(object sender, EventArgs e);

        public EpdCommunicator()
        {
            comPortConnected = false;
        }
        public EpdCommunicator(SerialPort sp)
        {
            comPortConnected = false;
            port = sp;

        }
        public void EpdConnect()
        {
            if(!comPortConnected)
            {
                port.PortName = ComPortName;
                port.BaudRate = ComPortBaudRate;
                port.DataBits = ComPortDataBits;
                port.StopBits = ComPortStopBits;
                // Begin communications 
                port.Open();
                while (!port.IsOpen);

                comPortConnected = true;
                EpdHandShake();
                EpdConnected.Invoke(this, new EventArgs());
            }
            else
            {

            }                
        }
        public void EpdDisConnect()
        {
            if (comPortConnected)
            {
                port.Close();
                comPortConnected = false;
            }
            else
            {

            }
        }
        public void EpdHandShake()
        {
            sendEpdMessage(new EpdMessage(Constants.CMD_HANDSHAKE));
        }
        public void Repaint()
        {
            sendEpdMessage(new EpdMessage(Constants.CMD_UPDATE));
        }

        public void ClearScreen()
        {
            sendEpdMessage(new EpdMessage(Constants.CMD_CLEAR));
        }

        public void DrawPoint(int x, int y)
        {
            Coordinate point = new Coordinate(Convert.ToInt16(x), Convert.ToInt16(y));
            sendEpdMessage(new EpdMessage(Constants.CMD_DRAW_PIXEL, point));
        }

        public void DrawLine(int startX, int startY, int targetX, int targetY)
        {
            List<Coordinate> line = new List<Coordinate>();
            line.Add(new Coordinate(Convert.ToInt16(startX), Convert.ToInt16(startY)));
            line.Add(new Coordinate(Convert.ToInt16(targetX), Convert.ToInt16(targetY)));

            sendEpdMessage(new EpdMessage(Constants.CMD_DRAW_LINE, line));
        }

        public void DrawRectangle(int x0, int y0, int x1, int y1, bool filled)
        {
            byte command = filled ? Constants.CMD_FILL_RECT : Constants.CMD_DRAW_RECT;
            List<Coordinate> rectangle = new List<Coordinate>();
            rectangle.Add(new Coordinate(Convert.ToInt16(x0), Convert.ToInt16(y0)));
            rectangle.Add(new Coordinate(Convert.ToInt16(x1), Convert.ToInt16(y1)));
            sendEpdMessage(new EpdMessage(command, rectangle));
        }

        public void DrawCircle(int x, int y, int radius, bool filled)
        {
            byte command = filled ? Constants.CMD_FILL_CIRCLE : Constants.CMD_DRAW_CIRCLE;
            Circle c = new Circle(new Coordinate(Convert.ToInt16(x), Convert.ToInt16(x)), Convert.ToInt16(radius));
            sendEpdMessage(new EpdMessage(command, c));
        }

        public void DrawTriangle(int x0, int y0, int x1, int y1, int x2, int y2, bool filled)
        {
            byte command = filled ? Constants.CMD_FILL_TRIANGLE : Constants.CMD_DRAW_TRIANGLE;
            List<Coordinate> triangle = new List<Coordinate>();
            triangle.Add(new Coordinate(Convert.ToInt16(x0), Convert.ToInt16(y0)));
            triangle.Add(new Coordinate(Convert.ToInt16(x1), Convert.ToInt16(y1)));
            triangle.Add(new Coordinate(Convert.ToInt16(x1), Convert.ToInt16(y1)));
            sendEpdMessage(new EpdMessage(command, triangle));
        }

        public void DisplayText(int x, int y, string text)
        {
            byte[] textBytes = this.encodestringForDevice(text);
            Coordinate position = new Coordinate(Convert.ToInt16(x), Convert.ToInt16(y));

            sendEpdMessage(new EpdMessage(Constants.CMD_DRAW_STRING, position, textBytes));
        }

        public void DisplayImage(int x, int y, string fileName)
        {
            byte[] fileNameBytes = this.encodestringForDevice(fileName);
            Coordinate position = new Coordinate(Convert.ToInt16(x), Convert.ToInt16(y));           
            sendEpdMessage(new EpdMessage(Constants.CMD_DRAW_BITMAP, position, fileNameBytes));
        }

        public void GetEnglishFontSize()
        {
            sendEpdMessage(new EpdMessage(Constants.CMD_READ_FONTSIZE));
        }

        public void SetEnglishFontSize(int fontsize)
        {
            sendEpdMessage(new EpdMessage(Constants.CMD_SET_EN_FONT, fontsize));
        }

        public void GetChineseFontSize()
        {
            sendEpdMessage(new EpdMessage(Constants.CMD_READ_CNFONTSIZE));
        }

        public void SetChineseFontSize(int fontsize)
        {
            sendEpdMessage(new EpdMessage(Constants.CMD_SET_CH_FONT, fontsize));
        }

        public void SetColor(byte backgroundColor, byte foregroundColor)
        {
            byte[] colorParameter = new byte[] { backgroundColor,  foregroundColor };
            sendEpdMessage(new EpdMessage(Constants.CMD_SET_COLOR, colorParameter));
        }

        public void GetDrawingColor()
        {
            sendEpdMessage(new EpdMessage(Constants.CMD_READ_COLOR));
        }
        
        public void ImportFont(string fileName)
        {
            byte[] textBytes = this.encodestringForDevice(fileName);
            sendEpdMessage(new EpdMessage(Constants.CMD_LOAD_FONT, textBytes));
        }

        public void ImportImage(string fileName)
        {
            byte[] textBytes = this.encodestringForDevice(fileName);
            sendEpdMessage(new EpdMessage(Constants.CMD_DRAW_BITMAP, textBytes));
        }

        public void SetDisplayToPortrait(bool usePortrait)
        {            
            sendEpdMessage(new EpdMessage(Constants.CMD_SCREEN_ROTATION, usePortrait));
        }

        public void GetDisplayDirection()
        {
            sendEpdMessage(new EpdMessage(Constants.CMD_READ_ROTATION));
        }

        public void GetActiveStorage()
        {
            sendEpdMessage(new EpdMessage(Constants.CMD_READ_MEMORYMODE));
        }

        public void SetMicroSDStorage(bool useMicroSD)
        {
            sendEpdMessage(new EpdMessage(Constants.CMD_MEMORYMODE, useMicroSD));
        }

        private byte[] encodestringForDevice(string text)
        {
            List<byte> t = new List<byte>();
            byte[] textParameter = Encoding.ASCII.GetBytes(text);
            t.AddRange(textParameter);
            t.Add(Constants.STRING_END);
            return t.ToArray() ;
        }

        public void GetBaudRate()
        {
            sendEpdMessage(new EpdMessage(Constants.CMD_READ_BAUD));            
        }

        public void SetBaudRate(int baudRate)
        {
            sendEpdMessage(new EpdMessage(Constants.CMD_SET_BAUD, baudRate));
        }
        
        private void sendEpdMessage(EpdMessage msg)
        {
            port.Write(msg.Message, 0, msg.Message.Length);
        }
    }
}
