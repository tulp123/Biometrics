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
            this.faceView = new Neurotec.Biometrics.Gui.NFaceView();
            this.btnForce = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.nViewZoomSlider1 = new Neurotec.Gui.NViewZoomSlider();
            this.btnSaveTemplate = new System.Windows.Forms.Button();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.saveImageDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveTemplateDialog = new System.Windows.Forms.SaveFileDialog();
            this.icaoWarningView = new IcaoFaceCaptureCamera.IcaoWarningView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblFront = new System.Windows.Forms.Label();
            this.FaceViewFront = new Neurotec.Biometrics.Gui.NFaceView();
            this.groupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
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
            this.groupBox.Location = new System.Drawing.Point(13, 13);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(855, 84);
            this.groupBox.TabIndex = 0;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Cameras";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(259, 47);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(99, 23);
            this.btnStop.TabIndex = 16;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(133, 47);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(120, 23);
            this.btnStart.TabIndex = 16;
            this.btnStart.Text = "Start capturing";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.BtnStartClickAsync);
            // 
            // btnRefreshList
            // 
            this.btnRefreshList.Location = new System.Drawing.Point(7, 47);
            this.btnRefreshList.Name = "btnRefreshList";
            this.btnRefreshList.Size = new System.Drawing.Size(120, 23);
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
            this.cbCameras.Location = new System.Drawing.Point(7, 21);
            this.cbCameras.Name = "cbCameras";
            this.cbCameras.Size = new System.Drawing.Size(842, 20);
            this.cbCameras.TabIndex = 15;
            this.cbCameras.SelectedIndexChanged += new System.EventHandler(this.cbCameras_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.78363F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 73.21638F));
            this.tableLayoutPanel1.Controls.Add(this.icaoWarningView, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.faceView, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(13, 104);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(855, 352);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // faceView
            // 
            this.faceView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.faceView.Face = null;
            this.faceView.FaceIds = null;
            this.faceView.IcaoArrowsColor = System.Drawing.Color.Red;
            this.faceView.Location = new System.Drawing.Point(232, 3);
            this.faceView.Name = "faceView";
            this.faceView.ShowIcaoArrows = true;
            this.faceView.ShowTokenImageRectangle = true;
            this.faceView.Size = new System.Drawing.Size(620, 346);
            this.faceView.TabIndex = 1;
            this.faceView.TokenImageRectangleColor = System.Drawing.Color.White;
            // 
            // btnForce
            // 
            this.btnForce.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnForce.Location = new System.Drawing.Point(3, 3);
            this.btnForce.Name = "btnForce";
            this.btnForce.Size = new System.Drawing.Size(99, 23);
            this.btnForce.TabIndex = 2;
            this.btnForce.Text = "Force";
            this.btnForce.UseVisualStyleBackColor = true;
            this.btnForce.Click += new System.EventHandler(this.btnForce_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(108, 6);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(190, 23);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // nViewZoomSlider1
            // 
            this.nViewZoomSlider1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nViewZoomSlider1.Location = new System.Drawing.Point(304, 3);
            this.nViewZoomSlider1.Name = "nViewZoomSlider1";
            this.nViewZoomSlider1.Size = new System.Drawing.Size(303, 23);
            this.nViewZoomSlider1.TabIndex = 4;
            this.nViewZoomSlider1.Text = "nViewZoomSlider1";
            this.nViewZoomSlider1.View = null;
            // 
            // btnSaveTemplate
            // 
            this.btnSaveTemplate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSaveTemplate.Location = new System.Drawing.Point(727, 3);
            this.btnSaveTemplate.Name = "btnSaveTemplate";
            this.btnSaveTemplate.Size = new System.Drawing.Size(116, 23);
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
            this.btnSaveImage.Location = new System.Drawing.Point(613, 3);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(108, 23);
            this.btnSaveImage.TabIndex = 2;
            this.btnSaveImage.Text = "Save &Image";
            this.btnSaveImage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // icaoWarningView
            // 
            this.icaoWarningView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.icaoWarningView.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.icaoWarningView.IndeterminateColor = System.Drawing.Color.Orange;
            this.icaoWarningView.Location = new System.Drawing.Point(3, 3);
            this.icaoWarningView.Name = "icaoWarningView";
            this.icaoWarningView.NoWarningColor = System.Drawing.Color.Green;
            this.icaoWarningView.Size = new System.Drawing.Size(223, 346);
            this.icaoWarningView.TabIndex = 0;
            this.icaoWarningView.WarningColor = System.Drawing.Color.Red;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnForce);
            this.flowLayoutPanel1.Controls.Add(this.lblStatus);
            this.flowLayoutPanel1.Controls.Add(this.nViewZoomSlider1);
            this.flowLayoutPanel1.Controls.Add(this.btnSaveImage);
            this.flowLayoutPanel1.Controls.Add(this.btnSaveTemplate);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 462);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(855, 32);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.48515F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.51485F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 122F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 151F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 278F));
            this.tableLayoutPanel2.Controls.Add(this.lblFront, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.FaceViewFront, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(13, 501);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.51351F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.48649F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(855, 185);
            this.tableLayoutPanel2.TabIndex = 6;
            // 
            // lblFront
            // 
            this.lblFront.AutoSize = true;
            this.lblFront.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFront.Location = new System.Drawing.Point(3, 0);
            this.lblFront.Name = "lblFront";
            this.lblFront.Size = new System.Drawing.Size(150, 25);
            this.lblFront.TabIndex = 0;
            this.lblFront.Text = "Front";
            this.lblFront.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FaceViewFront
            // 
            this.FaceViewFront.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FaceViewFront.Face = null;
            this.FaceViewFront.FaceIds = null;
            this.FaceViewFront.IcaoArrowsColor = System.Drawing.Color.Red;
            this.FaceViewFront.Location = new System.Drawing.Point(3, 28);
            this.FaceViewFront.Name = "FaceViewFront";
            this.FaceViewFront.ShowIcaoArrows = true;
            this.FaceViewFront.ShowTokenImageRectangle = true;
            this.FaceViewFront.Size = new System.Drawing.Size(150, 154);
            this.FaceViewFront.TabIndex = 1;
            this.FaceViewFront.TokenImageRectangleColor = System.Drawing.Color.White;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 698);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.groupBox);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
            this.Load += new System.EventHandler(this.MainFormLoadAsync);
            this.groupBox.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
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
        private Neurotec.Biometrics.Gui.NFaceView faceView;
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
        private Neurotec.Biometrics.Gui.NFaceView FaceViewFront;
    }
}

