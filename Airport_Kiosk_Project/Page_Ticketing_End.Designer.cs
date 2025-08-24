namespace Airport_Kiosk_Project
{
    partial class Page_Ticketing_End
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            lblStatus = new Label();
            pbQRCode = new PictureBox();
            btn_Exit = new Button();
            ((System.ComponentModel.ISupportInitialize)pbQRCode).BeginInit();
            SuspendLayout();
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("맑은 고딕", 48F, FontStyle.Bold, GraphicsUnit.Point);
            lblStatus.Location = new Point(390, 185);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(280, 86);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "발급중...";
            // 
            // pbQRCode
            // 
            pbQRCode.Location = new Point(373, 98);
            pbQRCode.Name = "pbQRCode";
            pbQRCode.Size = new Size(280, 280);
            pbQRCode.SizeMode = PictureBoxSizeMode.Zoom;
            pbQRCode.TabIndex = 1;
            pbQRCode.TabStop = false;
            pbQRCode.Visible = false;
            // 
            // btn_Exit
            // 
            btn_Exit.BackColor = Color.White;
            btn_Exit.FlatAppearance.BorderColor = Color.SteelBlue;
            btn_Exit.FlatStyle = FlatStyle.Flat;
            btn_Exit.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Exit.ForeColor = Color.SteelBlue;
            btn_Exit.Location = new Point(31, 613);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(108, 52);
            btn_Exit.TabIndex = 35;
            btn_Exit.Text = "나가기";
            btn_Exit.UseVisualStyleBackColor = false;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // Page_Ticketing_End
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background1;
            Controls.Add(btn_Exit);
            Controls.Add(pbQRCode);
            Controls.Add(lblStatus);
            Name = "Page_Ticketing_End";
            Size = new Size(1000, 700);
            ((System.ComponentModel.ISupportInitialize)pbQRCode).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStatus;
        private PictureBox pbQRCode;
        private Button btn_Exit;
    }
}
