namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbl_TenMay = new Label();
            lbl_TenCSDL = new Label();
            txt_TenMay = new TextBox();
            txt_TenCSDL = new TextBox();
            btn_KetNoi = new Button();
            btn_Thoat = new Button();
            btn_KetNoiSan = new Button();
            SuspendLayout();
            // 
            // lbl_TenMay
            // 
            lbl_TenMay.AutoSize = true;
            lbl_TenMay.Location = new Point(94, 51);
            lbl_TenMay.Name = "lbl_TenMay";
            lbl_TenMay.Size = new Size(109, 32);
            lbl_TenMay.TabIndex = 0;
            lbl_TenMay.Text = "Tên máy:";
            // 
            // lbl_TenCSDL
            // 
            lbl_TenCSDL.AutoSize = true;
            lbl_TenCSDL.Location = new Point(99, 128);
            lbl_TenCSDL.Name = "lbl_TenCSDL";
            lbl_TenCSDL.Size = new Size(120, 32);
            lbl_TenCSDL.TabIndex = 1;
            lbl_TenCSDL.Text = "Tên CSDL:";
            // 
            // txt_TenMay
            // 
            txt_TenMay.Location = new Point(303, 50);
            txt_TenMay.Name = "txt_TenMay";
            txt_TenMay.Size = new Size(433, 39);
            txt_TenMay.TabIndex = 2;
            // 
            // txt_TenCSDL
            // 
            txt_TenCSDL.Location = new Point(303, 124);
            txt_TenCSDL.Name = "txt_TenCSDL";
            txt_TenCSDL.Size = new Size(433, 39);
            txt_TenCSDL.TabIndex = 3;
            // 
            // btn_KetNoi
            // 
            btn_KetNoi.Location = new Point(303, 221);
            btn_KetNoi.Name = "btn_KetNoi";
            btn_KetNoi.Size = new Size(150, 46);
            btn_KetNoi.TabIndex = 4;
            btn_KetNoi.Text = "Kết nối";
            btn_KetNoi.UseVisualStyleBackColor = true;
            btn_KetNoi.Click += btn_KetNoi_Click;
            // 
            // btn_Thoat
            // 
            btn_Thoat.Location = new Point(586, 221);
            btn_Thoat.Name = "btn_Thoat";
            btn_Thoat.Size = new Size(150, 46);
            btn_Thoat.TabIndex = 5;
            btn_Thoat.Text = "Thoát";
            btn_Thoat.UseVisualStyleBackColor = true;
            btn_Thoat.Click += btn_Thoat_Click;
            // 
            // btn_KetNoiSan
            // 
            btn_KetNoiSan.Location = new Point(69, 221);
            btn_KetNoiSan.Name = "btn_KetNoiSan";
            btn_KetNoiSan.Size = new Size(150, 46);
            btn_KetNoiSan.TabIndex = 6;
            btn_KetNoiSan.Text = "Kết nối sẵn";
            btn_KetNoiSan.UseVisualStyleBackColor = true;
            btn_KetNoiSan.Click += btn_KetNoiSan_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 301);
            Controls.Add(btn_KetNoiSan);
            Controls.Add(btn_Thoat);
            Controls.Add(btn_KetNoi);
            Controls.Add(txt_TenCSDL);
            Controls.Add(txt_TenMay);
            Controls.Add(lbl_TenCSDL);
            Controls.Add(lbl_TenMay);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            Click += Form1_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_TenMay;
        private Label lbl_TenCSDL;
        private TextBox txt_TenMay;
        private TextBox txt_TenCSDL;
        private Button btn_KetNoi;
        private Button btn_Thoat;
        private Button btn_KetNoiSan;
    }
}