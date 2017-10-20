namespace EPaperCommunicator
{
    partial class ePaperView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ePaperView));
            this.epdPort = new System.IO.Ports.SerialPort(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.gbSerial = new System.Windows.Forms.GroupBox();
            this.labelStopBits = new System.Windows.Forms.Label();
            this.labelDataBits = new System.Windows.Forms.Label();
            this.labelBaudRate = new System.Windows.Forms.Label();
            this.label_ComPort = new System.Windows.Forms.Label();
            this.cbStopBits = new System.Windows.Forms.ComboBox();
            this.cbDataBits = new System.Windows.Forms.ComboBox();
            this.cbBaudRate = new System.Windows.Forms.ComboBox();
            this.cbPort = new System.Windows.Forms.ComboBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.gbConfiguration = new System.Windows.Forms.GroupBox();
            this.labelFont = new System.Windows.Forms.Label();
            this.cbFont = new System.Windows.Forms.ComboBox();
            this.labelBackGround = new System.Windows.Forms.Label();
            this.cbBackGround = new System.Windows.Forms.ComboBox();
            this.labelForeGround = new System.Windows.Forms.Label();
            this.cbForeGround = new System.Windows.Forms.ComboBox();
            this.gbRotation = new System.Windows.Forms.GroupBox();
            this.rbPortrait = new System.Windows.Forms.RadioButton();
            this.rbLandScape = new System.Windows.Forms.RadioButton();
            this.gbStorage = new System.Windows.Forms.GroupBox();
            this.rbNand = new System.Windows.Forms.RadioButton();
            this.rbMicroSD = new System.Windows.Forms.RadioButton();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.gbDraw = new System.Windows.Forms.GroupBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panelImage = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.tsImage = new System.Windows.Forms.ToolStrip();
            this.tsBtnLine = new System.Windows.Forms.ToolStripButton();
            this.tsBtnRect = new System.Windows.Forms.ToolStripButton();
            this.tsBtnFilledRect = new System.Windows.Forms.ToolStripButton();
            this.tsBtnCircle = new System.Windows.Forms.ToolStripButton();
            this.tsBtnFilledCircle = new System.Windows.Forms.ToolStripButton();
            this.tsBtnText = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.tsBtnOpenImage = new System.Windows.Forms.ToolStripButton();
            this.tsBtnSaveImage = new System.Windows.Forms.ToolStripButton();
            this.panelImageList = new System.Windows.Forms.Panel();
            this.tvImageListView = new System.Windows.Forms.TreeView();
            this.ilBitmaps = new System.Windows.Forms.ImageList(this.components);
            this.toolStripImageList = new System.Windows.Forms.ToolStrip();
            this.tsBtnImgListOpen = new System.Windows.Forms.ToolStripButton();
            this.fbdImageFolderSelect = new System.Windows.Forms.FolderBrowserDialog();
            this.ofdImageOpen = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbSerial.SuspendLayout();
            this.gbConfiguration.SuspendLayout();
            this.gbRotation.SuspendLayout();
            this.gbStorage.SuspendLayout();
            this.gbDraw.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panelImage.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            this.tsImage.SuspendLayout();
            this.panelImageList.SuspendLayout();
            this.toolStripImageList.SuspendLayout();
            this.SuspendLayout();
            // 
            // epdPort
            // 
            this.epdPort.BaudRate = 115200;
            this.epdPort.DtrEnable = true;
            this.epdPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.epdPort_DataReceived);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.gbSerial);
            this.splitContainer1.Panel1.Controls.Add(this.gbConfiguration);
            this.splitContainer1.Panel1.Controls.Add(this.btnRefresh);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AllowDrop = true;
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Control;
            this.splitContainer1.Panel2.Controls.Add(this.gbDraw);
            this.splitContainer1.Size = new System.Drawing.Size(694, 551);
            this.splitContainer1.SplitterDistance = 292;
            this.splitContainer1.TabIndex = 1;
            // 
            // gbSerial
            // 
            this.gbSerial.Controls.Add(this.labelStopBits);
            this.gbSerial.Controls.Add(this.labelDataBits);
            this.gbSerial.Controls.Add(this.labelBaudRate);
            this.gbSerial.Controls.Add(this.label_ComPort);
            this.gbSerial.Controls.Add(this.cbStopBits);
            this.gbSerial.Controls.Add(this.cbDataBits);
            this.gbSerial.Controls.Add(this.cbBaudRate);
            this.gbSerial.Controls.Add(this.cbPort);
            this.gbSerial.Controls.Add(this.btnConnect);
            this.gbSerial.Location = new System.Drawing.Point(17, 12);
            this.gbSerial.Name = "gbSerial";
            this.gbSerial.Size = new System.Drawing.Size(145, 273);
            this.gbSerial.TabIndex = 0;
            this.gbSerial.TabStop = false;
            this.gbSerial.Text = "Serial";
            // 
            // labelStopBits
            // 
            this.labelStopBits.AutoSize = true;
            this.labelStopBits.Location = new System.Drawing.Point(6, 162);
            this.labelStopBits.Name = "labelStopBits";
            this.labelStopBits.Size = new System.Drawing.Size(46, 13);
            this.labelStopBits.TabIndex = 8;
            this.labelStopBits.Text = "StopBits";
            // 
            // labelDataBits
            // 
            this.labelDataBits.AutoSize = true;
            this.labelDataBits.Location = new System.Drawing.Point(6, 122);
            this.labelDataBits.Name = "labelDataBits";
            this.labelDataBits.Size = new System.Drawing.Size(47, 13);
            this.labelDataBits.TabIndex = 7;
            this.labelDataBits.Text = "DataBits";
            // 
            // labelBaudRate
            // 
            this.labelBaudRate.AutoSize = true;
            this.labelBaudRate.Location = new System.Drawing.Point(6, 72);
            this.labelBaudRate.Name = "labelBaudRate";
            this.labelBaudRate.Size = new System.Drawing.Size(55, 13);
            this.labelBaudRate.TabIndex = 6;
            this.labelBaudRate.Text = "BaudRate";
            // 
            // label_ComPort
            // 
            this.label_ComPort.AutoSize = true;
            this.label_ComPort.Location = new System.Drawing.Point(6, 32);
            this.label_ComPort.Name = "label_ComPort";
            this.label_ComPort.Size = new System.Drawing.Size(26, 13);
            this.label_ComPort.TabIndex = 5;
            this.label_ComPort.Text = "Port";
            // 
            // cbStopBits
            // 
            this.cbStopBits.FormattingEnabled = true;
            this.cbStopBits.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cbStopBits.Location = new System.Drawing.Point(6, 178);
            this.cbStopBits.Name = "cbStopBits";
            this.cbStopBits.Size = new System.Drawing.Size(121, 21);
            this.cbStopBits.TabIndex = 4;
            // 
            // cbDataBits
            // 
            this.cbDataBits.FormattingEnabled = true;
            this.cbDataBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.cbDataBits.Location = new System.Drawing.Point(6, 138);
            this.cbDataBits.Name = "cbDataBits";
            this.cbDataBits.Size = new System.Drawing.Size(121, 21);
            this.cbDataBits.TabIndex = 3;
            // 
            // cbBaudRate
            // 
            this.cbBaudRate.FormattingEnabled = true;
            this.cbBaudRate.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400"});
            this.cbBaudRate.Location = new System.Drawing.Point(6, 88);
            this.cbBaudRate.Name = "cbBaudRate";
            this.cbBaudRate.Size = new System.Drawing.Size(121, 21);
            this.cbBaudRate.TabIndex = 2;
            // 
            // cbPort
            // 
            this.cbPort.FormattingEnabled = true;
            this.cbPort.Location = new System.Drawing.Point(6, 48);
            this.cbPort.Name = "cbPort";
            this.cbPort.Size = new System.Drawing.Size(121, 21);
            this.cbPort.TabIndex = 1;
            this.cbPort.DropDown += new System.EventHandler(this.cbPort_DropDown);
            this.cbPort.SelectedIndexChanged += new System.EventHandler(this.cbPort_SelectedIndexChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(6, 205);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(95, 37);
            this.btnConnect.TabIndex = 0;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // gbConfiguration
            // 
            this.gbConfiguration.Controls.Add(this.labelFont);
            this.gbConfiguration.Controls.Add(this.cbFont);
            this.gbConfiguration.Controls.Add(this.labelBackGround);
            this.gbConfiguration.Controls.Add(this.cbBackGround);
            this.gbConfiguration.Controls.Add(this.labelForeGround);
            this.gbConfiguration.Controls.Add(this.cbForeGround);
            this.gbConfiguration.Controls.Add(this.gbRotation);
            this.gbConfiguration.Controls.Add(this.gbStorage);
            this.gbConfiguration.Location = new System.Drawing.Point(186, 12);
            this.gbConfiguration.Name = "gbConfiguration";
            this.gbConfiguration.Size = new System.Drawing.Size(196, 264);
            this.gbConfiguration.TabIndex = 1;
            this.gbConfiguration.TabStop = false;
            this.gbConfiguration.Text = "Configuration";
            // 
            // labelFont
            // 
            this.labelFont.AutoSize = true;
            this.labelFont.Location = new System.Drawing.Point(6, 221);
            this.labelFont.Name = "labelFont";
            this.labelFont.Size = new System.Drawing.Size(28, 13);
            this.labelFont.TabIndex = 13;
            this.labelFont.Text = "Font";
            // 
            // cbFont
            // 
            this.cbFont.FormattingEnabled = true;
            this.cbFont.Location = new System.Drawing.Point(6, 237);
            this.cbFont.Name = "cbFont";
            this.cbFont.Size = new System.Drawing.Size(121, 21);
            this.cbFont.TabIndex = 12;
            this.cbFont.SelectedIndexChanged += new System.EventHandler(this.cbFont_SelectedIndexChanged);
            // 
            // labelBackGround
            // 
            this.labelBackGround.AutoSize = true;
            this.labelBackGround.Location = new System.Drawing.Point(6, 180);
            this.labelBackGround.Name = "labelBackGround";
            this.labelBackGround.Size = new System.Drawing.Size(67, 13);
            this.labelBackGround.TabIndex = 11;
            this.labelBackGround.Text = "BackGround";
            // 
            // cbBackGround
            // 
            this.cbBackGround.FormattingEnabled = true;
            this.cbBackGround.Location = new System.Drawing.Point(6, 196);
            this.cbBackGround.Name = "cbBackGround";
            this.cbBackGround.Size = new System.Drawing.Size(121, 21);
            this.cbBackGround.TabIndex = 10;
            this.cbBackGround.SelectedIndexChanged += new System.EventHandler(this.cbBackGround_SelectedIndexChanged);
            // 
            // labelForeGround
            // 
            this.labelForeGround.AutoSize = true;
            this.labelForeGround.Location = new System.Drawing.Point(6, 137);
            this.labelForeGround.Name = "labelForeGround";
            this.labelForeGround.Size = new System.Drawing.Size(63, 13);
            this.labelForeGround.TabIndex = 9;
            this.labelForeGround.Text = "ForeGround";
            // 
            // cbForeGround
            // 
            this.cbForeGround.FormattingEnabled = true;
            this.cbForeGround.Location = new System.Drawing.Point(6, 153);
            this.cbForeGround.Name = "cbForeGround";
            this.cbForeGround.Size = new System.Drawing.Size(121, 21);
            this.cbForeGround.TabIndex = 8;
            this.cbForeGround.SelectedIndexChanged += new System.EventHandler(this.cbForeGround_SelectedIndexChanged);
            // 
            // gbRotation
            // 
            this.gbRotation.Controls.Add(this.rbPortrait);
            this.gbRotation.Controls.Add(this.rbLandScape);
            this.gbRotation.Location = new System.Drawing.Point(6, 82);
            this.gbRotation.Name = "gbRotation";
            this.gbRotation.Size = new System.Drawing.Size(174, 53);
            this.gbRotation.TabIndex = 2;
            this.gbRotation.TabStop = false;
            this.gbRotation.Text = "Rotation";
            // 
            // rbPortrait
            // 
            this.rbPortrait.AutoSize = true;
            this.rbPortrait.Location = new System.Drawing.Point(105, 19);
            this.rbPortrait.Name = "rbPortrait";
            this.rbPortrait.Size = new System.Drawing.Size(58, 17);
            this.rbPortrait.TabIndex = 1;
            this.rbPortrait.Text = "Portrait";
            this.rbPortrait.UseVisualStyleBackColor = true;
            // 
            // rbLandScape
            // 
            this.rbLandScape.AutoSize = true;
            this.rbLandScape.Checked = true;
            this.rbLandScape.Location = new System.Drawing.Point(19, 19);
            this.rbLandScape.Name = "rbLandScape";
            this.rbLandScape.Size = new System.Drawing.Size(80, 17);
            this.rbLandScape.TabIndex = 0;
            this.rbLandScape.TabStop = true;
            this.rbLandScape.Text = "LandScape";
            this.rbLandScape.UseVisualStyleBackColor = true;
            this.rbLandScape.CheckedChanged += new System.EventHandler(this.rbLandScape_CheckedChanged);
            // 
            // gbStorage
            // 
            this.gbStorage.Controls.Add(this.rbNand);
            this.gbStorage.Controls.Add(this.rbMicroSD);
            this.gbStorage.Location = new System.Drawing.Point(6, 23);
            this.gbStorage.Name = "gbStorage";
            this.gbStorage.Size = new System.Drawing.Size(174, 53);
            this.gbStorage.TabIndex = 0;
            this.gbStorage.TabStop = false;
            this.gbStorage.Text = "Storage";
            // 
            // rbNand
            // 
            this.rbNand.AutoSize = true;
            this.rbNand.Location = new System.Drawing.Point(91, 19);
            this.rbNand.Name = "rbNand";
            this.rbNand.Size = new System.Drawing.Size(51, 17);
            this.rbNand.TabIndex = 1;
            this.rbNand.Text = "Nand";
            this.rbNand.UseVisualStyleBackColor = true;
            this.rbNand.CheckedChanged += new System.EventHandler(this.rbNand_CheckedChanged);
            // 
            // rbMicroSD
            // 
            this.rbMicroSD.AutoSize = true;
            this.rbMicroSD.Checked = true;
            this.rbMicroSD.Location = new System.Drawing.Point(19, 19);
            this.rbMicroSD.Name = "rbMicroSD";
            this.rbMicroSD.Size = new System.Drawing.Size(66, 17);
            this.rbMicroSD.TabIndex = 0;
            this.rbMicroSD.TabStop = true;
            this.rbMicroSD.Text = "MicroSD";
            this.rbMicroSD.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(415, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(103, 23);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Refresh Screen";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // gbDraw
            // 
            this.gbDraw.BackColor = System.Drawing.SystemColors.Control;
            this.gbDraw.Controls.Add(this.splitContainer2);
            this.gbDraw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDraw.Location = new System.Drawing.Point(0, 0);
            this.gbDraw.Name = "gbDraw";
            this.gbDraw.Size = new System.Drawing.Size(694, 255);
            this.gbDraw.TabIndex = 0;
            this.gbDraw.TabStop = false;
            this.gbDraw.Text = "Draw";
            // 
            // splitContainer2
            // 
            this.splitContainer2.AllowDrop = true;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(3, 16);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panelImage);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.panelImageList);
            this.splitContainer2.Size = new System.Drawing.Size(688, 236);
            this.splitContainer2.SplitterDistance = 509;
            this.splitContainer2.TabIndex = 2;
            // 
            // panelImage
            // 
            this.panelImage.AllowDrop = true;
            this.panelImage.AutoScroll = true;
            this.panelImage.Controls.Add(this.panel1);
            this.panelImage.Controls.Add(this.tsImage);
            this.panelImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImage.Location = new System.Drawing.Point(0, 0);
            this.panelImage.Name = "panelImage";
            this.panelImage.Size = new System.Drawing.Size(509, 236);
            this.panelImage.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.pbCanvas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 211);
            this.panel1.TabIndex = 2;
            // 
            // pbCanvas
            // 
            this.pbCanvas.Image = global::EPaperCommunicator.Properties.Resources.Background;
            this.pbCanvas.Location = new System.Drawing.Point(0, 0);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(800, 600);
            this.pbCanvas.TabIndex = 1;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.DragDrop += new System.Windows.Forms.DragEventHandler(this.pbCanvas_DragDrop);
            this.pbCanvas.DragEnter += new System.Windows.Forms.DragEventHandler(this.pbCanvas_DragEnter);
            this.pbCanvas.MouseHover += new System.EventHandler(this.pbCanvas_MouseHover);
            this.pbCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbCanvas_MouseMove);
            // 
            // tsImage
            // 
            this.tsImage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnLine,
            this.tsBtnRect,
            this.tsBtnFilledRect,
            this.tsBtnCircle,
            this.tsBtnFilledCircle,
            this.tsBtnText,
            this.toolStripSeparator,
            this.tsBtnOpenImage,
            this.tsBtnSaveImage});
            this.tsImage.Location = new System.Drawing.Point(0, 0);
            this.tsImage.Name = "tsImage";
            this.tsImage.Size = new System.Drawing.Size(509, 25);
            this.tsImage.TabIndex = 0;
            this.tsImage.Text = "toolStrip1";
            // 
            // tsBtnLine
            // 
            this.tsBtnLine.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnLine.Image")));
            this.tsBtnLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnLine.Name = "tsBtnLine";
            this.tsBtnLine.Size = new System.Drawing.Size(49, 22);
            this.tsBtnLine.Text = "Line";
            this.tsBtnLine.Click += new System.EventHandler(this.tsBtnLine_Click);
            // 
            // tsBtnRect
            // 
            this.tsBtnRect.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnRect.Image")));
            this.tsBtnRect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnRect.Name = "tsBtnRect";
            this.tsBtnRect.Size = new System.Drawing.Size(79, 22);
            this.tsBtnRect.Text = "Rectangle";
            // 
            // tsBtnFilledRect
            // 
            this.tsBtnFilledRect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnFilledRect.Name = "tsBtnFilledRect";
            this.tsBtnFilledRect.Size = new System.Drawing.Size(94, 22);
            this.tsBtnFilledRect.Text = "Filled Rectangle";
            // 
            // tsBtnCircle
            // 
            this.tsBtnCircle.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnCircle.Image")));
            this.tsBtnCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnCircle.Name = "tsBtnCircle";
            this.tsBtnCircle.Size = new System.Drawing.Size(57, 22);
            this.tsBtnCircle.Text = "Circle";
            // 
            // tsBtnFilledCircle
            // 
            this.tsBtnFilledCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnFilledCircle.Name = "tsBtnFilledCircle";
            this.tsBtnFilledCircle.Size = new System.Drawing.Size(72, 22);
            this.tsBtnFilledCircle.Text = "Filled Circle";
            // 
            // tsBtnText
            // 
            this.tsBtnText.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnText.Image")));
            this.tsBtnText.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnText.Name = "tsBtnText";
            this.tsBtnText.Size = new System.Drawing.Size(49, 22);
            this.tsBtnText.Text = "Text";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // tsBtnOpenImage
            // 
            this.tsBtnOpenImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnOpenImage.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnOpenImage.Image")));
            this.tsBtnOpenImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnOpenImage.Name = "tsBtnOpenImage";
            this.tsBtnOpenImage.Size = new System.Drawing.Size(23, 22);
            this.tsBtnOpenImage.Text = "&Open";
            // 
            // tsBtnSaveImage
            // 
            this.tsBtnSaveImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnSaveImage.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnSaveImage.Image")));
            this.tsBtnSaveImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnSaveImage.Name = "tsBtnSaveImage";
            this.tsBtnSaveImage.Size = new System.Drawing.Size(23, 22);
            this.tsBtnSaveImage.Text = "&Save";
            // 
            // panelImageList
            // 
            this.panelImageList.AllowDrop = true;
            this.panelImageList.Controls.Add(this.tvImageListView);
            this.panelImageList.Controls.Add(this.toolStripImageList);
            this.panelImageList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelImageList.Location = new System.Drawing.Point(0, 0);
            this.panelImageList.Name = "panelImageList";
            this.panelImageList.Size = new System.Drawing.Size(175, 236);
            this.panelImageList.TabIndex = 1;
            // 
            // tvImageListView
            // 
            this.tvImageListView.AllowDrop = true;
            this.tvImageListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvImageListView.ImageIndex = 0;
            this.tvImageListView.ImageList = this.ilBitmaps;
            this.tvImageListView.Location = new System.Drawing.Point(0, 25);
            this.tvImageListView.Name = "tvImageListView";
            this.tvImageListView.SelectedImageIndex = 0;
            this.tvImageListView.Size = new System.Drawing.Size(175, 211);
            this.tvImageListView.TabIndex = 1;
            this.tvImageListView.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.tvImageListView_ItemDrag);
            this.tvImageListView.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvImageListView_NodeMouseDoubleClick);
            this.tvImageListView.GiveFeedback += new System.Windows.Forms.GiveFeedbackEventHandler(this.tvImageListView_GiveFeedback);
            // 
            // ilBitmaps
            // 
            this.ilBitmaps.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilBitmaps.ImageStream")));
            this.ilBitmaps.TransparentColor = System.Drawing.Color.Transparent;
            this.ilBitmaps.Images.SetKeyName(0, "folder.png");
            // 
            // toolStripImageList
            // 
            this.toolStripImageList.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnImgListOpen});
            this.toolStripImageList.Location = new System.Drawing.Point(0, 0);
            this.toolStripImageList.Name = "toolStripImageList";
            this.toolStripImageList.Size = new System.Drawing.Size(175, 25);
            this.toolStripImageList.TabIndex = 0;
            this.toolStripImageList.Text = "toolStrip2";
            // 
            // tsBtnImgListOpen
            // 
            this.tsBtnImgListOpen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnImgListOpen.Image = ((System.Drawing.Image)(resources.GetObject("tsBtnImgListOpen.Image")));
            this.tsBtnImgListOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnImgListOpen.Name = "tsBtnImgListOpen";
            this.tsBtnImgListOpen.Size = new System.Drawing.Size(23, 22);
            this.tsBtnImgListOpen.Text = "&Open";
            this.tsBtnImgListOpen.Click += new System.EventHandler(this.tsBtnImgListOpen_Click);
            // 
            // ePaperView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(694, 551);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ePaperView";
            this.Text = "ePaperView";
            this.Load += new System.EventHandler(this.ePaperView_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbSerial.ResumeLayout(false);
            this.gbSerial.PerformLayout();
            this.gbConfiguration.ResumeLayout(false);
            this.gbConfiguration.PerformLayout();
            this.gbRotation.ResumeLayout(false);
            this.gbRotation.PerformLayout();
            this.gbStorage.ResumeLayout(false);
            this.gbStorage.PerformLayout();
            this.gbDraw.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panelImage.ResumeLayout(false);
            this.panelImage.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            this.tsImage.ResumeLayout(false);
            this.tsImage.PerformLayout();
            this.panelImageList.ResumeLayout(false);
            this.panelImageList.PerformLayout();
            this.toolStripImageList.ResumeLayout(false);
            this.toolStripImageList.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort epdPort;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox gbSerial;
        private System.Windows.Forms.Label labelStopBits;
        private System.Windows.Forms.Label labelDataBits;
        private System.Windows.Forms.Label labelBaudRate;
        private System.Windows.Forms.Label label_ComPort;
        private System.Windows.Forms.ComboBox cbStopBits;
        private System.Windows.Forms.ComboBox cbDataBits;
        private System.Windows.Forms.ComboBox cbBaudRate;
        private System.Windows.Forms.ComboBox cbPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox gbConfiguration;
        private System.Windows.Forms.Label labelFont;
        private System.Windows.Forms.ComboBox cbFont;
        private System.Windows.Forms.Label labelBackGround;
        private System.Windows.Forms.ComboBox cbBackGround;
        private System.Windows.Forms.Label labelForeGround;
        private System.Windows.Forms.ComboBox cbForeGround;
        private System.Windows.Forms.GroupBox gbRotation;
        private System.Windows.Forms.RadioButton rbPortrait;
        private System.Windows.Forms.RadioButton rbLandScape;
        private System.Windows.Forms.GroupBox gbStorage;
        private System.Windows.Forms.RadioButton rbNand;
        private System.Windows.Forms.RadioButton rbMicroSD;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox gbDraw;
        private System.Windows.Forms.ImageList ilBitmaps;
        private System.Windows.Forms.Panel panelImageList;
        private System.Windows.Forms.TreeView tvImageListView;
        private System.Windows.Forms.ToolStrip toolStripImageList;
        private System.Windows.Forms.Panel panelImage;
        private System.Windows.Forms.ToolStrip tsImage;
        private System.Windows.Forms.ToolStripButton tsBtnImgListOpen;
        private System.Windows.Forms.ToolStripButton tsBtnLine;
        private System.Windows.Forms.ToolStripButton tsBtnRect;
        private System.Windows.Forms.ToolStripButton tsBtnFilledRect;
        private System.Windows.Forms.ToolStripButton tsBtnCircle;
        private System.Windows.Forms.ToolStripButton tsBtnFilledCircle;
        private System.Windows.Forms.ToolStripButton tsBtnText;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton tsBtnOpenImage;
        private System.Windows.Forms.ToolStripButton tsBtnSaveImage;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FolderBrowserDialog fbdImageFolderSelect;
        private System.Windows.Forms.OpenFileDialog ofdImageOpen;
        private System.Windows.Forms.PictureBox pbCanvas;
    }
}