namespace WindowsFormsApp3
{
    partial class Form
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.topPanel = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtBoxOpen = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnOpenDir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelWeek = new System.Windows.Forms.Label();
            this.labelWeekCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.labelLng = new System.Windows.Forms.Label();
            this.labelLat = new System.Windows.Forms.Label();
            this.txtBoxLng = new System.Windows.Forms.TextBox();
            this.txtBoxLat = new System.Windows.Forms.TextBox();
            this.btnMapLoad = new System.Windows.Forms.Button();
            this.fillPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listView = new System.Windows.Forms.ListView();
            this.columnHeaderNum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRegion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderImg1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderImg2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtBoxDragDrop = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelBlue = new System.Windows.Forms.Label();
            this.labelGreen = new System.Windows.Forms.Label();
            this.labelList = new System.Windows.Forms.Label();
            this.gridView = new System.Windows.Forms.DataGridView();
            this.column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.context = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelInsert = new System.Windows.Forms.Label();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.btnZoomIn = new System.Windows.Forms.Button();
            this.map = new GMap.NET.WindowsForms.GMapControl();
            this.richTxtBox = new System.Windows.Forms.RichTextBox();
            this.topPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.fillPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "enabled.png");
            this.imageList.Images.SetKeyName(1, "enabled2.png");
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.Wheat;
            this.topPanel.ColumnCount = 2;
            this.topPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.59588F));
            this.topPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.40412F));
            this.topPanel.Controls.Add(this.panel1, 0, 0);
            this.topPanel.Controls.Add(this.panel2, 1, 0);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.RowCount = 1;
            this.topPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.topPanel.Size = new System.Drawing.Size(922, 32);
            this.topPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.txtBoxOpen);
            this.panel1.Controls.Add(this.btnOpenFile);
            this.panel1.Controls.Add(this.btnOpenDir);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(460, 26);
            this.panel1.TabIndex = 0;
            // 
            // txtBoxOpen
            // 
            this.txtBoxOpen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxOpen.BackColor = System.Drawing.SystemColors.Window;
            this.txtBoxOpen.Location = new System.Drawing.Point(121, 5);
            this.txtBoxOpen.Name = "txtBoxOpen";
            this.txtBoxOpen.ReadOnly = true;
            this.txtBoxOpen.Size = new System.Drawing.Size(336, 21);
            this.txtBoxOpen.TabIndex = 0;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackColor = System.Drawing.Color.DimGray;
            this.btnOpenFile.FlatAppearance.BorderSize = 0;
            this.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFile.ForeColor = System.Drawing.Color.White;
            this.btnOpenFile.Location = new System.Drawing.Point(62, 5);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(53, 21);
            this.btnOpenFile.TabIndex = 1;
            this.btnOpenFile.Text = "파일";
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnOpenDir
            // 
            this.btnOpenDir.BackColor = System.Drawing.Color.DimGray;
            this.btnOpenDir.FlatAppearance.BorderSize = 0;
            this.btnOpenDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenDir.ForeColor = System.Drawing.Color.White;
            this.btnOpenDir.Location = new System.Drawing.Point(3, 5);
            this.btnOpenDir.Name = "btnOpenDir";
            this.btnOpenDir.Size = new System.Drawing.Size(53, 21);
            this.btnOpenDir.TabIndex = 2;
            this.btnOpenDir.Text = "폴더";
            this.btnOpenDir.UseVisualStyleBackColor = false;
            this.btnOpenDir.Click += new System.EventHandler(this.btnOpenDir_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.labelWeek);
            this.panel2.Controls.Add(this.labelWeekCount);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label);
            this.panel2.Controls.Add(this.pictureBox);
            this.panel2.Location = new System.Drawing.Point(469, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(450, 26);
            this.panel2.TabIndex = 1;
            // 
            // labelWeek
            // 
            this.labelWeek.AutoSize = true;
            this.labelWeek.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelWeek.Location = new System.Drawing.Point(88, 14);
            this.labelWeek.Name = "labelWeek";
            this.labelWeek.Size = new System.Drawing.Size(38, 12);
            this.labelWeek.TabIndex = 10;
            this.labelWeek.Text = "label3";
            // 
            // labelWeekCount
            // 
            this.labelWeekCount.AutoSize = true;
            this.labelWeekCount.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelWeekCount.Location = new System.Drawing.Point(174, 3);
            this.labelWeekCount.Name = "labelWeekCount";
            this.labelWeekCount.Size = new System.Drawing.Size(38, 12);
            this.labelWeekCount.TabIndex = 9;
            this.labelWeekCount.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(246, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "번째 되는 주입니다.";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label.Location = new System.Drawing.Point(34, 3);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(149, 12);
            this.label.TabIndex = 6;
            this.label.Text = "지금은 2015년 1월 6일부터";
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.BackgroundImage = global::WindowsFormsApp3.Properties.Resources.logo;
            this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox.Location = new System.Drawing.Point(375, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(72, 26);
            this.pictureBox.TabIndex = 5;
            this.pictureBox.TabStop = false;
            // 
            // labelLng
            // 
            this.labelLng.AutoSize = true;
            this.labelLng.Location = new System.Drawing.Point(94, 4);
            this.labelLng.Name = "labelLng";
            this.labelLng.Size = new System.Drawing.Size(29, 12);
            this.labelLng.TabIndex = 4;
            this.labelLng.Text = "위도";
            // 
            // labelLat
            // 
            this.labelLat.AutoSize = true;
            this.labelLat.Location = new System.Drawing.Point(2, 4);
            this.labelLat.Name = "labelLat";
            this.labelLat.Size = new System.Drawing.Size(29, 12);
            this.labelLat.TabIndex = 4;
            this.labelLat.Text = "경도";
            // 
            // txtBoxLng
            // 
            this.txtBoxLng.Location = new System.Drawing.Point(127, 0);
            this.txtBoxLng.Name = "txtBoxLng";
            this.txtBoxLng.Size = new System.Drawing.Size(55, 21);
            this.txtBoxLng.TabIndex = 3;
            // 
            // txtBoxLat
            // 
            this.txtBoxLat.Location = new System.Drawing.Point(33, 0);
            this.txtBoxLat.Name = "txtBoxLat";
            this.txtBoxLat.Size = new System.Drawing.Size(55, 21);
            this.txtBoxLat.TabIndex = 3;
            // 
            // btnMapLoad
            // 
            this.btnMapLoad.BackColor = System.Drawing.Color.DimGray;
            this.btnMapLoad.FlatAppearance.BorderSize = 0;
            this.btnMapLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMapLoad.ForeColor = System.Drawing.Color.White;
            this.btnMapLoad.Location = new System.Drawing.Point(200, 0);
            this.btnMapLoad.Name = "btnMapLoad";
            this.btnMapLoad.Size = new System.Drawing.Size(56, 21);
            this.btnMapLoad.TabIndex = 0;
            this.btnMapLoad.Text = "로드";
            this.btnMapLoad.UseVisualStyleBackColor = false;
            this.btnMapLoad.Click += new System.EventHandler(this.btnMapLoad_Click);
            // 
            // fillPanel
            // 
            this.fillPanel.BackColor = System.Drawing.Color.Tan;
            this.fillPanel.ColumnCount = 2;
            this.fillPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.5423F));
            this.fillPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.4577F));
            this.fillPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.fillPanel.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.fillPanel.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.fillPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fillPanel.Location = new System.Drawing.Point(0, 32);
            this.fillPanel.Name = "fillPanel";
            this.fillPanel.RowCount = 1;
            this.fillPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.fillPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.fillPanel.Size = new System.Drawing.Size(922, 463);
            this.fillPanel.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.listView, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtBoxDragDrop, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gridView, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.38384F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40.70022F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.032823F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.13786F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(460, 457);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // listView
            // 
            this.listView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNum,
            this.columnHeaderPath,
            this.columnHeaderDate,
            this.columnHeaderRegion,
            this.columnHeaderImg1,
            this.columnHeaderImg2});
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(3, 64);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(454, 179);
            this.listView.SmallImageList = this.imageList;
            this.listView.TabIndex = 1;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView_ColumnClick);
            this.listView.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listView_DrawItem);
            this.listView.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.listView_DrawSubItem);
            this.listView.SizeChanged += new System.EventHandler(this.listView_SizeChanged);
            this.listView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView_MouseClick);
            // 
            // columnHeaderNum
            // 
            this.columnHeaderNum.Tag = "8";
            this.columnHeaderNum.Text = "번호";
            this.columnHeaderNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderNum.Width = 40;
            // 
            // columnHeaderPath
            // 
            this.columnHeaderPath.Tag = "40";
            this.columnHeaderPath.Text = "경로";
            this.columnHeaderPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderPath.Width = 200;
            // 
            // columnHeaderDate
            // 
            this.columnHeaderDate.Tag = "26";
            this.columnHeaderDate.Text = "유효기간";
            this.columnHeaderDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderDate.Width = 120;
            // 
            // columnHeaderRegion
            // 
            this.columnHeaderRegion.Tag = "16";
            this.columnHeaderRegion.Text = "유효지역";
            this.columnHeaderRegion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderRegion.Width = 90;
            // 
            // columnHeaderImg1
            // 
            this.columnHeaderImg1.Tag = "5";
            this.columnHeaderImg1.Text = "";
            this.columnHeaderImg1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderImg1.Width = 25;
            // 
            // columnHeaderImg2
            // 
            this.columnHeaderImg2.Tag = "5";
            this.columnHeaderImg2.Text = "";
            this.columnHeaderImg2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderImg2.Width = 25;
            // 
            // txtBoxDragDrop
            // 
            this.txtBoxDragDrop.AllowDrop = true;
            this.txtBoxDragDrop.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxDragDrop.BackColor = System.Drawing.Color.White;
            this.txtBoxDragDrop.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxDragDrop.ForeColor = System.Drawing.Color.Gray;
            this.txtBoxDragDrop.Location = new System.Drawing.Point(3, 3);
            this.txtBoxDragDrop.MaxLength = 5;
            this.txtBoxDragDrop.Multiline = true;
            this.txtBoxDragDrop.Name = "txtBoxDragDrop";
            this.txtBoxDragDrop.ReadOnly = true;
            this.txtBoxDragDrop.Size = new System.Drawing.Size(454, 55);
            this.txtBoxDragDrop.TabIndex = 0;
            this.txtBoxDragDrop.TabStop = false;
            this.txtBoxDragDrop.Text = "Drag & Drop";
            this.txtBoxDragDrop.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxDragDrop.DragDrop += new System.Windows.Forms.DragEventHandler(this.dragDrop);
            this.txtBoxDragDrop.DragEnter += new System.Windows.Forms.DragEventHandler(this.dragEnter);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.Controls.Add(this.labelBlue);
            this.panel4.Controls.Add(this.labelGreen);
            this.panel4.Controls.Add(this.labelList);
            this.panel4.Location = new System.Drawing.Point(3, 249);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(454, 16);
            this.panel4.TabIndex = 3;
            // 
            // labelBlue
            // 
            this.labelBlue.AutoSize = true;
            this.labelBlue.ForeColor = System.Drawing.Color.Blue;
            this.labelBlue.Location = new System.Drawing.Point(195, 0);
            this.labelBlue.Name = "labelBlue";
            this.labelBlue.Size = new System.Drawing.Size(17, 12);
            this.labelBlue.TabIndex = 1;
            this.labelBlue.Text = "●";
            // 
            // labelGreen
            // 
            this.labelGreen.AutoSize = true;
            this.labelGreen.ForeColor = System.Drawing.Color.Green;
            this.labelGreen.Location = new System.Drawing.Point(16, 0);
            this.labelGreen.Name = "labelGreen";
            this.labelGreen.Size = new System.Drawing.Size(17, 12);
            this.labelGreen.TabIndex = 1;
            this.labelGreen.Text = "●";
            // 
            // labelList
            // 
            this.labelList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelList.AutoSize = true;
            this.labelList.Location = new System.Drawing.Point(0, 0);
            this.labelList.Name = "labelList";
            this.labelList.Size = new System.Drawing.Size(555, 12);
            this.labelList.TabIndex = 0;
            this.labelList.Text = "※       : 현재 시간에 사용 가능한 인증서,         : 경도/위도 칸에 입력한 좌표에서 사용 가능한 인증서";
            // 
            // gridView
            // 
            this.gridView.AllowUserToAddRows = false;
            this.gridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridView.BackgroundColor = System.Drawing.Color.White;
            this.gridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column,
            this.context});
            this.gridView.Location = new System.Drawing.Point(3, 271);
            this.gridView.Name = "gridView";
            this.gridView.RowHeadersVisible = false;
            this.gridView.RowTemplate.Height = 23;
            this.gridView.Size = new System.Drawing.Size(454, 183);
            this.gridView.TabIndex = 4;
            // 
            // column
            // 
            this.column.HeaderText = "항목";
            this.column.Name = "column";
            this.column.ReadOnly = true;
            this.column.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.column.Width = 150;
            // 
            // context
            // 
            this.context.HeaderText = "내용";
            this.context.Name = "context";
            this.context.ReadOnly = true;
            this.context.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.context.Width = 300;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.richTxtBox, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(469, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.73934F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.26066F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(450, 457);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.labelInsert);
            this.panel3.Controls.Add(this.btnZoomOut);
            this.panel3.Controls.Add(this.labelLng);
            this.panel3.Controls.Add(this.btnZoomIn);
            this.panel3.Controls.Add(this.labelLat);
            this.panel3.Controls.Add(this.map);
            this.panel3.Controls.Add(this.txtBoxLng);
            this.panel3.Controls.Add(this.txtBoxLat);
            this.panel3.Controls.Add(this.btnMapLoad);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(444, 244);
            this.panel3.TabIndex = 2;
            // 
            // labelInsert
            // 
            this.labelInsert.AutoSize = true;
            this.labelInsert.Location = new System.Drawing.Point(260, 7);
            this.labelInsert.Name = "labelInsert";
            this.labelInsert.Size = new System.Drawing.Size(201, 12);
            this.labelInsert.TabIndex = 5;
            this.labelInsert.Text = "※도 단위의 소수점으로 입력하세요.";
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnZoomOut.BackColor = System.Drawing.Color.White;
            this.btnZoomOut.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomOut.Location = new System.Drawing.Point(3, 223);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(23, 18);
            this.btnZoomOut.TabIndex = 1;
            this.btnZoomOut.Text = "-";
            this.btnZoomOut.UseVisualStyleBackColor = false;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnZoomIn.BackColor = System.Drawing.Color.White;
            this.btnZoomIn.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnZoomIn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnZoomIn.Location = new System.Drawing.Point(3, 202);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(23, 18);
            this.btnZoomIn.TabIndex = 1;
            this.btnZoomIn.Text = "+";
            this.btnZoomIn.UseVisualStyleBackColor = false;
            this.btnZoomIn.Click += new System.EventHandler(this.btnZoomIn_Click);
            // 
            // map
            // 
            this.map.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.map.Bearing = 0F;
            this.map.CanDragMap = true;
            this.map.EmptyTileColor = System.Drawing.Color.Navy;
            this.map.GrayScaleMode = false;
            this.map.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.map.LevelsKeepInMemory = 5;
            this.map.Location = new System.Drawing.Point(0, 22);
            this.map.MarkersEnabled = true;
            this.map.MaxZoom = 2;
            this.map.MinZoom = 2;
            this.map.MouseWheelZoomEnabled = true;
            this.map.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.map.Name = "map";
            this.map.NegativeMode = false;
            this.map.PolygonsEnabled = true;
            this.map.RetryLoadTile = 0;
            this.map.RoutesEnabled = true;
            this.map.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.map.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.map.ShowTileGridLines = false;
            this.map.Size = new System.Drawing.Size(444, 222);
            this.map.TabIndex = 0;
            this.map.Zoom = 0D;
            this.map.Load += new System.EventHandler(this.map_Load);
            // 
            // richTxtBox
            // 
            this.richTxtBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTxtBox.Location = new System.Drawing.Point(3, 253);
            this.richTxtBox.Name = "richTxtBox";
            this.richTxtBox.Size = new System.Drawing.Size(444, 201);
            this.richTxtBox.TabIndex = 3;
            this.richTxtBox.Text = "";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(922, 495);
            this.Controls.Add(this.fillPanel);
            this.Controls.Add(this.topPanel);
            this.MinimumSize = new System.Drawing.Size(920, 470);
            this.Name = "Form";
            this.Text = "Form";
            this.Load += new System.EventHandler(this.Form_Load);
            this.topPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.fillPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.TableLayoutPanel topPanel;
        private System.Windows.Forms.TableLayoutPanel fillPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtBoxOpen;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnOpenDir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnMapLoad;
        private System.Windows.Forms.TextBox txtBoxLng;
        private System.Windows.Forms.TextBox txtBoxLat;
        private System.Windows.Forms.Label labelLng;
        private System.Windows.Forms.Label labelLat;
        private GMap.NET.WindowsForms.GMapControl map;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.ColumnHeader columnHeaderNum;
        private System.Windows.Forms.ColumnHeader columnHeaderPath;
        private System.Windows.Forms.ColumnHeader columnHeaderDate;
        private System.Windows.Forms.ColumnHeader columnHeaderRegion;
        private System.Windows.Forms.TextBox txtBoxDragDrop;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.Button btnZoomIn;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelWeek;
        private System.Windows.Forms.Label labelWeekCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ColumnHeader columnHeaderImg1;
        private System.Windows.Forms.ColumnHeader columnHeaderImg2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label labelList;
        private System.Windows.Forms.Label labelInsert;
        private System.Windows.Forms.RichTextBox richTxtBox;
        private System.Windows.Forms.DataGridView gridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn column;
        private System.Windows.Forms.DataGridViewTextBoxColumn context;
        private System.Windows.Forms.Label labelBlue;
        private System.Windows.Forms.Label labelGreen;
    }
}

