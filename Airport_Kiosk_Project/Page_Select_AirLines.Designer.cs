namespace Airport_Kiosk_Project
{
    partial class Page_Select_AirLines
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
            btn_ANA = new Button();
            btn_TWAY = new Button();
            btn_ASIANA = new Button();
            btn_KORAIR = new Button();
            btn_EMIRATES = new Button();
            btn_JEJU = new Button();
            lb_Airline = new Label();
            shadowPanel_ANA = new Panel();
            shadowPanel_ASIANA = new Panel();
            shadowPanel_KORAIR = new Panel();
            shadowPanel_JEJU = new Panel();
            shadowPanel_TWAY = new Panel();
            shadowPanel_EMIRATES = new Panel();
            btn_Jp = new Button();
            btn_Cn = new Button();
            btn_Eng = new Button();
            btn_Kor = new Button();
            SuspendLayout();
            // 
            // btn_ANA
            // 
            btn_ANA.BackColor = Color.Transparent;
            btn_ANA.BackgroundImage = Properties.Resources.ANA;
            btn_ANA.BackgroundImageLayout = ImageLayout.Zoom;
            btn_ANA.FlatAppearance.BorderSize = 0;
            btn_ANA.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_ANA.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_ANA.FlatStyle = FlatStyle.Flat;
            btn_ANA.Location = new Point(510, 457);
            btn_ANA.Name = "btn_ANA";
            btn_ANA.Size = new Size(210, 90);
            btn_ANA.TabIndex = 21;
            btn_ANA.UseVisualStyleBackColor = false;
            btn_ANA.Click += btn_ANA_Click;
            btn_ANA.MouseEnter += btn_ANA_MouseEnter_1;
            btn_ANA.MouseLeave += btn_ANA_MouseLeave_1;
            // 
            // btn_TWAY
            // 
            btn_TWAY.BackColor = Color.Transparent;
            btn_TWAY.BackgroundImage = Properties.Resources.Tway;
            btn_TWAY.BackgroundImageLayout = ImageLayout.Zoom;
            btn_TWAY.FlatAppearance.BorderSize = 0;
            btn_TWAY.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_TWAY.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_TWAY.FlatStyle = FlatStyle.Flat;
            btn_TWAY.Location = new Point(510, 341);
            btn_TWAY.Name = "btn_TWAY";
            btn_TWAY.Size = new Size(210, 90);
            btn_TWAY.TabIndex = 22;
            btn_TWAY.UseVisualStyleBackColor = false;
            btn_TWAY.Click += btn_TWAY_Click;
            btn_TWAY.MouseEnter += btn_TWAY_MouseEnter;
            btn_TWAY.MouseLeave += btn_TWAY_MouseLeave;
            // 
            // btn_ASIANA
            // 
            btn_ASIANA.BackColor = Color.Transparent;
            btn_ASIANA.BackgroundImage = Properties.Resources.ASIANA;
            btn_ASIANA.BackgroundImageLayout = ImageLayout.Zoom;
            btn_ASIANA.FlatAppearance.BorderSize = 0;
            btn_ASIANA.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_ASIANA.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_ASIANA.FlatStyle = FlatStyle.Flat;
            btn_ASIANA.ForeColor = SystemColors.ControlLightLight;
            btn_ASIANA.Location = new Point(280, 228);
            btn_ASIANA.Name = "btn_ASIANA";
            btn_ASIANA.Size = new Size(210, 90);
            btn_ASIANA.TabIndex = 23;
            btn_ASIANA.UseVisualStyleBackColor = false;
            btn_ASIANA.Click += btn_ASIANA_Click;
            btn_ASIANA.MouseEnter += bt_ASIANA_MouseEnter;
            btn_ASIANA.MouseLeave += bt_ASIANA_MouseLeave;
            // 
            // btn_KORAIR
            // 
            btn_KORAIR.BackColor = Color.Transparent;
            btn_KORAIR.BackgroundImage = Properties.Resources.KORAIR;
            btn_KORAIR.BackgroundImageLayout = ImageLayout.Zoom;
            btn_KORAIR.FlatAppearance.BorderSize = 0;
            btn_KORAIR.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_KORAIR.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_KORAIR.FlatStyle = FlatStyle.Flat;
            btn_KORAIR.Location = new Point(510, 228);
            btn_KORAIR.Name = "btn_KORAIR";
            btn_KORAIR.Size = new Size(210, 90);
            btn_KORAIR.TabIndex = 24;
            btn_KORAIR.UseVisualStyleBackColor = false;
            btn_KORAIR.Click += btn_KORAIR_Click;
            btn_KORAIR.MouseEnter += btn_KORAIR_MouseEnter;
            btn_KORAIR.MouseLeave += btn_KORAIR_MouseLeave;
            // 
            // btn_EMIRATES
            // 
            btn_EMIRATES.BackColor = Color.Transparent;
            btn_EMIRATES.BackgroundImage = Properties.Resources.EMIRATES;
            btn_EMIRATES.BackgroundImageLayout = ImageLayout.Zoom;
            btn_EMIRATES.FlatAppearance.BorderSize = 0;
            btn_EMIRATES.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_EMIRATES.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_EMIRATES.FlatStyle = FlatStyle.Flat;
            btn_EMIRATES.Location = new Point(280, 457);
            btn_EMIRATES.Name = "btn_EMIRATES";
            btn_EMIRATES.Size = new Size(210, 90);
            btn_EMIRATES.TabIndex = 25;
            btn_EMIRATES.UseVisualStyleBackColor = false;
            btn_EMIRATES.Click += btn_EMIRATES_Click;
            btn_EMIRATES.MouseEnter += btn_EMIRATES_MouseEnter;
            btn_EMIRATES.MouseLeave += btn_EMIRATES_MouseLeave;
            // 
            // btn_JEJU
            // 
            btn_JEJU.BackColor = Color.Transparent;
            btn_JEJU.BackgroundImage = Properties.Resources.JEJU;
            btn_JEJU.BackgroundImageLayout = ImageLayout.Zoom;
            btn_JEJU.FlatAppearance.BorderSize = 0;
            btn_JEJU.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btn_JEJU.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_JEJU.FlatStyle = FlatStyle.Flat;
            btn_JEJU.Location = new Point(280, 341);
            btn_JEJU.Name = "btn_JEJU";
            btn_JEJU.Size = new Size(210, 90);
            btn_JEJU.TabIndex = 26;
            btn_JEJU.UseVisualStyleBackColor = false;
            btn_JEJU.Click += btn_JEJU_Click;
            btn_JEJU.MouseEnter += btn_JEJU_MouseEnter;
            btn_JEJU.MouseLeave += btn_JEJU_MouseLeave;
            // 
            // lb_Airline
            // 
            lb_Airline.AutoSize = true;
            lb_Airline.BackColor = Color.White;
            lb_Airline.Font = new Font("맑은 고딕", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Airline.Location = new Point(347, 120);
            lb_Airline.Name = "lb_Airline";
            lb_Airline.Size = new Size(305, 37);
            lb_Airline.TabIndex = 20;
            lb_Airline.Text = "항공사를 선택해 주세요";
            // 
            // shadowPanel_ANA
            // 
            shadowPanel_ANA.BackColor = Color.SteelBlue;
            shadowPanel_ANA.ForeColor = Color.Transparent;
            shadowPanel_ANA.Location = new Point(512, 459);
            shadowPanel_ANA.Name = "shadowPanel_ANA";
            shadowPanel_ANA.Size = new Size(210, 90);
            shadowPanel_ANA.TabIndex = 27;
            shadowPanel_ANA.Visible = false;
            // 
            // shadowPanel_ASIANA
            // 
            shadowPanel_ASIANA.BackColor = Color.Silver;
            shadowPanel_ASIANA.ForeColor = Color.Transparent;
            shadowPanel_ASIANA.Location = new Point(282, 230);
            shadowPanel_ASIANA.Name = "shadowPanel_ASIANA";
            shadowPanel_ASIANA.Size = new Size(210, 90);
            shadowPanel_ASIANA.TabIndex = 27;
            shadowPanel_ASIANA.Visible = false;
            // 
            // shadowPanel_KORAIR
            // 
            shadowPanel_KORAIR.BackColor = Color.Silver;
            shadowPanel_KORAIR.ForeColor = Color.Transparent;
            shadowPanel_KORAIR.Location = new Point(512, 230);
            shadowPanel_KORAIR.Name = "shadowPanel_KORAIR";
            shadowPanel_KORAIR.Size = new Size(210, 90);
            shadowPanel_KORAIR.TabIndex = 27;
            shadowPanel_KORAIR.Visible = false;
            // 
            // shadowPanel_JEJU
            // 
            shadowPanel_JEJU.BackColor = Color.Silver;
            shadowPanel_JEJU.ForeColor = Color.Transparent;
            shadowPanel_JEJU.Location = new Point(282, 343);
            shadowPanel_JEJU.Name = "shadowPanel_JEJU";
            shadowPanel_JEJU.Size = new Size(210, 90);
            shadowPanel_JEJU.TabIndex = 27;
            shadowPanel_JEJU.Visible = false;
            // 
            // shadowPanel_TWAY
            // 
            shadowPanel_TWAY.BackColor = Color.Silver;
            shadowPanel_TWAY.ForeColor = Color.Transparent;
            shadowPanel_TWAY.Location = new Point(512, 343);
            shadowPanel_TWAY.Name = "shadowPanel_TWAY";
            shadowPanel_TWAY.Size = new Size(210, 90);
            shadowPanel_TWAY.TabIndex = 27;
            shadowPanel_TWAY.Visible = false;
            // 
            // shadowPanel_EMIRATES
            // 
            shadowPanel_EMIRATES.BackColor = Color.SteelBlue;
            shadowPanel_EMIRATES.ForeColor = Color.Transparent;
            shadowPanel_EMIRATES.Location = new Point(282, 459);
            shadowPanel_EMIRATES.Name = "shadowPanel_EMIRATES";
            shadowPanel_EMIRATES.Size = new Size(210, 90);
            shadowPanel_EMIRATES.TabIndex = 27;
            shadowPanel_EMIRATES.Visible = false;
            // 
            // btn_Jp
            // 
            btn_Jp.BackColor = Color.White;
            btn_Jp.FlatAppearance.BorderSize = 0;
            btn_Jp.FlatStyle = FlatStyle.Flat;
            btn_Jp.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Jp.Location = new Point(913, 18);
            btn_Jp.Name = "btn_Jp";
            btn_Jp.Size = new Size(60, 25);
            btn_Jp.TabIndex = 29;
            btn_Jp.Text = "日本語";
            btn_Jp.UseVisualStyleBackColor = false;
            btn_Jp.Click += btn_Jp_Click;
            // 
            // btn_Cn
            // 
            btn_Cn.BackColor = Color.White;
            btn_Cn.FlatAppearance.BorderSize = 0;
            btn_Cn.FlatStyle = FlatStyle.Flat;
            btn_Cn.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Cn.Location = new Point(847, 18);
            btn_Cn.Name = "btn_Cn";
            btn_Cn.Size = new Size(60, 25);
            btn_Cn.TabIndex = 30;
            btn_Cn.Text = "中文";
            btn_Cn.UseVisualStyleBackColor = false;
            btn_Cn.Click += btn_Cn_Click;
            // 
            // btn_Eng
            // 
            btn_Eng.BackColor = Color.White;
            btn_Eng.FlatAppearance.BorderSize = 0;
            btn_Eng.FlatStyle = FlatStyle.Flat;
            btn_Eng.Font = new Font("맑은 고딕", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Eng.Location = new Point(781, 18);
            btn_Eng.Name = "btn_Eng";
            btn_Eng.Size = new Size(60, 25);
            btn_Eng.TabIndex = 31;
            btn_Eng.Text = "English";
            btn_Eng.UseVisualStyleBackColor = false;
            btn_Eng.Click += btn_Eng_Click;
            // 
            // btn_Kor
            // 
            btn_Kor.BackColor = Color.White;
            btn_Kor.FlatAppearance.BorderSize = 0;
            btn_Kor.FlatStyle = FlatStyle.Flat;
            btn_Kor.Font = new Font("맑은 고딕", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Kor.Location = new Point(715, 18);
            btn_Kor.Name = "btn_Kor";
            btn_Kor.Size = new Size(60, 25);
            btn_Kor.TabIndex = 32;
            btn_Kor.Text = "한국어";
            btn_Kor.UseVisualStyleBackColor = false;
            btn_Kor.Click += btn_Kor_Click;
            // 
            // Page_Select_AirLines
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background1;
            Controls.Add(btn_Jp);
            Controls.Add(btn_Cn);
            Controls.Add(btn_Eng);
            Controls.Add(btn_Kor);
            Controls.Add(btn_ANA);
            Controls.Add(btn_TWAY);
            Controls.Add(btn_ASIANA);
            Controls.Add(btn_KORAIR);
            Controls.Add(btn_EMIRATES);
            Controls.Add(btn_JEJU);
            Controls.Add(lb_Airline);
            Controls.Add(shadowPanel_TWAY);
            Controls.Add(shadowPanel_JEJU);
            Controls.Add(shadowPanel_KORAIR);
            Controls.Add(shadowPanel_ASIANA);
            Controls.Add(shadowPanel_EMIRATES);
            Controls.Add(shadowPanel_ANA);
            Name = "Page_Select_AirLines";
            Size = new Size(1000, 700);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_ANA;
        private Button btn_TWAY;
        private Button btn_ASIANA;
        private Button btn_KORAIR;
        private Button btn_EMIRATES;
        private Button btn_JEJU;
        private Label lb_Airline;
        private Panel shadowPanel_ANA;
        private Panel shadowPanel_ASIANA;
        private Panel shadowPanel_KORAIR;
        private Panel shadowPanel_JEJU;
        private Panel shadowPanel_TWAY;
        private Panel shadowPanel_EMIRATES;
        private Button btn_Jp;
        private Button btn_Cn;
        private Button btn_Eng;
        private Button btn_Kor;
    }
}
