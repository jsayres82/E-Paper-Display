using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPaperCommunicator
{
    public class EpdMessage
    {
        private short length;
        private byte[] frameEnd = { Constants.FRAME_END0, Constants.FRAME_END1, Constants.FRAME_END2, Constants.FRAME_END3 };
        private byte[] epdMessage;

        public byte[] Message { get { return epdMessage; } }

        public EpdMessage(byte cmd)
        {
            List<byte> p = new List<byte>();
            epdMessage = buildTransmissionFrame(cmd, p.ToArray());
        }

        public EpdMessage(byte cmd, int val)
        {
            List<byte> p = new List<byte>();
            p.Add(Convert.ToByte(val));
            epdMessage = buildTransmissionFrame(cmd, p.ToArray());
        }

        public EpdMessage(byte cmd, bool state)
        {
            List<byte> p = new List<byte>();
            p.Add(Convert.ToByte(state));
            epdMessage = buildTransmissionFrame(cmd, p.ToArray());
        }

        public EpdMessage(byte cmd, Coordinate position, byte[] text)
        {
            List<byte> p = new List<byte>();
            p.AddRange(position.ToByteArray());
            p.AddRange(text);
            epdMessage = buildTransmissionFrame(cmd, p.ToArray());
        }

        public EpdMessage(byte cmd, byte[] array)
        {
            List<byte> p = new List<byte>();
            p.AddRange(array);
            epdMessage = buildTransmissionFrame(cmd, p.ToArray());
        }

        public EpdMessage(byte cmd, Coordinate point)
        {
            List<byte> p = new List<byte>();
            p.AddRange(point.ToByteArray());
            epdMessage = buildTransmissionFrame(cmd, p.ToArray());
        }

        public EpdMessage(byte cmd, List<Coordinate> points)
        {
            List<byte> p = new List<byte>();
            foreach (Coordinate point in points)
                p.AddRange(point.ToByteArray());

            epdMessage = buildTransmissionFrame(cmd, p.ToArray());
        }

        public EpdMessage(byte cmd, Circle c)
        {
            List<byte> p = new List<byte>();
            p.AddRange(c.ToByteArray().Reverse());
            epdMessage = buildTransmissionFrame(cmd, p.ToArray());
        }

        private byte[] buildTransmissionFrame(byte command, byte[] parameters)
        {
            length = Convert.ToInt16(Constants.FRAME_HEADER_PART_LENGTH + 
                        Constants.FRAME_LENGTH_PART_LENGTH + 
                        Constants.COMMAND_PART_LENGTH + 
                        Constants.FRAME_END_PART_LENGTH + 
                        Constants.PARITIY_BYTE_PART_LENGTH);

            if (parameters != null)
                length += Convert.ToInt16(parameters.Length);

            List<byte> frameToTransmit = new List<byte>();
            frameToTransmit.Add(Constants.FRAME_HEADER);

            foreach (byte b in BitConverter.GetBytes(length).Reverse())
                frameToTransmit.Add(b);

            frameToTransmit.Add(command);

            if(parameters != null)
                foreach (byte b in parameters)
                    frameToTransmit.Add(b);

            foreach (byte b in frameEnd)
                frameToTransmit.Add(b);

            byte parityByte = calculateParityByte(frameToTransmit.ToArray());
            frameToTransmit.Add(parityByte);

            return frameToTransmit.ToArray();
        }

        private byte calculateParityByte(byte[] frame)
        {
            byte parityByte = (byte)0x00;

            for (int i = 0; i < frame.Length; i++)
            {
                parityByte ^= frame[i];
            }

            return parityByte;
        }
    }
}
