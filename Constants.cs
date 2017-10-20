using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPaperCommunicator
{
    static class Constants
    {
        public const int CMD_SIZE = 512;

        /*
        frame format
        */
        public const byte FRAME_HEADER = 0xA5;
        public const byte FRAME_END0 = 0xCC;
        public const byte FRAME_END1 = 0x33;
        public const byte FRAME_END2 = 0xC3;
        public const byte FRAME_END3 = 0x3C;

        public const int FRAME_HEADER_PART_LENGTH = 1;
        public const int FRAME_LENGTH_PART_LENGTH = 2;
        public const int COMMAND_PART_LENGTH = 1;
        public const int FRAME_END_PART_LENGTH = 4;
        public const int PARITIY_BYTE_PART_LENGTH = 1;


        public const int FRAME_HEADER_OFFSET = 0;
        public const int FRAME_LENGTH_OFFSET = FRAME_HEADER_PART_LENGTH;
        public const int FRAME_COMMAND_OFFSET = FRAME_LENGTH_OFFSET + FRAME_LENGTH_PART_LENGTH;
        public const int FRAME_PARAMETERS_OFFSET = FRAME_COMMAND_OFFSET + FRAME_LENGTH_PART_LENGTH;


        public enum ScreenColor {
            BLACK,
            DARK_GRAY,
            GRAY,
            WHITE
        }
        public enum FontSize
        {            
            ASCII32 = 1,
            ASCII48 = 2,
            ASCII64 = 3
        }
        /*
        color define
        */
        public const byte WHITE = 0x03;
        public const byte GRAY = 0x02;
        public const byte DARK_GRAY = 0x01;
        public const byte BLACK = 0x00;

        /*
        command define
        */
        public const byte CMD_HANDSHAKE = 0x00;      //handshake
        public const byte CMD_SET_BAUD =  0x01;      //set baud
        public const byte CMD_READ_BAUD = 0x02;      //read baud
        public const byte CMD_READ_MEMORYMODE = 0x06;    // read storage type used(Nand/uSD)
        public const byte CMD_MEMORYMODE = 0x07;      //set memory mode
        public const byte CMD_STOPMODE =  0x08;      //enter stop mode
        public const byte CMD_UPDATE = 0x0A;      //Refresh and update display
        public const byte CMD_READ_ROTATION = 0x0C;    // read screen rotation
        public const byte CMD_SCREEN_ROTATION = 0x0D;      //set screen rotation
        public const byte CMD_LOAD_FONT = 0x0E;      //load font
        public const byte CMD_LOAD_PIC =  0x0F;      //load picture

        public const byte CMD_SET_COLOR = 0x10;      //set color
        public const byte CMD_READ_COLOR = 0x11;      //read color
        public const byte CMD_READ_FONTSIZE = 0x1C;      //read Font size
        public const byte CMD_READ_CNFONTSIZE = 0x1D;      //read Chinese Font size

        public const byte CMD_SET_EN_FONT = 0x1E;      //set english font
        public const byte CMD_SET_CH_FONT = 0x1F;      //set chinese font

        public const byte CMD_DRAW_PIXEL =  0x20;      //set pixel
        public const byte CMD_DRAW_LINE = 0x22;      //draw line
        public const byte CMD_FILL_RECT = 0x24;      //fill rectangle
        public const byte CMD_DRAW_RECT = 0x25;      //draw rectangle
        public const byte CMD_DRAW_CIRCLE = 0x26;      //draw circle
        public const byte CMD_FILL_CIRCLE = 0x27;      //fill circle
        public const byte CMD_DRAW_TRIANGLE = 0x28;      //draw triangle
        public const byte CMD_FILL_TRIANGLE = 0x29;      //fill triangle
        public const byte CMD_CLEAR = 0x2E;      //clear screen use back color

        public const byte CMD_DRAW_STRING = 0x30;      //draw string

        public const byte CMD_DRAW_BITMAP = 0x70;     //draw bitmap


        /*
        FONT
        */
        public const byte GBK32 = 0x01;
        public const byte GBK48 = 0x02;
        public const byte GBK64 = 0x03;

        public const byte ASCII32 = 0x01;
        public const byte ASCII48 = 0x02;
        public const byte ASCII64 = 0x03;



        /*
        Memory Mode
        */
        public const byte MEM_NAND = 0;
        public const byte MEM_TF = 1;

        /*
        set screen rotation
        */
        public const byte EPD_NORMAL = 0;  //screen normal
        public const byte EPD_PORTRAIT = 1;   //screen inversion

        public const byte STRING_END = 0;
        public const string COMMAND_OK = "OK";

    }
}
