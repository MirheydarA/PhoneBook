namespace PhoneBook
{
    partial class AddForm
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
            grbSavePerson = new GroupBox();
            btnSave = new Button();
            txtMail = new TextBox();
            label4 = new Label();
            txtPhone = new TextBox();
            label3 = new Label();
            txtLastName = new TextBox();
            label2 = new Label();
            txtFirstName = new TextBox();
            label1 = new Label();
            grbSavePerson.SuspendLayout();
            SuspendLayout();
            // 
            // grbSavePerson
            // 
            grbSavePerson.Controls.Add(btnSave);
            grbSavePerson.Controls.Add(txtMail);
            grbSavePerson.Controls.Add(label4);
            grbSavePerson.Controls.Add(txtPhone);
            grbSavePerson.Controls.Add(label3);
            grbSavePerson.Controls.Add(txtLastName);
            grbSavePerson.Controls.Add(label2);
            grbSavePerson.Controls.Add(txtFirstName);
            grbSavePerson.Controls.Add(label1);
            grbSavePerson.Font = new Font("Segoe UI", 15F);
            grbSavePerson.Location = new Point(26, 101);
            grbSavePerson.Margin = new Padding(3, 4, 3, 4);
            grbSavePerson.Name = "grbSavePerson";
            grbSavePerson.Padding = new Padding(3, 4, 3, 4);
            grbSavePerson.Size = new Size(667, 419);
            grbSavePerson.TabIndex = 0;
            grbSavePerson.TabStop = false;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(166, 305);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(475, 79);
            btnSave.TabIndex = 4;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(166, 252);
            txtMail.Margin = new Padding(3, 4, 3, 4);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(475, 41);
            txtMail.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 256);
            label4.Name = "label4";
            label4.Size = new Size(62, 35);
            label4.TabIndex = 0;
            label4.Text = "Mail";
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(166, 199);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(475, 41);
            txtPhone.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 203);
            label3.Name = "label3";
            label3.Size = new Size(95, 35);
            label3.TabIndex = 0;
            label3.Text = "Telefon";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(166, 145);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(475, 41);
            txtLastName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 149);
            label2.Name = "label2";
            label2.Size = new Size(89, 35);
            label2.TabIndex = 0;
            label2.Text = "Soyadı";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(166, 92);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(475, 41);
            txtFirstName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 96);
            label1.Name = "label1";
            label1.Size = new Size(59, 35);
            label1.TabIndex = 0;
            label1.Text = "Adı ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 551);
            Controls.Add(grbSavePerson);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Padding = new Padding(23, 80, 23, 27);
            Text = "Kullanıcı Ekleme Formu";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            grbSavePerson.ResumeLayout(false);
            grbSavePerson.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grbSavePerson;
        private Label label1;
        private TextBox txtFirstName;
        private TextBox txtMail;
        private Label label4;
        private TextBox txtPhone;
        private Label label3;
        private TextBox txtLastName;
        private Label label2;
        private Button btnSave;
    }
}
