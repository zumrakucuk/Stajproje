namespace StajProjesi
{
    partial class HomePage
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
            this.btnDepartments = new System.Windows.Forms.Button();
            this.btnPersonnelAdd = new System.Windows.Forms.Button();
            this.PersonnelList = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDepartments
            // 
            this.btnDepartments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.btnDepartments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDepartments.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDepartments.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnDepartments.Location = new System.Drawing.Point(12, 134);
            this.btnDepartments.Name = "btnDepartments";
            this.btnDepartments.Size = new System.Drawing.Size(144, 71);
            this.btnDepartments.TabIndex = 0;
            this.btnDepartments.Text = "DEPARTMANLAR";
            this.btnDepartments.UseVisualStyleBackColor = false;
            this.btnDepartments.Click += new System.EventHandler(this.btnDepartments_Click);
            // 
            // btnPersonnelAdd
            // 
            this.btnPersonnelAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.btnPersonnelAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersonnelAdd.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPersonnelAdd.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnPersonnelAdd.Location = new System.Drawing.Point(162, 134);
            this.btnPersonnelAdd.Name = "btnPersonnelAdd";
            this.btnPersonnelAdd.Size = new System.Drawing.Size(144, 71);
            this.btnPersonnelAdd.TabIndex = 1;
            this.btnPersonnelAdd.Text = "PERSONEL EKLE";
            this.btnPersonnelAdd.UseVisualStyleBackColor = false;
            this.btnPersonnelAdd.Click += new System.EventHandler(this.btnPersonnelAdd_Click);
            // 
            // PersonnelList
            // 
            this.PersonnelList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.PersonnelList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PersonnelList.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PersonnelList.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.PersonnelList.Location = new System.Drawing.Point(312, 134);
            this.PersonnelList.Name = "PersonnelList";
            this.PersonnelList.Size = new System.Drawing.Size(144, 71);
            this.PersonnelList.TabIndex = 2;
            this.PersonnelList.Text = "PERSONEL LİSTELE";
            this.PersonnelList.UseVisualStyleBackColor = false;
            this.PersonnelList.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button1.Location = new System.Drawing.Point(162, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 71);
            this.button1.TabIndex = 3;
            this.button1.Text = "PROJE HAREKET LİSTELE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.button2.Location = new System.Drawing.Point(12, 232);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 71);
            this.button2.TabIndex = 4;
            this.button2.Text = "İZİN HAREKET LİSTELE";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(485, 100);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(227)))), ((int)(((byte)(231)))));
            this.label1.Location = new System.Drawing.Point(51, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "PERSONEL PROJE İZİN İŞLEMLERİ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(227)))), ((int)(((byte)(231)))));
            this.label2.Location = new System.Drawing.Point(457, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(227)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(485, 328);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PersonnelList);
            this.Controls.Add(this.btnPersonnelAdd);
            this.Controls.Add(this.btnDepartments);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anasayfa";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDepartments;
        private System.Windows.Forms.Button btnPersonnelAdd;
        private System.Windows.Forms.Button PersonnelList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

