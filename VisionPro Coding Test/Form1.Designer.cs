namespace VisionPro_Coding_Test
{
    partial class Form_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.cogDisplay_Main_1 = new Cognex.VisionPro.Display.CogDisplay();
            this.Lab_Main_Form_Version = new System.Windows.Forms.Label();
            this.panel_Name_Bar = new System.Windows.Forms.Panel();
            this.Cmd_Main_Exit = new System.Windows.Forms.Button();
            this.Cmd_TEST_Load_1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextBox_PassWord = new System.Windows.Forms.TextBox();
            this.TextBox_Account = new System.Windows.Forms.TextBox();
            this.Label_PassWord = new System.Windows.Forms.Label();
            this.Label_Account = new System.Windows.Forms.Label();
            this.GroupBox_Connectivity = new System.Windows.Forms.GroupBox();
            this.NumericUpDown_MinimalPixelSize = new System.Windows.Forms.NumericUpDown();
            this.Label_MinimalPixelSize = new System.Windows.Forms.Label();
            this.ComboBox_ConnectivityMode = new System.Windows.Forms.ComboBox();
            this.Label_ConnectivityMode = new System.Windows.Forms.Label();
            this.GroupBox_Segmentation = new System.Windows.Forms.GroupBox();
            this.NumericUpDown_ThresholdValue = new System.Windows.Forms.NumericUpDown();
            this.Label_ThresholdValue = new System.Windows.Forms.Label();
            this.ComboBox_Polarity = new System.Windows.Forms.ComboBox();
            this.Label_Polarity = new System.Windows.Forms.Label();
            this.Label_SegmentationMode = new System.Windows.Forms.Label();
            this.ComboBox_SegmentationMode = new System.Windows.Forms.ComboBox();
            this.Cmd_Search_Area_Save = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cogDisplay_Main_1)).BeginInit();
            this.panel_Name_Bar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.GroupBox_Connectivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_MinimalPixelSize)).BeginInit();
            this.GroupBox_Segmentation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_ThresholdValue)).BeginInit();
            this.SuspendLayout();
            // 
            // cogDisplay_Main_1
            // 
            this.cogDisplay_Main_1.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogDisplay_Main_1.ColorMapLowerRoiLimit = 0D;
            this.cogDisplay_Main_1.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogDisplay_Main_1.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogDisplay_Main_1.ColorMapUpperRoiLimit = 1D;
            this.cogDisplay_Main_1.DoubleTapZoomCycleLength = 2;
            this.cogDisplay_Main_1.DoubleTapZoomSensitivity = 2.5D;
            this.cogDisplay_Main_1.Location = new System.Drawing.Point(0, 32);
            this.cogDisplay_Main_1.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogDisplay_Main_1.MouseWheelSensitivity = 1D;
            this.cogDisplay_Main_1.Name = "cogDisplay_Main_1";
            this.cogDisplay_Main_1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogDisplay_Main_1.OcxState")));
            this.cogDisplay_Main_1.Size = new System.Drawing.Size(1420, 1048);
            this.cogDisplay_Main_1.TabIndex = 106;
            // 
            // Lab_Main_Form_Version
            // 
            this.Lab_Main_Form_Version.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(121)))), ((int)(((byte)(166)))));
            this.Lab_Main_Form_Version.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.Lab_Main_Form_Version.ForeColor = System.Drawing.Color.White;
            this.Lab_Main_Form_Version.Location = new System.Drawing.Point(3, 4);
            this.Lab_Main_Form_Version.Name = "Lab_Main_Form_Version";
            this.Lab_Main_Form_Version.Size = new System.Drawing.Size(301, 26);
            this.Lab_Main_Form_Version.TabIndex = 4;
            this.Lab_Main_Form_Version.Text = "Test 20240830";
            this.Lab_Main_Form_Version.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel_Name_Bar
            // 
            this.panel_Name_Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(121)))), ((int)(((byte)(166)))));
            this.panel_Name_Bar.Controls.Add(this.Cmd_Main_Exit);
            this.panel_Name_Bar.Controls.Add(this.Cmd_TEST_Load_1);
            this.panel_Name_Bar.Controls.Add(this.label1);
            this.panel_Name_Bar.Location = new System.Drawing.Point(0, 0);
            this.panel_Name_Bar.Name = "panel_Name_Bar";
            this.panel_Name_Bar.Size = new System.Drawing.Size(1920, 30);
            this.panel_Name_Bar.TabIndex = 105;
            // 
            // Cmd_Main_Exit
            // 
            this.Cmd_Main_Exit.BackColor = System.Drawing.Color.White;
            this.Cmd_Main_Exit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.Cmd_Main_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cmd_Main_Exit.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Cmd_Main_Exit.ForeColor = System.Drawing.Color.Black;
            this.Cmd_Main_Exit.Location = new System.Drawing.Point(1737, 0);
            this.Cmd_Main_Exit.Name = "Cmd_Main_Exit";
            this.Cmd_Main_Exit.Size = new System.Drawing.Size(180, 27);
            this.Cmd_Main_Exit.TabIndex = 156;
            this.Cmd_Main_Exit.Text = "Exit";
            this.Cmd_Main_Exit.UseVisualStyleBackColor = false;
            this.Cmd_Main_Exit.Click += new System.EventHandler(this.Cmd_Main_Exit_Click);
            // 
            // Cmd_TEST_Load_1
            // 
            this.Cmd_TEST_Load_1.BackColor = System.Drawing.Color.White;
            this.Cmd_TEST_Load_1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Cmd_TEST_Load_1.ForeColor = System.Drawing.Color.Black;
            this.Cmd_TEST_Load_1.Location = new System.Drawing.Point(1426, 6);
            this.Cmd_TEST_Load_1.Name = "Cmd_TEST_Load_1";
            this.Cmd_TEST_Load_1.Size = new System.Drawing.Size(67, 24);
            this.Cmd_TEST_Load_1.TabIndex = 181;
            this.Cmd_TEST_Load_1.Text = "로드 1";
            this.Cmd_TEST_Load_1.UseVisualStyleBackColor = false;
            this.Cmd_TEST_Load_1.Click += new System.EventHandler(this.Cmd_TEST_Load_1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(121)))), ((int)(((byte)(166)))));
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 26);
            this.label1.TabIndex = 4;
            this.label1.Text = "Test 20240411";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.TextBox_PassWord);
            this.panel1.Controls.Add(this.TextBox_Account);
            this.panel1.Controls.Add(this.Label_PassWord);
            this.panel1.Controls.Add(this.Label_Account);
            this.panel1.Controls.Add(this.GroupBox_Connectivity);
            this.panel1.Controls.Add(this.GroupBox_Segmentation);
            this.panel1.Controls.Add(this.Cmd_Search_Area_Save);
            this.panel1.Controls.Add(this.label28);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(1426, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 1036);
            this.panel1.TabIndex = 107;
            // 
            // TextBox_PassWord
            // 
            this.TextBox_PassWord.Location = new System.Drawing.Point(98, 72);
            this.TextBox_PassWord.Name = "TextBox_PassWord";
            this.TextBox_PassWord.Size = new System.Drawing.Size(153, 21);
            this.TextBox_PassWord.TabIndex = 343;
            this.TextBox_PassWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_PassWord_KeyDown);
            // 
            // TextBox_Account
            // 
            this.TextBox_Account.Location = new System.Drawing.Point(87, 34);
            this.TextBox_Account.Name = "TextBox_Account";
            this.TextBox_Account.Size = new System.Drawing.Size(153, 21);
            this.TextBox_Account.TabIndex = 342;
            // 
            // Label_PassWord
            // 
            this.Label_PassWord.AutoSize = true;
            this.Label_PassWord.ForeColor = System.Drawing.Color.Blue;
            this.Label_PassWord.Location = new System.Drawing.Point(30, 75);
            this.Label_PassWord.Name = "Label_PassWord";
            this.Label_PassWord.Size = new System.Drawing.Size(62, 12);
            this.Label_PassWord.TabIndex = 341;
            this.Label_PassWord.Text = "PassWord";
            // 
            // Label_Account
            // 
            this.Label_Account.AutoSize = true;
            this.Label_Account.ForeColor = System.Drawing.Color.Blue;
            this.Label_Account.Location = new System.Drawing.Point(30, 37);
            this.Label_Account.Name = "Label_Account";
            this.Label_Account.Size = new System.Drawing.Size(51, 12);
            this.Label_Account.TabIndex = 340;
            this.Label_Account.Text = "Account";
            // 
            // GroupBox_Connectivity
            // 
            this.GroupBox_Connectivity.Controls.Add(this.NumericUpDown_MinimalPixelSize);
            this.GroupBox_Connectivity.Controls.Add(this.Label_MinimalPixelSize);
            this.GroupBox_Connectivity.Controls.Add(this.ComboBox_ConnectivityMode);
            this.GroupBox_Connectivity.Controls.Add(this.Label_ConnectivityMode);
            this.GroupBox_Connectivity.Location = new System.Drawing.Point(258, 109);
            this.GroupBox_Connectivity.Name = "GroupBox_Connectivity";
            this.GroupBox_Connectivity.Size = new System.Drawing.Size(224, 301);
            this.GroupBox_Connectivity.TabIndex = 339;
            this.GroupBox_Connectivity.TabStop = false;
            this.GroupBox_Connectivity.Text = "Connectivity";
            // 
            // NumericUpDown_MinimalPixelSize
            // 
            this.NumericUpDown_MinimalPixelSize.Location = new System.Drawing.Point(17, 126);
            this.NumericUpDown_MinimalPixelSize.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.NumericUpDown_MinimalPixelSize.Name = "NumericUpDown_MinimalPixelSize";
            this.NumericUpDown_MinimalPixelSize.Size = new System.Drawing.Size(84, 21);
            this.NumericUpDown_MinimalPixelSize.TabIndex = 342;
            this.NumericUpDown_MinimalPixelSize.ValueChanged += new System.EventHandler(this.NumericUpDown_MinimalPixelSize_ValueChanged);
            // 
            // Label_MinimalPixelSize
            // 
            this.Label_MinimalPixelSize.AutoSize = true;
            this.Label_MinimalPixelSize.ForeColor = System.Drawing.Color.Blue;
            this.Label_MinimalPixelSize.Location = new System.Drawing.Point(15, 96);
            this.Label_MinimalPixelSize.Name = "Label_MinimalPixelSize";
            this.Label_MinimalPixelSize.Size = new System.Drawing.Size(111, 12);
            this.Label_MinimalPixelSize.TabIndex = 341;
            this.Label_MinimalPixelSize.Text = "Minimal Pixel Size";
            // 
            // ComboBox_ConnectivityMode
            // 
            this.ComboBox_ConnectivityMode.FormattingEnabled = true;
            this.ComboBox_ConnectivityMode.Location = new System.Drawing.Point(17, 53);
            this.ComboBox_ConnectivityMode.Name = "ComboBox_ConnectivityMode";
            this.ComboBox_ConnectivityMode.Size = new System.Drawing.Size(168, 20);
            this.ComboBox_ConnectivityMode.TabIndex = 340;
            // 
            // Label_ConnectivityMode
            // 
            this.Label_ConnectivityMode.AutoSize = true;
            this.Label_ConnectivityMode.ForeColor = System.Drawing.Color.Blue;
            this.Label_ConnectivityMode.Location = new System.Drawing.Point(15, 26);
            this.Label_ConnectivityMode.Name = "Label_ConnectivityMode";
            this.Label_ConnectivityMode.Size = new System.Drawing.Size(110, 12);
            this.Label_ConnectivityMode.TabIndex = 340;
            this.Label_ConnectivityMode.Text = "Connectivity Mode";
            // 
            // GroupBox_Segmentation
            // 
            this.GroupBox_Segmentation.Controls.Add(this.NumericUpDown_ThresholdValue);
            this.GroupBox_Segmentation.Controls.Add(this.Label_ThresholdValue);
            this.GroupBox_Segmentation.Controls.Add(this.ComboBox_Polarity);
            this.GroupBox_Segmentation.Controls.Add(this.Label_Polarity);
            this.GroupBox_Segmentation.Controls.Add(this.Label_SegmentationMode);
            this.GroupBox_Segmentation.Controls.Add(this.ComboBox_SegmentationMode);
            this.GroupBox_Segmentation.Location = new System.Drawing.Point(19, 109);
            this.GroupBox_Segmentation.Name = "GroupBox_Segmentation";
            this.GroupBox_Segmentation.Size = new System.Drawing.Size(224, 301);
            this.GroupBox_Segmentation.TabIndex = 338;
            this.GroupBox_Segmentation.TabStop = false;
            this.GroupBox_Segmentation.Text = "Segmentation";
            // 
            // NumericUpDown_ThresholdValue
            // 
            this.NumericUpDown_ThresholdValue.Location = new System.Drawing.Point(130, 166);
            this.NumericUpDown_ThresholdValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.NumericUpDown_ThresholdValue.Name = "NumericUpDown_ThresholdValue";
            this.NumericUpDown_ThresholdValue.Size = new System.Drawing.Size(84, 21);
            this.NumericUpDown_ThresholdValue.TabIndex = 5;
            this.NumericUpDown_ThresholdValue.ValueChanged += new System.EventHandler(this.NumericUpDown_ThresholdValue_ValueChanged);
            // 
            // Label_ThresholdValue
            // 
            this.Label_ThresholdValue.AutoSize = true;
            this.Label_ThresholdValue.ForeColor = System.Drawing.Color.Blue;
            this.Label_ThresholdValue.Location = new System.Drawing.Point(29, 172);
            this.Label_ThresholdValue.Name = "Label_ThresholdValue";
            this.Label_ThresholdValue.Size = new System.Drawing.Size(94, 12);
            this.Label_ThresholdValue.TabIndex = 4;
            this.Label_ThresholdValue.Text = "ThresholdValue";
            // 
            // ComboBox_Polarity
            // 
            this.ComboBox_Polarity.FormattingEnabled = true;
            this.ComboBox_Polarity.Location = new System.Drawing.Point(31, 127);
            this.ComboBox_Polarity.Name = "ComboBox_Polarity";
            this.ComboBox_Polarity.Size = new System.Drawing.Size(168, 20);
            this.ComboBox_Polarity.TabIndex = 3;
            // 
            // Label_Polarity
            // 
            this.Label_Polarity.AutoSize = true;
            this.Label_Polarity.ForeColor = System.Drawing.Color.Blue;
            this.Label_Polarity.Location = new System.Drawing.Point(29, 96);
            this.Label_Polarity.Name = "Label_Polarity";
            this.Label_Polarity.Size = new System.Drawing.Size(47, 12);
            this.Label_Polarity.TabIndex = 2;
            this.Label_Polarity.Text = "Polarity";
            // 
            // Label_SegmentationMode
            // 
            this.Label_SegmentationMode.AutoSize = true;
            this.Label_SegmentationMode.ForeColor = System.Drawing.Color.Blue;
            this.Label_SegmentationMode.Location = new System.Drawing.Point(29, 26);
            this.Label_SegmentationMode.Name = "Label_SegmentationMode";
            this.Label_SegmentationMode.Size = new System.Drawing.Size(118, 12);
            this.Label_SegmentationMode.TabIndex = 1;
            this.Label_SegmentationMode.Text = "Segmentation Mode";
            // 
            // ComboBox_SegmentationMode
            // 
            this.ComboBox_SegmentationMode.FormattingEnabled = true;
            this.ComboBox_SegmentationMode.Location = new System.Drawing.Point(31, 53);
            this.ComboBox_SegmentationMode.Name = "ComboBox_SegmentationMode";
            this.ComboBox_SegmentationMode.Size = new System.Drawing.Size(168, 20);
            this.ComboBox_SegmentationMode.TabIndex = 0;
            // 
            // Cmd_Search_Area_Save
            // 
            this.Cmd_Search_Area_Save.BackColor = System.Drawing.Color.White;
            this.Cmd_Search_Area_Save.Font = new System.Drawing.Font("맑은 고딕", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Cmd_Search_Area_Save.ForeColor = System.Drawing.Color.Black;
            this.Cmd_Search_Area_Save.Location = new System.Drawing.Point(185, 551);
            this.Cmd_Search_Area_Save.Name = "Cmd_Search_Area_Save";
            this.Cmd_Search_Area_Save.Size = new System.Drawing.Size(125, 36);
            this.Cmd_Search_Area_Save.TabIndex = 337;
            this.Cmd_Search_Area_Save.Text = "Save";
            this.Cmd_Search_Area_Save.UseVisualStyleBackColor = false;
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(121)))), ((int)(((byte)(130)))));
            this.label28.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label28.ForeColor = System.Drawing.Color.White;
            this.label28.Location = new System.Drawing.Point(6, 1);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(482, 22);
            this.label28.TabIndex = 296;
            this.label28.Text = "Search Area";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_Name_Bar);
            this.Controls.Add(this.Lab_Main_Form_Version);
            this.Controls.Add(this.cogDisplay_Main_1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Main";
            this.Text = "Vision_Align";
            this.Load += new System.EventHandler(this.Form_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cogDisplay_Main_1)).EndInit();
            this.panel_Name_Bar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.GroupBox_Connectivity.ResumeLayout(false);
            this.GroupBox_Connectivity.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_MinimalPixelSize)).EndInit();
            this.GroupBox_Segmentation.ResumeLayout(false);
            this.GroupBox_Segmentation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDown_ThresholdValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Cognex.VisionPro.Display.CogDisplay cogDisplay_Main_1;
        public System.Windows.Forms.Label Lab_Main_Form_Version;
        private System.Windows.Forms.Panel panel_Name_Bar;
        public System.Windows.Forms.Button Cmd_Main_Exit;
        public System.Windows.Forms.Button Cmd_TEST_Load_1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button Cmd_Search_Area_Save;
        public System.Windows.Forms.Label label28;
        private System.Windows.Forms.GroupBox GroupBox_Connectivity;
        private System.Windows.Forms.GroupBox GroupBox_Segmentation;
        private System.Windows.Forms.Label Label_ThresholdValue;
        private System.Windows.Forms.ComboBox ComboBox_Polarity;
        private System.Windows.Forms.Label Label_Polarity;
        private System.Windows.Forms.Label Label_SegmentationMode;
        private System.Windows.Forms.ComboBox ComboBox_SegmentationMode;
        private System.Windows.Forms.Label Label_ConnectivityMode;
        private System.Windows.Forms.Label Label_MinimalPixelSize;
        private System.Windows.Forms.ComboBox ComboBox_ConnectivityMode;
        private System.Windows.Forms.NumericUpDown NumericUpDown_MinimalPixelSize;
        private System.Windows.Forms.NumericUpDown NumericUpDown_ThresholdValue;
        private System.Windows.Forms.TextBox TextBox_PassWord;
        private System.Windows.Forms.TextBox TextBox_Account;
        private System.Windows.Forms.Label Label_PassWord;
        private System.Windows.Forms.Label Label_Account;
    }
}

