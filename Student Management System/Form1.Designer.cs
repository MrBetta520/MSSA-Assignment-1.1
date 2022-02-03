
namespace Student_Management_System
{
    partial class fStudentManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fStudentManagement));
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Information = new System.Windows.Forms.GroupBox();
            this.upload = new System.Windows.Forms.Button();
            this.image = new System.Windows.Forms.PictureBox();
            this.comboGrade = new System.Windows.Forms.ComboBox();
            this.comboMonth = new System.Windows.Forms.ComboBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblLName = new System.Windows.Forms.Label();
            this.lblFName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.backToMain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.Information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid
            // 
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGrid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Location = new System.Drawing.Point(816, 780);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(1088, 282);
            this.dataGrid.TabIndex = 0;
            // 
            // Information
            // 
            this.Information.BackColor = System.Drawing.Color.Transparent;
            this.Information.Controls.Add(this.upload);
            this.Information.Controls.Add(this.image);
            this.Information.Controls.Add(this.comboGrade);
            this.Information.Controls.Add(this.comboMonth);
            this.Information.Controls.Add(this.txtAddress);
            this.Information.Controls.Add(this.txtLName);
            this.Information.Controls.Add(this.txtFName);
            this.Information.Controls.Add(this.txtID);
            this.Information.Controls.Add(this.lblGrade);
            this.Information.Controls.Add(this.lblMonth);
            this.Information.Controls.Add(this.lblAddress);
            this.Information.Controls.Add(this.lblLName);
            this.Information.Controls.Add(this.lblFName);
            this.Information.Controls.Add(this.lblID);
            this.Information.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Information.Location = new System.Drawing.Point(834, 47);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(1070, 597);
            this.Information.TabIndex = 1;
            this.Information.TabStop = false;
            this.Information.Text = "Student Information";
            // 
            // upload
            // 
            this.upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upload.Location = new System.Drawing.Point(88, 377);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(123, 64);
            this.upload.TabIndex = 13;
            this.upload.Text = "Upload";
            this.upload.UseVisualStyleBackColor = true;
            this.upload.Click += new System.EventHandler(this.upload_Click);
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(51, 79);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(199, 232);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.image.TabIndex = 5;
            this.image.TabStop = false;
            // 
            // comboGrade
            // 
            this.comboGrade.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboGrade.FormattingEnabled = true;
            this.comboGrade.Location = new System.Drawing.Point(630, 523);
            this.comboGrade.Name = "comboGrade";
            this.comboGrade.Size = new System.Drawing.Size(233, 27);
            this.comboGrade.TabIndex = 12;
            // 
            // comboMonth
            // 
            this.comboMonth.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboMonth.FormattingEnabled = true;
            this.comboMonth.Location = new System.Drawing.Point(630, 430);
            this.comboMonth.Name = "comboMonth";
            this.comboMonth.Size = new System.Drawing.Size(233, 27);
            this.comboMonth.TabIndex = 2;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAddress.Location = new System.Drawing.Point(540, 340);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAddress.Size = new System.Drawing.Size(402, 33);
            this.txtAddress.TabIndex = 11;
            // 
            // txtLName
            // 
            this.txtLName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLName.Location = new System.Drawing.Point(540, 257);
            this.txtLName.Name = "txtLName";
            this.txtLName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLName.Size = new System.Drawing.Size(251, 33);
            this.txtLName.TabIndex = 10;
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(540, 162);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(251, 33);
            this.txtFName.TabIndex = 9;
            this.txtFName.TextChanged += new System.EventHandler(this.txtFName_TextChanged);
            // 
            // txtID
            // 
            this.txtID.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtID.Location = new System.Drawing.Point(540, 79);
            this.txtID.Name = "txtID";
            this.txtID.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtID.Size = new System.Drawing.Size(251, 33);
            this.txtID.TabIndex = 8;
            // 
            // lblGrade
            // 
            this.lblGrade.AutoSize = true;
            this.lblGrade.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrade.Location = new System.Drawing.Point(321, 523);
            this.lblGrade.Name = "lblGrade";
            this.lblGrade.Size = new System.Drawing.Size(95, 30);
            this.lblGrade.TabIndex = 7;
            this.lblGrade.Text = "Grade :";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.Location = new System.Drawing.Point(318, 430);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(266, 30);
            this.lblMonth.TabIndex = 6;
            this.lblMonth.Text = "Month Of Admission :";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(321, 347);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(196, 30);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Home Address :";
            // 
            // lblLName
            // 
            this.lblLName.AutoSize = true;
            this.lblLName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLName.Location = new System.Drawing.Point(321, 260);
            this.lblLName.Name = "lblLName";
            this.lblLName.Size = new System.Drawing.Size(147, 30);
            this.lblLName.TabIndex = 4;
            this.lblLName.Text = "Last Name :";
            // 
            // lblFName
            // 
            this.lblFName.AutoSize = true;
            this.lblFName.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFName.Location = new System.Drawing.Point(318, 165);
            this.lblFName.Name = "lblFName";
            this.lblFName.Size = new System.Drawing.Size(150, 30);
            this.lblFName.TabIndex = 3;
            this.lblFName.Text = "First Name :";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft JhengHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(318, 79);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(149, 30);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "Student ID :";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(1093, 692);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 64);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add Record";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1311, 692);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 64);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Record";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // backToMain
            // 
            this.backToMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToMain.Location = new System.Drawing.Point(1530, 692);
            this.backToMain.Name = "backToMain";
            this.backToMain.Size = new System.Drawing.Size(123, 64);
            this.backToMain.TabIndex = 4;
            this.backToMain.Text = "Back To Main";
            this.backToMain.UseVisualStyleBackColor = true;
            this.backToMain.Click += new System.EventHandler(this.backToMain_Click);
            // 
            // fStudentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1977, 1113);
            this.Controls.Add(this.backToMain);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.dataGrid);
            this.Name = "fStudentManagement";
            this.Text = "Student Management System";
            this.Load += new System.EventHandler(this.fStudentManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.Information.ResumeLayout(false);
            this.Information.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.GroupBox Information;
        private System.Windows.Forms.Label lblLName;
        private System.Windows.Forms.Label lblFName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.ComboBox comboGrade;
        private System.Windows.Forms.ComboBox comboMonth;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button backToMain;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Button upload;
    }
}

