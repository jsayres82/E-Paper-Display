using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPaperCommunicator
{
    public partial class ePaperView : Form
    {

        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = CharSet.Auto)]
        extern static bool DestroyIcon(IntPtr handle);
        private string[] portList;
        private EpdCommunicator epd;
        private List<string> messageQueue;
        private List<Bitmap> bmpImages;
        private List<Point> line;
        private Pen canvasPen;
        private ToolTip tt;
        Dictionary<string, int> messageDictionary = new Dictionary<string, int>()
        {
            {"GetColor", 2},
            {"GetFont", 1},
            {"GetStorage", 1},
            {"GetDisplayDirection", 1},
            {"HandShake", 2},
            {"SetStorage", 2},
            {"SetDisplay", 2},
            {"SetForeColor", 2},
            {"SetBackColor", 2},
            {"SetFont", 2},
            {"ClearScreen", 2 },
            {"UpdateScreen", 2 }
        };

        public ePaperView()
        {
            InitializeComponent();
            pbCanvas.AllowDrop = true;
            unWireFormEvents();
            cbBackGround.DataSource = Enum.GetValues(typeof(Constants.ScreenColor));
            cbForeGround.DataSource = Enum.GetValues(typeof(Constants.ScreenColor));
            cbFont.DataSource = Enum.GetValues(typeof(Constants.FontSize));
            bmpImages = new List<Bitmap>();
            line = new List<Point>();
            messageQueue = new List<string>();
            epd = new EpdCommunicator(this.epdPort);
            epd.EpdConnected += Epd_EpdConnected;

            tt = new ToolTip();
            canvasPen = new Pen(Color.Black);
        }

        private void UpdateDrawingTimer_Tick(object sender, EventArgs e)
        {
            if (line.Count == 1)
            {

            }
        }

        private void unWireFormEvents()
        {
            rbNand.CheckedChanged -= rbNand_CheckedChanged;
            rbLandScape.CheckedChanged -= rbLandScape_CheckedChanged;
            cbBackGround.SelectedIndexChanged -= cbBackGround_SelectedIndexChanged;
            cbForeGround.SelectedIndexChanged -= cbForeGround_SelectedIndexChanged;
            cbFont.SelectedIndexChanged -= cbFont_SelectedIndexChanged;
        }

        private void wireFormEvents()
        {
            rbNand.CheckedChanged += rbNand_CheckedChanged;
            rbLandScape.CheckedChanged += rbLandScape_CheckedChanged;
            cbBackGround.SelectedIndexChanged += cbBackGround_SelectedIndexChanged;
            cbForeGround.SelectedIndexChanged += cbForeGround_SelectedIndexChanged;
            cbFont.SelectedIndexChanged += cbFont_SelectedIndexChanged;
        }

        private void Epd_EpdConnected(object sender, EventArgs e)
        {
            messageQueue.Add("GetColor");
            epd.GetDrawingColor();

            messageQueue.Add("GetFont");
            epd.GetActiveStorage();

            messageQueue.Add("GetStorage");
            epd.GetActiveStorage();

            messageQueue.Add("GetDisplayDirection");
            epd.GetDisplayDirection();

            wireFormEvents();

        }

        private void ePaperView_Load(object sender, EventArgs e)
        {
            portList = SerialPort.GetPortNames();
            cbPort.DataSource = portList;
            cbBaudRate.SelectedIndex = 5;
            cbDataBits.SelectedIndex = 3;
            cbStopBits.SelectedIndex = 0;

            epd.ComPortName = cbPort.Text;
            epd.ComPortDataBits = Convert.ToInt32(cbDataBits.Text);
            epd.ComPortBaudRate = Convert.ToInt32(cbBaudRate.Text);
            StopBits stopBits = StopBits.One;
            Enum.TryParse<StopBits>(cbStopBits.Text, out stopBits);
            epd.ComPortStopBits = stopBits;

        }

        private void cbPort_DropDown(object sender, EventArgs e)
        {
            portList = SerialPort.GetPortNames();
            cbPort.DataSource = portList;
        }

        private void cbPort_SelectedIndexChanged(object sender, EventArgs e)
        {
            epd.ComPortName = portList[cbPort.SelectedIndex];
        }

        public void UpdateRadioButton(RadioButton btn, bool value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<RadioButton, bool>(UpdateRadioButton), btn, value);
                return;
            }
            btn.Checked = value;
        }

        public void UpdateComboBox(ComboBox cb, string value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<ComboBox, string>(UpdateComboBox), cb, value);
                return;
            }
            cb.Text = value;
        }

        public void UpdateComboBox(ComboBox cb, int value)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<ComboBox, int>(UpdateComboBox), cb, value);
                return;
            }
            cb.SelectedIndex = value;
        }

        private void epdPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            if (messageQueue.Count == 0)
                epdPort.ReadExisting();
            else if (epdPort.BytesToRead < messageDictionary[messageQueue.First()])
                return;

            while (epdPort.BytesToRead > 0)
            {
                byte[] response = new byte[messageDictionary[messageQueue.First()]];
                epdPort.Read(response, 0, messageDictionary[messageQueue.First()]);

                string responseString = Encoding.ASCII.GetString(response);

                string currentMessage = messageQueue.First();
                messageQueue.Remove(currentMessage);

                if (currentMessage.Equals("HandShake"))
                    return;
                else if (currentMessage.Equals("DrawImage"))
                {
                    epdPort.ReadExisting();

                    messageQueue.Add("UpdateScreen");
                    epd.Repaint();

                }
                else if (currentMessage.Equals("Draw"))
                {
                    if (responseString.Equals("OK"))
                    {
                        messageQueue.Add("UpdateScreen");
                        epd.Repaint();
                    }
                }
                else if (currentMessage.Equals("UpdateScreen"))
                {
                    epdPort.ReadExisting();
                }
                else if (currentMessage.Equals("StorageUpdate"))
                {
                    if (response[0] == 0)
                        UpdateRadioButton(rbNand, true);
                    else
                        UpdateRadioButton(rbMicroSD, true);
                }
                else if (currentMessage.Equals("DisplayDirection"))
                {
                    if (response[0] - 0x30 == 0)
                        UpdateRadioButton(rbLandScape, true);
                    else
                        UpdateRadioButton(rbPortrait, true);
                }
                else if (currentMessage.Equals("ColorUpdate"))
                {
                    UpdateComboBox(cbBackGround, response[0] - 0x30);
                    UpdateComboBox(cbForeGround, response[1] - 0x30);
                }
                else if (currentMessage.Equals("FontUpdate"))
                {
                    UpdateComboBox(cbFont, response[0] - 0x30);
                }
            }

        }

        private void rbNand_CheckedChanged(object sender, EventArgs e)
        {
            messageQueue.Add("SetStorage");
            epd.SetMicroSDStorage(rbNand.Checked ? false : true);
        }
        
        private void rbLandScape_CheckedChanged(object sender, EventArgs e)
        {
            messageQueue.Add("SetDisplay");
            epd.SetDisplayToPortrait(rbLandScape.Checked ? false : true);
        }

        private void cbForeGround_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbForeGround.SelectedIndex)
            {
                case Constants.BLACK:
                    canvasPen.Color = Color.Black;
                    break;
                case Constants.DARK_GRAY:
                    canvasPen.Color = Color.DarkGray;
                    break;
                case Constants.GRAY:
                    canvasPen.Color = Color.Gray;
                    break;
                case Constants.WHITE:
                    canvasPen.Color = Color.White;
                    break;
                default:
                    canvasPen.Color = Color.Black;
                    break;
            }
            messageQueue.Add("SetForeColor");
            epd.SetColor(Convert.ToByte(cbForeGround.SelectedIndex), Convert.ToByte(cbBackGround.SelectedIndex));
        }

        private void cbBackGround_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbBackGround.SelectedIndex)
            {
                case Constants.BLACK:
                    pbCanvas.BackColor = Color.Black;
                    break;
                case Constants.DARK_GRAY:
                    pbCanvas.BackColor = Color.DarkGray;
                    break;
                case Constants.GRAY:
                    pbCanvas.BackColor = Color.Gray;
                    break;
                case Constants.WHITE:
                    pbCanvas.BackColor = Color.White;
                    break;
                default:
                    pbCanvas.BackColor = Color.White;
                    break;
            }
            messageQueue.Add("SetBackColor");
            epd.SetColor(Convert.ToByte(cbForeGround.SelectedIndex), Convert.ToByte(cbBackGround.SelectedIndex));
        }

        private void cbFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            messageQueue.Add("SetFont");
            epd.SetEnglishFontSize(Convert.ToByte(cbFont.SelectedIndex));
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (!epd.ComPortConnected)
            {
                messageQueue.Add("HandShake");
                epd.EpdConnect();
            }
            else
            {
                epd.EpdDisConnect();
                btnConnect.Text = "CONNECT";
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            messageQueue.Add("ClearScreen");
            epd.ClearScreen();
            messageQueue.Add("UpdateScreen");
            epd.Repaint();
        }

        private void tsBtnImgListOpen_Click(object sender, EventArgs e)
        {
            // Show the FolderBrowserDialog.
            DialogResult result = fbdImageFolderSelect.ShowDialog();
            if (result == DialogResult.OK)
            {
                string folderName = fbdImageFolderSelect.SelectedPath;

                string[] images = System.IO.Directory.GetFiles(folderName);
                images = images.Where(F => System.IO.Path.GetExtension(F) == ".BMP").ToArray();
                TreeNode[] myTreeNodeArray = new TreeNode[images.Length];
                int countIndex = 0;
                foreach (string Img in images)
                {
                    Bitmap bmp = new Bitmap(Img);
                    bmpImages.Add(bmp);
                    ilBitmaps.Images.Add(bmp);
                    myTreeNodeArray[countIndex] = new TreeNode(Img.Split('\\').Last(), ilBitmaps.Images.Count - 1, ilBitmaps.Images.Count - 1);
                    countIndex++;
                }

                TreeNode imgNode = new TreeNode(folderName.Split('\\').Last(), 0, 0, myTreeNodeArray);
                tvImageListView.Nodes.Add(imgNode);
            }
        }

        private void tvImageListView_ItemDrag(object sender, ItemDragEventArgs e)
        {
            var node = (TreeNode)e.Item;
            Bitmap bmp = bmpImages[node.SelectedImageIndex - 1];
            var dragImage = bmp;
            IntPtr icon = dragImage.GetHicon();
            Cursor.Current = new Cursor(icon);
            tvImageListView.DoDragDrop(bmp, DragDropEffects.Copy);
            DestroyIcon(icon);
        }

        private void tvImageListView_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {
            e.UseDefaultCursors = false;
        }

        private void pbCanvas_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Bitmap)))
                e.Effect = DragDropEffects.Copy;
        }

        private void pbCanvas_DragDrop(object sender, DragEventArgs e)
        {
            var bmp = (Bitmap)e.Data.GetData(typeof(Bitmap));
            Point bmplocation = pbCanvas.PointToClient(new Point(e.X - bmp.Width / 2, e.Y - bmp.Height / 2));
            try
            {
                Bitmap newImg = new Bitmap(pbCanvas.Image);
                // Assign the first image to the picture variable.
                using (Graphics g = Graphics.FromImage(newImg))
                {
                    g.DrawImage(bmp, bmplocation);
                }
                pbCanvas.Image = newImg;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }            
        }


        private void tsBtnLine_Click(object sender, EventArgs e)
        {
            pbCanvas.Cursor = Cursors.Cross;
            pbCanvas.MouseDown += pbCanvas_DrawLineMouseDown;
        }

        private void pbCanvas_DrawLineMouseDown(object sender, MouseEventArgs e)
        {
            pbCanvas.MouseDown -= pbCanvas_DrawLineMouseDown;
            pbCanvas.MouseUp += pbCanvas_DrawLineMouseUp;
            line.Add(e.Location);
        }

        private string getCanvasCoordinates()
        {
            this.Cursor = new Cursor(Cursor.Current.Handle);
            Point location = this.pbCanvas.PointToClient(Cursor.Position);
            return string.Format("X={0}, Y={1}", location.X, location.Y);
        }

        private void pbCanvas_DrawLineMouseUp(object sender, MouseEventArgs e)
        {
            pbCanvas.MouseUp -= pbCanvas_DrawLineMouseUp;
            line.Add(e.Location);
            Bitmap newImg = new Bitmap(pbCanvas.Image);
            using (Graphics g = Graphics.FromImage(newImg))
            {
                g.DrawLine(new Pen(Color.Black, 3), line[0], line[1]);
            }
            line.Clear();
            pbCanvas.Cursor = Cursors.Default;
            pbCanvas.Image = newImg;
        }
        
        private void pbCanvas_MouseHover(object sender, EventArgs e)
        {
            tt.AutoPopDelay = 2000;
            tt.Show(getCanvasCoordinates(), pbCanvas);
        }
        private void tvImageListView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node == tvImageListView.Nodes[0])
            {
                if (e.Node.IsExpanded)
                    e.Node.Expand();
                else
                    e.Node.Collapse();
                return;
            }
            try
            {
                var bmp = bmpImages[e.Node.SelectedImageIndex - 1];
                Point bmplocation = new Point(0, 0);
                Bitmap newImg = new Bitmap(pbCanvas.Image);
                // Assign the first image to the picture variable.
                using (Graphics g = Graphics.FromImage(newImg))
                {
                    g.DrawImage(bmp, bmplocation);
                }
                pbCanvas.Image = newImg;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            messageQueue.Add("DrawImage");
            epd.DisplayImage(0, 0, e.Node.Text);
        }

        private void pbCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            //tt.Hide(pbCanvas);
        }
    }
}
