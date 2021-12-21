namespace StajProjesi
{
    partial class frmDepartments
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartments));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdepartmentID = new System.Windows.Forms.TextBox();
            this.txtdepartment = new System.Windows.Forms.TextBox();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.btninsert = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnupdate = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.DepartmentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Department = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.label1.Location = new System.Drawing.Point(1, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departman ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.label2.Location = new System.Drawing.Point(18, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Departman:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.label3.Location = new System.Drawing.Point(31, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Açıklama:";
            // 
            // txtdepartmentID
            // 
            this.txtdepartmentID.Location = new System.Drawing.Point(98, 103);
            this.txtdepartmentID.Name = "txtdepartmentID";
            this.txtdepartmentID.Size = new System.Drawing.Size(124, 20);
            this.txtdepartmentID.TabIndex = 3;
            // 
            // txtdepartment
            // 
            this.txtdepartment.Location = new System.Drawing.Point(98, 134);
            this.txtdepartment.Name = "txtdepartment";
            this.txtdepartment.Size = new System.Drawing.Size(124, 20);
            this.txtdepartment.TabIndex = 4;
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(98, 172);
            this.txtdescription.Multiline = true;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(124, 55);
            this.txtdescription.TabIndex = 5;
            // 
            // btninsert
            // 
            this.btninsert.BackColor = System.Drawing.Color.Snow;
            this.btninsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninsert.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btninsert.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.btninsert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btninsert.ImageKey = "plus.png";
            this.btninsert.ImageList = this.ımageList1;
            this.btninsert.Location = new System.Drawing.Point(250, 101);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(75, 31);
            this.btninsert.TabIndex = 6;
            this.btninsert.Text = "EKLE";
            this.btninsert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btninsert.UseVisualStyleBackColor = false;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
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
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.Snow;
            this.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdate.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnupdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.btnupdate.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnupdate.ImageKey = "211814-24.png";
            this.btnupdate.ImageList = this.ımageList1;
            this.btnupdate.Location = new System.Drawing.Point(331, 101);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(114, 31);
            this.btnupdate.TabIndex = 7;
            this.btnupdate.Text = "GÜNCELLE";
            this.btnupdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Snow;
            this.btndelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.btndelete.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btndelete.ImageKey = "bin-with-lid.png";
            this.btndelete.ImageList = this.ımageList1;
            this.btndelete.Location = new System.Drawing.Point(250, 159);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(75, 29);
            this.btndelete.TabIndex = 8;
            this.btndelete.Text = "SİL";
            this.btndelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnexit
            // 
            this.btnexit.BackColor = System.Drawing.Color.Snow;
            this.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnexit.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnexit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.btnexit.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnexit.ImageKey = "678146-24.png";
            this.btnexit.ImageList = this.ımageList1;
            this.btnexit.Location = new System.Drawing.Point(331, 159);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(114, 29);
            this.btnexit.TabIndex = 9;
            this.btnexit.Text = "ÇIKIŞ";
            this.btnexit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnexit.UseVisualStyleBackColor = false;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DepartmentID,
            this.Department,
            this.Description});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(15, 246);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(430, 134);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // DepartmentID
            // 
            this.DepartmentID.Text = "Departman ID";
            this.DepartmentID.Width = 93;
            // 
            // Department
            // 
            this.Department.Text = "Departman";
            this.Department.Width = 89;
            // 
            // Description
            // 
            this.Description.Text = "Açıklama";
            this.Description.Width = 197;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(110)))), ((int)(((byte)(130)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 74);
            this.panel1.TabIndex = 11;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(227)))), ((int)(((byte)(231)))));
            this.label12.Location = new System.Drawing.Point(135, 24);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(197, 25);
            this.label12.TabIndex = 38;
            this.label12.Text = "DEPARTMANLAR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(227)))), ((int)(((byte)(231)))));
            this.label4.Location = new System.Drawing.Point(432, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 24);
            this.label4.TabIndex = 39;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // frmDepartments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(227)))), ((int)(((byte)(231)))));
            this.ClientSize = new System.Drawing.Size(457, 427);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.txtdepartment);
            this.Controls.Add(this.txtdepartmentID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDepartments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Departmanlar";
            this.Load += new System.EventHandler(this.frmDepartments_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdepartmentID;
        private System.Windows.Forms.TextBox txtdepartment;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader DepartmentID;
        private System.Windows.Forms.ColumnHeader Department;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
    }
}