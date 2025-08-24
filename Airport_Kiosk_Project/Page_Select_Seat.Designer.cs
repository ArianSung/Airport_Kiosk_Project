namespace Airport_Kiosk_Project
{
    partial class Page_Select_Seat
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
            panelViewport = new Panel();
            panelCanvas = new Panel();
            pb_AirLine_Logo = new PictureBox();
            panel1 = new Panel();
            lb_Child = new Label();
            lb_Adult = new Label();
            btn_Final = new Button();
            btn_Exit = new Button();
            panelViewport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pb_AirLine_Logo).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelViewport
            // 
            panelViewport.AutoScroll = true;
            panelViewport.BackColor = Color.Gainsboro;
            panelViewport.Controls.Add(panelCanvas);
            panelViewport.Location = new Point(380, 13);
            panelViewport.Name = "panelViewport";
            panelViewport.Size = new Size(600, 590);
            panelViewport.TabIndex = 0;
            // 
            // panelCanvas
            // 
            panelCanvas.BackColor = Color.White;
            panelCanvas.Location = new Point(0, 0);
            panelCanvas.Name = "panelCanvas";
            panelCanvas.Size = new Size(583, 2100);
            panelCanvas.TabIndex = 0;
            // 
            // pb_AirLine_Logo
            // 
            pb_AirLine_Logo.BackColor = Color.Transparent;
            pb_AirLine_Logo.BackgroundImageLayout = ImageLayout.Zoom;
            pb_AirLine_Logo.Location = new Point(31, 59);
            pb_AirLine_Logo.Name = "pb_AirLine_Logo";
            pb_AirLine_Logo.Size = new Size(305, 70);
            pb_AirLine_Logo.TabIndex = 36;
            pb_AirLine_Logo.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(lb_Child);
            panel1.Controls.Add(lb_Adult);
            panel1.Location = new Point(73, 162);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 172);
            panel1.TabIndex = 37;
            // 
            // lb_Child
            // 
            lb_Child.AutoSize = true;
            lb_Child.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Child.Location = new Point(12, 87);
            lb_Child.Name = "lb_Child";
            lb_Child.Size = new Size(22, 30);
            lb_Child.TabIndex = 0;
            lb_Child.Text = "-";
            // 
            // lb_Adult
            // 
            lb_Adult.AutoSize = true;
            lb_Adult.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Adult.Location = new Point(12, 28);
            lb_Adult.Name = "lb_Adult";
            lb_Adult.Size = new Size(22, 30);
            lb_Adult.TabIndex = 0;
            lb_Adult.Text = "-";
            // 
            // btn_Final
            // 
            btn_Final.BackColor = Color.White;
            btn_Final.FlatAppearance.BorderColor = Color.SteelBlue;
            btn_Final.FlatStyle = FlatStyle.Flat;
            btn_Final.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Final.ForeColor = Color.SteelBlue;
            btn_Final.Location = new Point(796, 613);
            btn_Final.Name = "btn_Final";
            btn_Final.Size = new Size(150, 52);
            btn_Final.TabIndex = 38;
            btn_Final.Text = "다음";
            btn_Final.UseVisualStyleBackColor = false;
            btn_Final.Click += btn_Final_Click;
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
            btn_Exit.TabIndex = 39;
            btn_Exit.Text = "나가기";
            btn_Exit.UseVisualStyleBackColor = false;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // Page_Select_Seat
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background1;
            Controls.Add(btn_Exit);
            Controls.Add(btn_Final);
            Controls.Add(panel1);
            Controls.Add(pb_AirLine_Logo);
            Controls.Add(panelViewport);
            Name = "Page_Select_Seat";
            Size = new Size(1000, 700);
            panelViewport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pb_AirLine_Logo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelViewport;
        private Panel panelCanvas;
        private PictureBox pb_AirLine_Logo;
        private Panel panel1;
        private Label lb_Child;
        private Label lb_Adult;
        private Button btn_Final;
        private Button btn_Exit;
    }
}
