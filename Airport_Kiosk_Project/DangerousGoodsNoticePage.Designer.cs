namespace Airport_Kiosk_Project
{
    partial class DangerousGoodsNoticePage
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
            pb_Danger1 = new PictureBox();
            pb_Danger2 = new PictureBox();
            pb_Danger3 = new PictureBox();
            pb_Danger4 = new PictureBox();
            btn_Next = new Button();
            btn_Exit = new Button();
            btn_Last = new Button();
            btn_Agree = new Button();
            ((System.ComponentModel.ISupportInitialize)pb_Danger1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Danger2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Danger3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_Danger4).BeginInit();
            SuspendLayout();
            // 
            // pb_Danger1
            // 
            pb_Danger1.BackgroundImage = Properties.Resources.Danger1;
            pb_Danger1.BackgroundImageLayout = ImageLayout.Zoom;
            pb_Danger1.Location = new Point(31, 42);
            pb_Danger1.Name = "pb_Danger1";
            pb_Danger1.Size = new Size(940, 558);
            pb_Danger1.TabIndex = 0;
            pb_Danger1.TabStop = false;
            // 
            // pb_Danger2
            // 
            pb_Danger2.BackgroundImage = Properties.Resources.Danger2;
            pb_Danger2.BackgroundImageLayout = ImageLayout.Zoom;
            pb_Danger2.Location = new Point(31, 42);
            pb_Danger2.Name = "pb_Danger2";
            pb_Danger2.Size = new Size(940, 558);
            pb_Danger2.TabIndex = 0;
            pb_Danger2.TabStop = false;
            // 
            // pb_Danger3
            // 
            pb_Danger3.BackgroundImage = Properties.Resources.Danger2;
            pb_Danger3.BackgroundImageLayout = ImageLayout.Zoom;
            pb_Danger3.Image = Properties.Resources.Danger3;
            pb_Danger3.Location = new Point(31, 42);
            pb_Danger3.Name = "pb_Danger3";
            pb_Danger3.Size = new Size(940, 558);
            pb_Danger3.SizeMode = PictureBoxSizeMode.Zoom;
            pb_Danger3.TabIndex = 0;
            pb_Danger3.TabStop = false;
            // 
            // pb_Danger4
            // 
            pb_Danger4.BackgroundImage = Properties.Resources.Danger2;
            pb_Danger4.BackgroundImageLayout = ImageLayout.Zoom;
            pb_Danger4.Image = Properties.Resources.Danger4;
            pb_Danger4.Location = new Point(31, 42);
            pb_Danger4.Name = "pb_Danger4";
            pb_Danger4.Size = new Size(940, 558);
            pb_Danger4.SizeMode = PictureBoxSizeMode.Zoom;
            pb_Danger4.TabIndex = 0;
            pb_Danger4.TabStop = false;
            // 
            // btn_Next
            // 
            btn_Next.BackColor = Color.White;
            btn_Next.FlatAppearance.BorderColor = Color.SteelBlue;
            btn_Next.FlatStyle = FlatStyle.Flat;
            btn_Next.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Next.ForeColor = Color.SteelBlue;
            btn_Next.Location = new Point(779, 613);
            btn_Next.Name = "btn_Next";
            btn_Next.Size = new Size(192, 52);
            btn_Next.TabIndex = 31;
            btn_Next.Text = "다음";
            btn_Next.UseVisualStyleBackColor = false;
            btn_Next.Click += btn_Next_Click;
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
            btn_Exit.TabIndex = 31;
            btn_Exit.Text = "나가기";
            btn_Exit.UseVisualStyleBackColor = false;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // btn_Last
            // 
            btn_Last.BackColor = Color.White;
            btn_Last.FlatAppearance.BorderColor = Color.SteelBlue;
            btn_Last.FlatStyle = FlatStyle.Flat;
            btn_Last.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Last.ForeColor = Color.SteelBlue;
            btn_Last.Location = new Point(145, 613);
            btn_Last.Name = "btn_Last";
            btn_Last.Size = new Size(192, 52);
            btn_Last.TabIndex = 31;
            btn_Last.Text = "이전";
            btn_Last.UseVisualStyleBackColor = false;
            btn_Last.Click += btn_Last_Click;
            // 
            // btn_Agree
            // 
            btn_Agree.BackColor = Color.White;
            btn_Agree.FlatAppearance.BorderColor = Color.SteelBlue;
            btn_Agree.FlatStyle = FlatStyle.Flat;
            btn_Agree.Font = new Font("맑은 고딕", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Agree.ForeColor = Color.SteelBlue;
            btn_Agree.Location = new Point(779, 613);
            btn_Agree.Name = "btn_Agree";
            btn_Agree.Size = new Size(192, 52);
            btn_Agree.TabIndex = 31;
            btn_Agree.Text = "동의";
            btn_Agree.UseVisualStyleBackColor = false;
            btn_Agree.Visible = false;
            btn_Agree.Click += btn_Agree_Click;
            // 
            // DangerousGoodsNoticePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.background1;
            Controls.Add(btn_Last);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Agree);
            Controls.Add(btn_Next);
            Controls.Add(pb_Danger4);
            Controls.Add(pb_Danger3);
            Controls.Add(pb_Danger2);
            Controls.Add(pb_Danger1);
            DoubleBuffered = true;
            Name = "DangerousGoodsNoticePage";
            Size = new Size(1000, 700);
            ((System.ComponentModel.ISupportInitialize)pb_Danger1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Danger2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Danger3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_Danger4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pb_Danger1;
        private PictureBox pb_Danger2;
        private PictureBox pb_Danger3;
        private PictureBox pb_Danger4;
        private Button btn_Next;
        private Button btn_Exit;
        private Button btn_Last;
        private Button btn_Agree;
    }
}
