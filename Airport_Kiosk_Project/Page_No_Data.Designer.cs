namespace Airport_Kiosk_Project
{
    partial class Page_No_Data
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
            label1 = new Label();
            btn_Confirm = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(71, 77);
            label1.Name = "label1";
            label1.Size = new Size(258, 60);
            label1.TabIndex = 0;
            label1.Text = "입력하신 정보와 일치하는\r\n      예약이 없습니다.";
            // 
            // btn_Confirm
            // 
            btn_Confirm.FlatAppearance.BorderSize = 0;
            btn_Confirm.FlatStyle = FlatStyle.Flat;
            btn_Confirm.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Confirm.Location = new Point(134, 312);
            btn_Confirm.Name = "btn_Confirm";
            btn_Confirm.Size = new Size(130, 52);
            btn_Confirm.TabIndex = 1;
            btn_Confirm.Text = "확인";
            btn_Confirm.UseVisualStyleBackColor = true;
            btn_Confirm.Click += btn_Confirm_Click_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightBlue;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 18);
            panel1.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightBlue;
            panel2.Location = new Point(0, 432);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 18);
            panel2.TabIndex = 3;
            // 
            // Page_No_Data
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btn_Confirm);
            Controls.Add(label1);
            Name = "Page_No_Data";
            Size = new Size(400, 450);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_Confirm;
        private Panel panel1;
        private Panel panel2;
    }
}
