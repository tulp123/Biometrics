namespace IcaoFaceCaptureCamera
{
    partial class MainForm
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
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRefreshList = new System.Windows.Forms.Button();
            this.cbCameras = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.fvPreview = new Neurotec.Biometrics.Gui.NFaceView();
            this.gbFaceTypes = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.icaoWarningView = new IcaoFaceCaptureCamera.IcaoWarningView();
            this.btnForce = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.nViewZoomSlider1 = new Neurotec.Gui.NViewZoomSlider();
            this.btnSaveTemplate = new System.Windows.Forms.Button();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.saveImageDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveTemplateDialog = new System.Windows.Forms.SaveFileDialog();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFront = new System.Windows.Forms.Label();
            this.fvFront = new Neurotec.Biometrics.Gui.NFaceView();
            this.lblLeftYaw = new System.Windows.Forms.Label();
            this.lblRightYaw = new System.Windows.Forms.Label();
            this.lblUpPitch = new System.Windows.Forms.Label();
            this.lblDownPitch = new System.Windows.Forms.Label();
            this.lblLeftRoll = new System.Windows.Forms.Label();
            this.lblRightRoll = new System.Windows.Forms.Label();
            this.fvLeftYaw = new Neurotec.Biometrics.Gui.NFaceView();
            this.fvRightYaw = new Neurotec.Biometrics.Gui.NFaceView();
            this.fvUpPitch = new Neurotec.Biometrics.Gui.NFaceView();
            this.fvDownPitch = new Neurotec.Biometrics.Gui.NFaceView();
            this.fvLeftRoll = new Neurotec.Biometrics.Gui.NFaceView();
            this.fvRightRoll = new Neurotec.Biometrics.Gui.NFaceView();
            this.groupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbFaceTypes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.Controls.Add(this.btnStop);
            this.groupBox.Controls.Add(this.btnStart);
            this.groupBox.Controls.Add(this.btnRefreshList);
            this.groupBox.Controls.Add(this.cbCameras);
            this.groupBox.Location = new System.Drawing.Point(15, 16);
            this.groupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox.Size = new System.Drawing.Size(1317, 105);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Cameras";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(296, 59);
            this.btnStop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(113, 29);
            this.btnStop.TabIndex = 16;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(152, 59);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(137, 29);
            this.btnStart.TabIndex = 16;
            this.btnStart.Text = "Start capturing";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStartClickAsync);
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Location = new System.Drawing.Point(8, 59);
            this.btnRefreshList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(137, 29);
            this.btnRefreshList.TabIndex = 16;
            this.btnRefreshList.Text = "Refresh list";
            this.btnRefreshList.UseVisualStyleBackColor = true;
            this.btnRefreshList.Click += new System.EventHandler(this.BtnRefreshListClick);
            // 
            // cbCameras
            // 
            this.cbCameras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbCameras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCameras.FormattingEnabled = true;
            this.cbCameras.Location = new System.Drawing.Point(8, 26);
            this.cbCameras.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbCameras.Name = "cbCameras";
            this.cbCameras.Size = new System.Drawing.Size(1301, 32);
            this.cbCameras.TabIndex = 15;
            this.cbCameras.SelectedIndexChanged += new System.EventHandler(this.cbCameras_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.19883F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.80117F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 252F));
            this.tableLayoutPanel1.Controls.Add(this.fvPreview, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gbFaceTypes, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 130);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1317, 440);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // fvPreview
            // 
            this.fvPreview.Face = null;
            this.fvPreview.FaceIds = null;
            this.fvPreview.IcaoArrowsColor = System.Drawing.Color.Red;
            this.fvPreview.Location = new System.Drawing.Point(282, 4);
            this.fvPreview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fvPreview.Name = "fvPreview";
            this.fvPreview.ShowIcaoArrows = true;
            this.fvPreview.ShowTokenImageRectangle = true;
            this.fvPreview.Size = new System.Drawing.Size(779, 432);
            this.fvPreview.TabIndex = 1;
            this.fvPreview.TokenImageRectangleColor = System.Drawing.Color.White;
            this.fvPreview.Paint += new System.Windows.Forms.PaintEventHandler(this.fvPreview_Paint);
            // 
            // gbFaceTypes
            // 
            this.gbFaceTypes.Controls.Add(this.checkedListBox1);
            this.gbFaceTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbFaceTypes.Location = new System.Drawing.Point(1067, 3);
            this.gbFaceTypes.Name = "gbFaceTypes";
            this.gbFaceTypes.Size = new System.Drawing.Size(247, 434);
            this.gbFaceTypes.TabIndex = 2;
            this.gbFaceTypes.TabStop = false;
            this.gbFaceTypes.Text = "Face Types";
            this.gbFaceTypes.Enter += new System.EventHandler(this.gbFaceTypes_Enter);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Front",
            "Left Yaw",
            "Right Yaw",
            "Up Pitch",
            "Down Pitch",
            "Left Roll",
            "Right Roll"});
            this.checkedListBox1.Location = new System.Drawing.Point(7, 24);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(235, 364);
            this.checkedListBox1.TabIndex = 1;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.icaoWarningView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 434);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ICAO Warnings";
            // 
            // icaoWarningView
            // 
            this.icaoWarningView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.icaoWarningView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icaoWarningView.IndeterminateColor = System.Drawing.Color.Orange;
            this.icaoWarningView.Location = new System.Drawing.Point(6, 24);
            this.icaoWarningView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.icaoWarningView.Name = "icaoWarningView";
            this.icaoWarningView.NoWarningColor = System.Drawing.Color.Green;
            this.icaoWarningView.Size = new System.Drawing.Size(261, 403);
            this.icaoWarningView.TabIndex = 0;
            this.icaoWarningView.WarningColor = System.Drawing.Color.Red;
            // 
            // btnForce
            // 
            this.btnForce.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnForce.Location = new System.Drawing.Point(3, 4);
            this.btnForce.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnForce.Name = "btnForce";
            this.btnForce.Size = new System.Drawing.Size(113, 29);
            this.btnForce.TabIndex = 2;
            this.btnForce.Text = "Force";
            this.btnForce.UseVisualStyleBackColor = true;
            this.btnForce.Click += new System.EventHandler(this.btnForce_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(122, 8);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(217, 29);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // nViewZoomSlider1
            // 
            this.nViewZoomSlider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nViewZoomSlider1.Location = new System.Drawing.Point(345, 4);
            this.nViewZoomSlider1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.nViewZoomSlider1.Name = "nViewZoomSlider1";
            this.nViewZoomSlider1.Size = new System.Drawing.Size(346, 29);
            this.nViewZoomSlider1.TabIndex = 4;
            this.nViewZoomSlider1.Text = "nViewZoomSlider1";
            this.nViewZoomSlider1.View = null;
            this.nViewZoomSlider1.Click += new System.EventHandler(this.nViewZoomSlider1_Click);
            // 
            // btnSaveTemplate
            // 
            this.btnSaveTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveTemplate.Location = new System.Drawing.Point(826, 4);
            this.btnSaveTemplate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveTemplate.Name = "btnSaveTemplate";
            this.btnSaveTemplate.Size = new System.Drawing.Size(133, 29);
            this.btnSaveTemplate.TabIndex = 2;
            this.btnSaveTemplate.Text = "&Save Template";
            this.btnSaveTemplate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveTemplate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveTemplate.UseVisualStyleBackColor = true;
            this.btnSaveTemplate.Click += new System.EventHandler(this.btnSaveTemplate_Click);
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveImage.Location = new System.Drawing.Point(697, 4);
            this.btnSaveImage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(123, 29);
            this.btnSaveImage.TabIndex = 2;
            this.btnSaveImage.Text = "Save &Image";
            this.btnSaveImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnForce);
            this.flowLayoutPanel1.Controls.Add(this.lblStatus);
            this.flowLayoutPanel1.Controls.Add(this.nViewZoomSlider1);
            this.flowLayoutPanel1.Controls.Add(this.btnSaveImage);
            this.flowLayoutPanel1.Controls.Add(this.btnSaveTemplate);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(15, 578);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(977, 40);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel2.Controls.Add(this.lblFront, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.fvFront, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblLeftYaw, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblRightYaw, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblUpPitch, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblDownPitch, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblLeftRoll, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblRightRoll, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.fvLeftYaw, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.fvRightYaw, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.fvUpPitch, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.fvDownPitch, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.fvLeftRoll, 5, 1);
            this.tableLayoutPanel2.Controls.Add(this.fvRightRoll, 6, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(15, 626);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.51351F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.48649F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1317, 231);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // lblFront
            // 
            this.lblFront.AutoSize = true;
            this.lblFront.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblFront.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFront.Location = new System.Drawing.Point(3, 0);
            this.lblFront.Name = "lblFront";
            this.lblFront.Size = new System.Drawing.Size(182, 31);
            this.lblFront.TabIndex = 0;
            this.lblFront.Text = "Front";
            this.lblFront.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fvFront
            // 
            this.fvFront.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fvFront.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fvFront.Face = null;
            this.fvFront.FaceIds = null;
            this.fvFront.IcaoArrowsColor = System.Drawing.Color.Red;
            this.fvFront.Location = new System.Drawing.Point(3, 35);
            this.fvFront.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fvFront.Name = "fvFront";
            this.fvFront.ShowIcaoArrows = true;
            this.fvFront.ShowTokenImageRectangle = true;
            this.fvFront.Size = new System.Drawing.Size(182, 192);
            this.fvFront.TabIndex = 1;
            this.fvFront.TokenImageRectangleColor = System.Drawing.Color.White;
            // 
            // lblLeftYaw
            // 
            this.lblLeftYaw.AutoSize = true;
            this.lblLeftYaw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLeftYaw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLeftYaw.Location = new System.Drawing.Point(191, 0);
            this.lblLeftYaw.Name = "lblLeftYaw";
            this.lblLeftYaw.Size = new System.Drawing.Size(182, 31);
            this.lblLeftYaw.TabIndex = 0;
            this.lblLeftYaw.Text = "Left Yaw";
            this.lblLeftYaw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRightYaw
            // 
            this.lblRightYaw.AutoSize = true;
            this.lblRightYaw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRightYaw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRightYaw.Location = new System.Drawing.Point(379, 0);
            this.lblRightYaw.Name = "lblRightYaw";
            this.lblRightYaw.Size = new System.Drawing.Size(182, 31);
            this.lblRightYaw.TabIndex = 0;
            this.lblRightYaw.Text = "Right Yaw";
            this.lblRightYaw.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUpPitch
            // 
            this.lblUpPitch.AutoSize = true;
            this.lblUpPitch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUpPitch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUpPitch.Location = new System.Drawing.Point(567, 0);
            this.lblUpPitch.Name = "lblUpPitch";
            this.lblUpPitch.Size = new System.Drawing.Size(182, 31);
            this.lblUpPitch.TabIndex = 0;
            this.lblUpPitch.Text = "Up Pitch";
            this.lblUpPitch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDownPitch
            // 
            this.lblDownPitch.AutoSize = true;
            this.lblDownPitch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDownPitch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDownPitch.Location = new System.Drawing.Point(755, 0);
            this.lblDownPitch.Name = "lblDownPitch";
            this.lblDownPitch.Size = new System.Drawing.Size(182, 31);
            this.lblDownPitch.TabIndex = 0;
            this.lblDownPitch.Text = "Down Pitch";
            this.lblDownPitch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLeftRoll
            // 
            this.lblLeftRoll.AutoSize = true;
            this.lblLeftRoll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLeftRoll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLeftRoll.Location = new System.Drawing.Point(943, 0);
            this.lblLeftRoll.Name = "lblLeftRoll";
            this.lblLeftRoll.Size = new System.Drawing.Size(182, 31);
            this.lblLeftRoll.TabIndex = 0;
            this.lblLeftRoll.Text = "Left Roll";
            this.lblLeftRoll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRightRoll
            // 
            this.lblRightRoll.AutoSize = true;
            this.lblRightRoll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRightRoll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblRightRoll.Location = new System.Drawing.Point(1131, 0);
            this.lblRightRoll.Name = "lblRightRoll";
            this.lblRightRoll.Size = new System.Drawing.Size(183, 31);
            this.lblRightRoll.TabIndex = 0;
            this.lblRightRoll.Text = "Right Roll";
            this.lblRightRoll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fvLeftYaw
            // 
            this.fvLeftYaw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fvLeftYaw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fvLeftYaw.Face = null;
            this.fvLeftYaw.FaceIds = null;
            this.fvLeftYaw.IcaoArrowsColor = System.Drawing.Color.Red;
            this.fvLeftYaw.Location = new System.Drawing.Point(191, 35);
            this.fvLeftYaw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fvLeftYaw.Name = "fvLeftYaw";
            this.fvLeftYaw.ShowIcaoArrows = true;
            this.fvLeftYaw.ShowTokenImageRectangle = true;
            this.fvLeftYaw.Size = new System.Drawing.Size(182, 192);
            this.fvLeftYaw.TabIndex = 1;
            this.fvLeftYaw.TokenImageRectangleColor = System.Drawing.Color.White;
            // 
            // fvRightYaw
            // 
            this.fvRightYaw.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fvRightYaw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fvRightYaw.Face = null;
            this.fvRightYaw.FaceIds = null;
            this.fvRightYaw.IcaoArrowsColor = System.Drawing.Color.Red;
            this.fvRightYaw.Location = new System.Drawing.Point(379, 35);
            this.fvRightYaw.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fvRightYaw.Name = "fvRightYaw";
            this.fvRightYaw.ShowIcaoArrows = true;
            this.fvRightYaw.ShowTokenImageRectangle = true;
            this.fvRightYaw.Size = new System.Drawing.Size(182, 192);
            this.fvRightYaw.TabIndex = 1;
            this.fvRightYaw.TokenImageRectangleColor = System.Drawing.Color.White;
            // 
            // fvUpPitch
            // 
            this.fvUpPitch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fvUpPitch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fvUpPitch.Face = null;
            this.fvUpPitch.FaceIds = null;
            this.fvUpPitch.IcaoArrowsColor = System.Drawing.Color.Red;
            this.fvUpPitch.Location = new System.Drawing.Point(567, 35);
            this.fvUpPitch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fvUpPitch.Name = "fvUpPitch";
            this.fvUpPitch.ShowIcaoArrows = true;
            this.fvUpPitch.ShowTokenImageRectangle = true;
            this.fvUpPitch.Size = new System.Drawing.Size(182, 192);
            this.fvUpPitch.TabIndex = 1;
            this.fvUpPitch.TokenImageRectangleColor = System.Drawing.Color.White;
            this.fvUpPitch.Paint += new System.Windows.Forms.PaintEventHandler(this.fvUpPitch_Paint);
            // 
            // fvDownPitch
            // 
            this.fvDownPitch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fvDownPitch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fvDownPitch.Face = null;
            this.fvDownPitch.FaceIds = null;
            this.fvDownPitch.IcaoArrowsColor = System.Drawing.Color.Red;
            this.fvDownPitch.Location = new System.Drawing.Point(755, 35);
            this.fvDownPitch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fvDownPitch.Name = "fvDownPitch";
            this.fvDownPitch.ShowIcaoArrows = true;
            this.fvDownPitch.ShowTokenImageRectangle = true;
            this.fvDownPitch.Size = new System.Drawing.Size(182, 192);
            this.fvDownPitch.TabIndex = 1;
            this.fvDownPitch.TokenImageRectangleColor = System.Drawing.Color.White;
            // 
            // fvLeftRoll
            // 
            this.fvLeftRoll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fvLeftRoll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fvLeftRoll.Face = null;
            this.fvLeftRoll.FaceIds = null;
            this.fvLeftRoll.IcaoArrowsColor = System.Drawing.Color.Red;
            this.fvLeftRoll.Location = new System.Drawing.Point(943, 35);
            this.fvLeftRoll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fvLeftRoll.Name = "fvLeftRoll";
            this.fvLeftRoll.ShowIcaoArrows = true;
            this.fvLeftRoll.ShowTokenImageRectangle = true;
            this.fvLeftRoll.Size = new System.Drawing.Size(182, 192);
            this.fvLeftRoll.TabIndex = 1;
            this.fvLeftRoll.TokenImageRectangleColor = System.Drawing.Color.White;
            // 
            // fvRightRoll
            // 
            this.fvRightRoll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fvRightRoll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fvRightRoll.Face = null;
            this.fvRightRoll.FaceIds = null;
            this.fvRightRoll.IcaoArrowsColor = System.Drawing.Color.Red;
            this.fvRightRoll.Location = new System.Drawing.Point(1131, 35);
            this.fvRightRoll.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.fvRightRoll.Name = "fvRightRoll";
            this.fvRightRoll.ShowIcaoArrows = true;
            this.fvRightRoll.ShowTokenImageRectangle = true;
            this.fvRightRoll.Size = new System.Drawing.Size(183, 192);
            this.fvRightRoll.TabIndex = 1;
            this.fvRightRoll.TokenImageRectangleColor = System.Drawing.Color.White;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 872);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Face Capture";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
            this.Load += new System.EventHandler(this.MainFormLoadAsync);
            this.groupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbFaceTypes.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRefreshList;
        private System.Windows.Forms.ComboBox cbCameras;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private IcaoWarningView icaoWarningView;
        private Neurotec.Biometrics.Gui.NFaceView fvPreview;
        private System.Windows.Forms.Button btnForce;
        private System.Windows.Forms.Label lblStatus;
        private Neurotec.Gui.NViewZoomSlider nViewZoomSlider1;
        private System.Windows.Forms.Button btnSaveTemplate;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.SaveFileDialog saveImageDialog;
        private System.Windows.Forms.SaveFileDialog saveTemplateDialog;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblFront;
        private Neurotec.Biometrics.Gui.NFaceView fvFront;
        private System.Windows.Forms.Label lblLeftYaw;
        private System.Windows.Forms.Label lblRightYaw;
        private System.Windows.Forms.Label lblUpPitch;
        private System.Windows.Forms.Label lblDownPitch;
        private System.Windows.Forms.Label lblLeftRoll;
        private System.Windows.Forms.Label lblRightRoll;
        private Neurotec.Biometrics.Gui.NFaceView fvLeftYaw;
        private Neurotec.Biometrics.Gui.NFaceView fvUpPitch;
        private Neurotec.Biometrics.Gui.NFaceView fvDownPitch;
        private Neurotec.Biometrics.Gui.NFaceView fvLeftRoll;
        private Neurotec.Biometrics.Gui.NFaceView fvRightRoll;
        private System.Windows.Forms.GroupBox gbFaceTypes;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Neurotec.Biometrics.Gui.NFaceView fvRightYaw;
    }
}

