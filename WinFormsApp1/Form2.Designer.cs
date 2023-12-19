namespace WinFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            btn_Add = new Button();
            btn_Delete = new Button();
            btn_Exit = new Button();
            txt_NhapMaGV = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 36);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(1080, 300);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btn_Add
            // 
            btn_Add.Location = new Point(376, 372);
            btn_Add.Name = "btn_Add";
            btn_Add.Size = new Size(150, 97);
            btn_Add.TabIndex = 1;
            btn_Add.Text = "Thêm";
            btn_Add.UseVisualStyleBackColor = true;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(655, 372);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(150, 97);
            btn_Delete.TabIndex = 2;
            btn_Delete.Text = "Xóa";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btnDelete_Click;
            // 
            // btn_Exit
            // 
            btn_Exit.Location = new Point(923, 372);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(150, 97);
            btn_Exit.TabIndex = 3;
            btn_Exit.Text = "Thoát";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // txt_NhapMaGV
            // 
            txt_NhapMaGV.Location = new Point(60, 411);
            txt_NhapMaGV.Name = "txt_NhapMaGV";
            txt_NhapMaGV.Size = new Size(200, 39);
            txt_NhapMaGV.TabIndex = 4;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1104, 603);
            Controls.Add(txt_NhapMaGV);
            Controls.Add(btn_Exit);
            Controls.Add(btn_Delete);
            Controls.Add(btn_Add);
            Controls.Add(dataGridView1);
            Name = "Form2";
            Text = "Form2";
            FormClosing += Form2_FormClosing;
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btn_Add;
        private Button btn_Delete;
        private Button btn_Exit;
        private TextBox txt_NhapMaGV;
    }
}