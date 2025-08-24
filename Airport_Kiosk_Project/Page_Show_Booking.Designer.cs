namespace Airport_Kiosk_Project
{
    partial class Page_Show_Booking
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
            btn_Check_Ticket = new Button();
            btn_Exit = new Button();
            pb_AirLine_Logo = new PictureBox();
            lb_Booking_Num = new Label();
            lb_Name = new Label();
            lb_PeopleData = new Label();
            panel1 = new Panel();
            lbData_Name = new Label();
            lb_Test = new Label();
            lbData_BookingNum = new Label();
            ((System.ComponentModel.ISupportInitialize)pb_AirLine_Logo).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_Check_Ticket
            // 
            btn_Check_Ticket.BackColor = Color.White;
            btn_Check_Ticket.FlatAppearance.BorderColor = Color.SteelBlue;
            btn_Check_Ticket.FlatStyle = FlatStyle.Flat;
            btn_Check_Ticket.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Check_Ticket.ForeColor = Color.SteelBlue;
            btn_Check_Ticket.Location = new Point(796, 613);
            btn_Check_Ticket.Name = "btn_Check_Ticket";
            btn_Check_Ticket.Size = new Size(150, 52);
            btn_Check_Ticket.TabIndex = 33;
            btn_Check_Ticket.Text = "다음";
            btn_Check_Ticket.UseVisualStyleBackColor = false;
            btn_Check_Ticket.Click += btn_Check_Ticket_Click;
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
            btn_Exit.TabIndex = 34;
            btn_Exit.Text = "나가기";
            btn_Exit.UseVisualStyleBackColor = false;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // pb_AirLine_Logo
            // 
            pb_AirLine_Logo.BackColor = Color.Transparent;
            pb_AirLine_Logo.BackgroundImageLayout = ImageLayout.Zoom;
            pb_AirLine_Logo.Location = new Point(31, 59);
            pb_AirLine_Logo.Name = "pb_AirLine_Logo";
            pb_AirLine_Logo.Size = new Size(305, 70);
            pb_AirLine_Logo.TabIndex = 35;
            pb_AirLine_Logo.TabStop = false;
            // 
            // lb_Booking_Num
            // 
            lb_Booking_Num.AutoSize = true;
            lb_Booking_Num.BackColor = Color.Transparent;
            lb_Booking_Num.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Booking_Num.Location = new Point(31, 15);
            lb_Booking_Num.Name = "lb_Booking_Num";
            lb_Booking_Num.Size = new Size(74, 21);
            lb_Booking_Num.TabIndex = 36;
            lb_Booking_Num.Text = "예약번호";
            // 
            // lb_Name
            // 
            lb_Name.AutoSize = true;
            lb_Name.BackColor = Color.Transparent;
            lb_Name.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_Name.Location = new Point(180, 15);
            lb_Name.Name = "lb_Name";
            lb_Name.Size = new Size(96, 21);
            lb_Name.TabIndex = 36;
            lb_Name.Text = "대표자 이름";
            // 
            // lb_PeopleData
            // 
            lb_PeopleData.AutoSize = true;
            lb_PeopleData.BackColor = Color.Transparent;
            lb_PeopleData.Font = new Font("맑은 고딕", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lb_PeopleData.Location = new Point(395, 15);
            lb_PeopleData.Name = "lb_PeopleData";
            lb_PeopleData.Size = new Size(74, 21);
            lb_PeopleData.TabIndex = 36;
            lb_PeopleData.Text = "승객정보";
            // 
            // panel1
            // 
            panel1.Controls.Add(lbData_Name);
            panel1.Controls.Add(lb_Test);
            panel1.Controls.Add(lbData_BookingNum);
            panel1.Controls.Add(lb_PeopleData);
            panel1.Controls.Add(lb_Booking_Num);
            panel1.Controls.Add(lb_Name);
            panel1.Location = new Point(31, 160);
            panel1.Name = "panel1";
            panel1.Size = new Size(566, 330);
            panel1.TabIndex = 37;
            // 
            // lbData_Name
            // 
            lbData_Name.AutoSize = true;
            lbData_Name.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbData_Name.Location = new Point(219, 44);
            lbData_Name.Name = "lbData_Name";
            lbData_Name.Size = new Size(50, 20);
            lbData_Name.TabIndex = 38;
            lbData_Name.Text = "label1";
            // 
            // lb_Test
            // 
            lb_Test.AutoSize = true;
            lb_Test.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_Test.Location = new Point(404, 46);
            lb_Test.Name = "lb_Test";
            lb_Test.Size = new Size(52, 20);
            lb_Test.TabIndex = 39;
            lb_Test.Text = "어른 : ";
            // 
            // lbData_BookingNum
            // 
            lbData_BookingNum.AutoSize = true;
            lbData_BookingNum.Font = new Font("맑은 고딕", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbData_BookingNum.Location = new Point(45, 46);
            lbData_BookingNum.Name = "lbData_BookingNum";
            lbData_BookingNum.Size = new Size(50, 20);
            lbData_BookingNum.TabIndex = 37;
            lbData_BookingNum.Text = "label1";
            // 
            // Page_Show_Booking
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background1;
            Controls.Add(pb_AirLine_Logo);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Check_Ticket);
            Controls.Add(panel1);
            Name = "Page_Show_Booking";
            Size = new Size(1000, 700);
            ((System.ComponentModel.ISupportInitialize)pb_AirLine_Logo).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Check_Ticket;
        private Button btn_Exit;
        private PictureBox pb_AirLine_Logo;
        private Label lb_Booking_Num;
        private Label lb_Name;
        private Label lb_PeopleData;
        private Panel panel1;
        private Label lbData_Name;
        private Label lbData_BookingNum;
        private Label lb_Test;
    }
}
