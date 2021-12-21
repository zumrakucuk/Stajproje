namespace StajProjesi
{
    partial class ProjectMove
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectMove));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtProjectID = new System.Windows.Forms.TextBox();
            this.txtPersonnelID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameSurname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxProjectType = new System.Windows.Forms.ComboBox();
            this.dateTimePickerProjectStartDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerProjectEndDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnExit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnProjectType = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(781, 216);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // txtProjectID
            // 
            this.txtProjectID.Location = new System.Drawing.Point(93, 352);
            this.txtProjectID.Name = "txtProjectID";
            this.txtProjectID.Size = new System.Drawing.Size(140, 20);
            this.txtProjectID.TabIndex = 1;
            // 
            // txtPersonnelID
            // 
            this.txtPersonnelID.Location = new System.Drawing.Point(96, 394);
            this.txtPersonnelID.Name = "txtPersonnelID";
            this.txtPersonnelID.Size = new System.Drawing.Size(140, 20);
            this.txtPersonnelID.TabIndex = 3;
            this.txtPersonnelID.TextChanged += new System.EventHandler(this.txtPersonnelID_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.label1.Location = new System.Drawing.Point(27, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Proje ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.label3.Location = new System.Drawing.Point(4, 395);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Personel ID:";
            // 
            // txtNameSurname
            // 
            this.txtNameSurname.Location = new System.Drawing.Point(96, 433);
            this.txtNameSurname.Name = "txtNameSurname";
            this.txtNameSurname.Size = new System.Drawing.Size(140, 20);
            this.txtNameSurname.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.label4.Location = new System.Drawing.Point(12, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Adı Soyadı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.label5.Location = new System.Drawing.Point(321, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 9;
            this.label5.Text = "Proje Türleri:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.label6.Location = new System.Drawing.Point(300, 392);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "Proje Başlangıç:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.label7.Location = new System.Drawing.Point(335, 432);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Proje Bitiş:";
            // 
            // comboBoxProjectType
            // 
            this.comboBoxProjectType.FormattingEnabled = true;
            this.comboBoxProjectType.Location = new System.Drawing.Point(418, 351);
            this.comboBoxProjectType.Name = "comboBoxProjectType";
            this.comboBoxProjectType.Size = new System.Drawing.Size(140, 21);
            this.comboBoxProjectType.TabIndex = 12;
            // 
            // dateTimePickerProjectStartDate
            // 
            this.dateTimePickerProjectStartDate.Location = new System.Drawing.Point(419, 391);
            this.dateTimePickerProjectStartDate.Name = "dateTimePickerProjectStartDate";
            this.dateTimePickerProjectStartDate.Size = new System.Drawing.Size(139, 20);
            this.dateTimePickerProjectStartDate.TabIndex = 13;
            // 
            // dateTimePickerProjectEndDate
            // 
            this.dateTimePickerProjectEndDate.Location = new System.Drawing.Point(419, 430);
            this.dateTimePickerProjectEndDate.Name = "dateTimePickerProjectEndDate";
            this.dateTimePickerProjectEndDate.Size = new System.Drawing.Size(139, 20);
            this.dateTimePickerProjectEndDate.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.label8.Location = new System.Drawing.Point(596, 354);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 15);
            this.label8.TabIndex = 15;
            this.label8.Text = "Açıklama:";
            // 
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(599, 390);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(167, 60);
            this.Description.TabIndex = 16;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Snow;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.ImageIndex = 4;
            this.btnAdd.ImageList = this.ımageList1;
            this.btnAdd.Location = new System.Drawing.Point(383, 491);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 44);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "EKLE";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "678146-24.png");
            this.ımageList1.Images.SetKeyName(1, "211814-24.png");
            this.ımageList1.Images.SetKeyName(2, "4781812-24.png");
            this.ımageList1.Images.SetKeyName(3, "226562-24.png");
            this.ımageList1.Images.SetKeyName(4, "plus.png");
            this.ımageList1.Images.SetKeyName(5, "bin-with-lid.png");
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Snow;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.ImageIndex = 0;
            this.btnExit.ImageList = this.ımageList1;
            this.btnExit.Location = new System.Drawing.Point(702, 491);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 44);
            this.btnExit.TabIndex = 23;
            this.btnExit.Text = "ÇIKIŞ";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Snow;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.ImageIndex = 5;
            this.btnDelete.ImageList = this.ımageList1;
            this.btnDelete.Location = new System.Drawing.Point(614, 491);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 44);
            this.btnDelete.TabIndex = 22;
            this.btnDelete.Text = "SİL";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.Snow;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.ImageIndex = 1;
            this.btnUpdate.ImageList = this.ımageList1;
            this.btnUpdate.Location = new System.Drawing.Point(481, 491);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 44);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "GÜNCELLE";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnProjectType
            // 
            this.btnProjectType.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.btnProjectType.BackColor = System.Drawing.Color.Snow;
            this.btnProjectType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjectType.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProjectType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.btnProjectType.Location = new System.Drawing.Point(246, 491);
            this.btnProjectType.Name = "btnProjectType";
            this.btnProjectType.Size = new System.Drawing.Size(113, 44);
            this.btnProjectType.TabIndex = 20;
            this.btnProjectType.Text = "PROJE TÜRLERİ";
            this.btnProjectType.UseVisualStyleBackColor = false;
            this.btnProjectType.Click += new System.EventHandler(this.btnProjectType_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 74);
            this.panel1.TabIndex = 25;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(227)))), ((int)(((byte)(231)))));
            this.label9.Location = new System.Drawing.Point(775, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 24);
            this.label9.TabIndex = 26;
            this.label9.Text = "X";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(227)))), ((int)(((byte)(231)))));
            this.label12.Location = new System.Drawing.Point(289, 25);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(201, 25);
            this.label12.TabIndex = 36;
            this.label12.Text = "PROJE BİLGİLERİ";
            // 
            // ProjectMove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(227)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(800, 560);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnProjectType);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTimePickerProjectEndDate);
            this.Controls.Add(this.dateTimePickerProjectStartDate);
            this.Controls.Add(this.comboBoxProjectType);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNameSurname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPersonnelID);
            this.Controls.Add(this.txtProjectID);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProjectMove";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proje Bilgileri";
            this.Load += new System.EventHandler(this.ProjectMove_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtProjectID;
        private System.Windows.Forms.TextBox txtPersonnelID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameSurname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxProjectType;
        private System.Windows.Forms.DateTimePicker dateTimePickerProjectStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerProjectEndDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnProjectType;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
    }
}