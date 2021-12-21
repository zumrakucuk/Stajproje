namespace StajProjesi
{
    partial class PermissionMovementList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PermissionMovementList));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPermissionType = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtPermissionMoveID = new System.Windows.Forms.TextBox();
            this.txtPersonnelID = new System.Windows.Forms.TextBox();
            this.txtNameSurname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxPermissionType = new System.Windows.Forms.ComboBox();
            this.dateTimePickerPermissionStartingDate = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerPermissionFinishDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(805, 224);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // btnPermissionType
            // 
            this.btnPermissionType.AccessibleRole = System.Windows.Forms.AccessibleRole.Dialog;
            this.btnPermissionType.BackColor = System.Drawing.Color.Snow;
            this.btnPermissionType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPermissionType.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPermissionType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.btnPermissionType.Location = new System.Drawing.Point(228, 454);
            this.btnPermissionType.Name = "btnPermissionType";
            this.btnPermissionType.Size = new System.Drawing.Size(113, 44);
            this.btnPermissionType.TabIndex = 1;
            this.btnPermissionType.Text = "İZİN TÜRLERİ";
            this.btnPermissionType.UseVisualStyleBackColor = false;
            this.btnPermissionType.Click += new System.EventHandler(this.btnPermissionType_Click);
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
            this.btnUpdate.Location = new System.Drawing.Point(463, 454);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(111, 44);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "GÜNCELLE";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "678146-24.png");
            this.ımageList1.Images.SetKeyName(1, "211814-24.png");
            this.ımageList1.Images.SetKeyName(2, "4781812-24.png");
            this.ımageList1.Images.SetKeyName(3, "226562-24.png");
            this.ımageList1.Images.SetKeyName(4, "bin-with-lid.png");
            this.ımageList1.Images.SetKeyName(5, "plus.png");
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Snow;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.ImageIndex = 4;
            this.btnDelete.ImageList = this.ımageList1;
            this.btnDelete.Location = new System.Drawing.Point(596, 454);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(64, 44);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "SİL";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
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
            this.btnExit.Location = new System.Drawing.Point(686, 454);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(85, 44);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "ÇIKIŞ";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtPermissionMoveID
            // 
            this.txtPermissionMoveID.Location = new System.Drawing.Point(113, 312);
            this.txtPermissionMoveID.Name = "txtPermissionMoveID";
            this.txtPermissionMoveID.Size = new System.Drawing.Size(151, 20);
            this.txtPermissionMoveID.TabIndex = 5;
            // 
            // txtPersonnelID
            // 
            this.txtPersonnelID.Location = new System.Drawing.Point(113, 347);
            this.txtPersonnelID.Name = "txtPersonnelID";
            this.txtPersonnelID.Size = new System.Drawing.Size(151, 20);
            this.txtPersonnelID.TabIndex = 6;
            this.txtPersonnelID.TextChanged += new System.EventHandler(this.txtPersonnelID_TextChanged);
            // 
            // txtNameSurname
            // 
            this.txtNameSurname.Location = new System.Drawing.Point(113, 382);
            this.txtNameSurname.Name = "txtNameSurname";
            this.txtNameSurname.Size = new System.Drawing.Size(151, 20);
            this.txtNameSurname.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.label1.Location = new System.Drawing.Point(5, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "İzin Hareket ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.label2.Location = new System.Drawing.Point(25, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Personel ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.label3.Location = new System.Drawing.Point(33, 385);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Adı Soyadı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.label4.Location = new System.Drawing.Point(304, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "İzin Türleri:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.label5.Location = new System.Drawing.Point(283, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "İzin Başlangıç:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.label6.Location = new System.Drawing.Point(318, 384);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "İzin Bitiş:";
            // 
            // comboBoxPermissionType
            // 
            this.comboBoxPermissionType.FormattingEnabled = true;
            this.comboBoxPermissionType.Location = new System.Drawing.Point(388, 311);
            this.comboBoxPermissionType.Name = "comboBoxPermissionType";
            this.comboBoxPermissionType.Size = new System.Drawing.Size(151, 21);
            this.comboBoxPermissionType.TabIndex = 14;
            // 
            // dateTimePickerPermissionStartingDate
            // 
            this.dateTimePickerPermissionStartingDate.Location = new System.Drawing.Point(388, 347);
            this.dateTimePickerPermissionStartingDate.Name = "dateTimePickerPermissionStartingDate";
            this.dateTimePickerPermissionStartingDate.Size = new System.Drawing.Size(150, 20);
            this.dateTimePickerPermissionStartingDate.TabIndex = 15;
            // 
            // dateTimePickerPermissionFinishDate
            // 
            this.dateTimePickerPermissionFinishDate.Location = new System.Drawing.Point(387, 382);
            this.dateTimePickerPermissionFinishDate.Name = "dateTimePickerPermissionFinishDate";
            this.dateTimePickerPermissionFinishDate.Size = new System.Drawing.Size(151, 20);
            this.dateTimePickerPermissionFinishDate.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.label7.Location = new System.Drawing.Point(575, 311);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 17;
            this.label7.Text = "Açıklama:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(578, 347);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(172, 55);
            this.txtDescription.TabIndex = 18;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Snow;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.ImageIndex = 5;
            this.btnAdd.ImageList = this.ımageList1;
            this.btnAdd.Location = new System.Drawing.Point(363, 454);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(76, 44);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "EKLE";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 74);
            this.panel1.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(227)))), ((int)(((byte)(231)))));
            this.label10.Location = new System.Drawing.Point(302, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(217, 25);
            this.label10.TabIndex = 34;
            this.label10.Text = "İZİN HAREKETLERİ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(227)))), ((int)(((byte)(231)))));
            this.label8.Location = new System.Drawing.Point(775, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 24);
            this.label8.TabIndex = 21;
            this.label8.Text = "X";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // PermissionMovementList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(227)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(800, 517);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dateTimePickerPermissionFinishDate);
            this.Controls.Add(this.dateTimePickerPermissionStartingDate);
            this.Controls.Add(this.comboBoxPermissionType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNameSurname);
            this.Controls.Add(this.txtPersonnelID);
            this.Controls.Add(this.txtPermissionMoveID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnPermissionType);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PermissionMovementList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "İzin Hareketleri";
            this.Load += new System.EventHandler(this.PermissionMovementList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPermissionType;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtPermissionMoveID;
        private System.Windows.Forms.TextBox txtPersonnelID;
        private System.Windows.Forms.TextBox txtNameSurname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxPermissionType;
        private System.Windows.Forms.DateTimePicker dateTimePickerPermissionStartingDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerPermissionFinishDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
    }
}