
namespace Car_Management
{
    partial class _718
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_718));
            this.p718 = new System.Windows.Forms.PictureBox();
            this.lblMake = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataFormatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializationJSON = new System.Windows.Forms.ToolStripMenuItem();
            this.Jsondeserialization = new System.Windows.Forms.ToolStripMenuItem();
            this.binaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serializationBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializationBinary = new System.Windows.Forms.ToolStripMenuItem();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.p718)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // p718
            // 
            this.p718.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p718.BackgroundImage")));
            this.p718.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p718.Location = new System.Drawing.Point(23, 276);
            this.p718.Name = "p718";
            this.p718.Size = new System.Drawing.Size(1064, 663);
            this.p718.TabIndex = 0;
            this.p718.TabStop = false;
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMake.Location = new System.Drawing.Point(1357, 292);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(118, 44);
            this.lblMake.TabIndex = 1;
            this.lblMake.Text = "make";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataFormatToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2169, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataFormatToolStripMenuItem
            // 
            this.dataFormatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLToolStripMenuItem,
            this.jSONToolStripMenuItem,
            this.binaryToolStripMenuItem});
            this.dataFormatToolStripMenuItem.Name = "dataFormatToolStripMenuItem";
            this.dataFormatToolStripMenuItem.Size = new System.Drawing.Size(106, 24);
            this.dataFormatToolStripMenuItem.Text = "Data Format";
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializationToolStripMenuItem,
            this.deserializationToolStripMenuItem});
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.xMLToolStripMenuItem.Text = "XML";
            // 
            // serializationToolStripMenuItem
            // 
            this.serializationToolStripMenuItem.Name = "serializationToolStripMenuItem";
            this.serializationToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.serializationToolStripMenuItem.Text = "Serialization";
            this.serializationToolStripMenuItem.Click += new System.EventHandler(this.serializationToolStripMenuItem_Click);
            // 
            // deserializationToolStripMenuItem
            // 
            this.deserializationToolStripMenuItem.Name = "deserializationToolStripMenuItem";
            this.deserializationToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.deserializationToolStripMenuItem.Text = "Deserialization";
            this.deserializationToolStripMenuItem.Click += new System.EventHandler(this.deserializationToolStripMenuItem_Click);
            // 
            // jSONToolStripMenuItem
            // 
            this.jSONToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializationJSON,
            this.Jsondeserialization});
            this.jSONToolStripMenuItem.Name = "jSONToolStripMenuItem";
            this.jSONToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.jSONToolStripMenuItem.Text = "JSON";
            // 
            // serializationJSON
            // 
            this.serializationJSON.Name = "serializationJSON";
            this.serializationJSON.Size = new System.Drawing.Size(224, 26);
            this.serializationJSON.Text = "Serialization";
            this.serializationJSON.Click += new System.EventHandler(this.serializationJSON_Click);
            // 
            // Jsondeserialization
            // 
            this.Jsondeserialization.Name = "Jsondeserialization";
            this.Jsondeserialization.Size = new System.Drawing.Size(224, 26);
            this.Jsondeserialization.Text = "Deserialization";
            this.Jsondeserialization.Click += new System.EventHandler(this.Jsondeserialization_Click);
            // 
            // binaryToolStripMenuItem
            // 
            this.binaryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializationBinary,
            this.deserializationBinary});
            this.binaryToolStripMenuItem.Name = "binaryToolStripMenuItem";
            this.binaryToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.binaryToolStripMenuItem.Text = "Binary";
            // 
            // serializationBinary
            // 
            this.serializationBinary.Name = "serializationBinary";
            this.serializationBinary.Size = new System.Drawing.Size(224, 26);
            this.serializationBinary.Text = "Serialization";
            this.serializationBinary.Click += new System.EventHandler(this.serializationBinary_Click);
            // 
            // deserializationBinary
            // 
            this.deserializationBinary.Name = "deserializationBinary";
            this.deserializationBinary.Size = new System.Drawing.Size(224, 26);
            this.deserializationBinary.Text = "Deserialization";
            this.deserializationBinary.Click += new System.EventHandler(this.deserializationBinary_Click);
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModel.Location = new System.Drawing.Point(1357, 516);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(130, 44);
            this.lblModel.TabIndex = 3;
            this.lblModel.Text = "model";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(1357, 778);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(108, 44);
            this.lblPrice.TabIndex = 4;
            this.lblPrice.Text = "price";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(23, 1218);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(104, 46);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // _718
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2169, 1276);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.p718);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "_718";
            this.Text = "_718";
            this.Load += new System.EventHandler(this._718_Load);
            ((System.ComponentModel.ISupportInitialize)(this.p718)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox p718;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.ToolStripMenuItem dataFormatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializationJSON;
        private System.Windows.Forms.ToolStripMenuItem Jsondeserialization;
        private System.Windows.Forms.ToolStripMenuItem binaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializationBinary;
        private System.Windows.Forms.ToolStripMenuItem deserializationBinary;
        private System.Windows.Forms.Button btnBack;
    }
}