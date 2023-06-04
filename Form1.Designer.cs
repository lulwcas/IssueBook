namespace IssueBook
{
    partial class IssueBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueBooks));
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            btnExit = new Button();
            btnRefresh = new Button();
            btnSearch = new Button();
            txtEnrollment = new TextBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtName = new TextBox();
            txtDep = new TextBox();
            txtSem = new TextBox();
            txtContact = new TextBox();
            txtEmail = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            btnIssueBook = new Button();
            comboBoxBooks = new ComboBox();
            panel3 = new Panel();
            label10 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(13, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(683, 125);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.Highlight;
            label1.Location = new Point(409, 50);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 1;
            label1.Text = "Emitir livros";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(189, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(307, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(btnExit);
            panel2.Controls.Add(btnRefresh);
            panel2.Controls.Add(btnSearch);
            panel2.Controls.Add(txtEnrollment);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(12, 140);
            panel2.Name = "panel2";
            panel2.Size = new Size(254, 360);
            panel2.TabIndex = 1;
            // 
            // btnExit
            // 
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.Location = new Point(146, 306);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 32);
            btnExit.TabIndex = 5;
            btnExit.Text = "Sair";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatStyle = FlatStyle.Popup;
            btnRefresh.Location = new Point(37, 306);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 32);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Atualizar";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.FlatStyle = FlatStyle.Popup;
            btnSearch.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSearch.Location = new Point(59, 224);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(134, 39);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Procurar por aluno";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtEnrollment
            // 
            txtEnrollment.Location = new Point(37, 180);
            txtEnrollment.Name = "txtEnrollment";
            txtEnrollment.Size = new Size(184, 23);
            txtEnrollment.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(22, 144);
            label2.Name = "label2";
            label2.Size = new Size(212, 17);
            label2.TabIndex = 1;
            label2.Text = "Digite o N da matrícula do aluno";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(77, 19);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(99, 91);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(16, 12);
            label3.Name = "label3";
            label3.Size = new Size(104, 17);
            label3.TabIndex = 0;
            label3.Text = "Nome do aluno";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(16, 55);
            label4.Name = "label4";
            label4.Size = new Size(43, 17);
            label4.TabIndex = 1;
            label4.Text = "Curso";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(16, 98);
            label5.Name = "label5";
            label5.Size = new Size(66, 17);
            label5.TabIndex = 2;
            label5.Text = "Trimestre";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(16, 139);
            label6.Name = "label6";
            label6.Size = new Size(116, 17);
            label6.TabIndex = 3;
            label6.Text = "Contato do aluno";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(16, 183);
            label7.Name = "label7";
            label7.Size = new Size(101, 17);
            label7.TabIndex = 4;
            label7.Text = "Email do aluno";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(16, 228);
            label8.Name = "label8";
            label8.Size = new Size(115, 17);
            label8.TabIndex = 5;
            label8.Text = "Nomes dos livros";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(16, 278);
            label9.Name = "label9";
            label9.Size = new Size(174, 17);
            label9.TabIndex = 6;
            label9.Text = "Data de emissão dos livros";
            // 
            // txtName
            // 
            txtName.Location = new Point(217, 12);
            txtName.Name = "txtName";
            txtName.Size = new Size(181, 23);
            txtName.TabIndex = 7;
            // 
            // txtDep
            // 
            txtDep.Location = new Point(217, 54);
            txtDep.Name = "txtDep";
            txtDep.Size = new Size(181, 23);
            txtDep.TabIndex = 8;
            // 
            // txtSem
            // 
            txtSem.Location = new Point(217, 98);
            txtSem.Name = "txtSem";
            txtSem.Size = new Size(181, 23);
            txtSem.TabIndex = 9;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(217, 138);
            txtContact.Name = "txtContact";
            txtContact.Size = new Size(181, 23);
            txtContact.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(217, 183);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(181, 23);
            txtEmail.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(217, 274);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(181, 23);
            dateTimePicker1.TabIndex = 13;
            // 
            // btnIssueBook
            // 
            btnIssueBook.FlatStyle = FlatStyle.Popup;
            btnIssueBook.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnIssueBook.Location = new Point(307, 307);
            btnIssueBook.Name = "btnIssueBook";
            btnIssueBook.Size = new Size(91, 31);
            btnIssueBook.TabIndex = 14;
            btnIssueBook.Text = "Emitir livro";
            btnIssueBook.UseVisualStyleBackColor = true;
            btnIssueBook.Click += btnIssueBook_Click;
            // 
            // comboBoxBooks
            // 
            comboBoxBooks.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxBooks.FormattingEnabled = true;
            comboBoxBooks.Location = new Point(217, 228);
            comboBoxBooks.Name = "comboBoxBooks";
            comboBoxBooks.Size = new Size(181, 23);
            comboBoxBooks.TabIndex = 15;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(0, 192, 192);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(comboBoxBooks);
            panel3.Controls.Add(btnIssueBook);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Controls.Add(txtEmail);
            panel3.Controls.Add(txtContact);
            panel3.Controls.Add(txtSem);
            panel3.Controls.Add(txtDep);
            panel3.Controls.Add(txtName);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(272, 140);
            panel3.Name = "panel3";
            panel3.Size = new Size(423, 360);
            panel3.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(143, 345);
            label10.Name = "label10";
            label10.Size = new Size(280, 15);
            label10.TabIndex = 16;
            label10.Text = "Máximo de 3 livros podem ser emitidos por aluno";
            // 
            // IssueBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(707, 512);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "IssueBooks";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += IssueBooks_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private TextBox txtEnrollment;
        private Label label2;
        private PictureBox pictureBox2;
        private Button btnRefresh;
        private Button btnSearch;
        private Button btnExit;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtName;
        private TextBox txtDep;
        private TextBox txtSem;
        private TextBox txtContact;
        private TextBox txtEmail;
        private DateTimePicker dateTimePicker1;
        private Button btnIssueBook;
        private ComboBox comboBoxBooks;
        private Panel panel3;
        private Label label10;
    }
}