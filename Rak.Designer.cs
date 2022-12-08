namespace terakhir
{
    partial class Rak
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deletebutton3 = new System.Windows.Forms.Button();
            this.updatebutton2 = new System.Windows.Forms.Button();
            this.insertbutton1 = new System.Windows.Forms.Button();
            this.tglkeluartextBox3 = new System.Windows.Forms.TextBox();
            this.tglmasuktextBox2 = new System.Windows.Forms.TextBox();
            this.noraktextBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gvrak = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvrak)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(236)))), ((int)(((byte)(230)))));
            this.panel1.Controls.Add(this.linkLabel1);
            this.panel1.Location = new System.Drawing.Point(-2, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 53);
            this.panel1.TabIndex = 3;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Sienna;
            this.linkLabel1.Location = new System.Drawing.Point(879, 13);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(61, 25);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Home";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deletebutton3);
            this.groupBox1.Controls.Add(this.updatebutton2);
            this.groupBox1.Controls.Add(this.insertbutton1);
            this.groupBox1.Controls.Add(this.tglkeluartextBox3);
            this.groupBox1.Controls.Add(this.tglmasuktextBox2);
            this.groupBox1.Controls.Add(this.noraktextBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Sylfaen", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.Linen;
            this.groupBox1.Location = new System.Drawing.Point(28, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 479);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "RAK";
            // 
            // deletebutton3
            // 
            this.deletebutton3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.deletebutton3.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deletebutton3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.deletebutton3.Location = new System.Drawing.Point(163, 413);
            this.deletebutton3.Name = "deletebutton3";
            this.deletebutton3.Size = new System.Drawing.Size(114, 46);
            this.deletebutton3.TabIndex = 9;
            this.deletebutton3.Text = "DELETE";
            this.deletebutton3.UseVisualStyleBackColor = false;
            this.deletebutton3.Click += new System.EventHandler(this.deletebutton3_Click);
            // 
            // updatebutton2
            // 
            this.updatebutton2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.updatebutton2.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.updatebutton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updatebutton2.Location = new System.Drawing.Point(304, 347);
            this.updatebutton2.Name = "updatebutton2";
            this.updatebutton2.Size = new System.Drawing.Size(128, 46);
            this.updatebutton2.TabIndex = 8;
            this.updatebutton2.Text = "UPDATE";
            this.updatebutton2.UseVisualStyleBackColor = false;
            this.updatebutton2.Click += new System.EventHandler(this.updatebutton2_Click);
            // 
            // insertbutton1
            // 
            this.insertbutton1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.insertbutton1.Font = new System.Drawing.Font("Sylfaen", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.insertbutton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.insertbutton1.Location = new System.Drawing.Point(25, 347);
            this.insertbutton1.Name = "insertbutton1";
            this.insertbutton1.Size = new System.Drawing.Size(114, 46);
            this.insertbutton1.TabIndex = 3;
            this.insertbutton1.Text = "INSERT";
            this.insertbutton1.UseVisualStyleBackColor = false;
            this.insertbutton1.Click += new System.EventHandler(this.insertbutton1_Click);
            // 
            // tglkeluartextBox3
            // 
            this.tglkeluartextBox3.Font = new System.Drawing.Font("Sylfaen", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tglkeluartextBox3.Location = new System.Drawing.Point(209, 175);
            this.tglkeluartextBox3.Name = "tglkeluartextBox3";
            this.tglkeluartextBox3.Size = new System.Drawing.Size(150, 36);
            this.tglkeluartextBox3.TabIndex = 7;
            // 
            // tglmasuktextBox2
            // 
            this.tglmasuktextBox2.Font = new System.Drawing.Font("Sylfaen", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tglmasuktextBox2.Location = new System.Drawing.Point(209, 115);
            this.tglmasuktextBox2.Name = "tglmasuktextBox2";
            this.tglmasuktextBox2.Size = new System.Drawing.Size(150, 36);
            this.tglmasuktextBox2.TabIndex = 6;
            // 
            // noraktextBox1
            // 
            this.noraktextBox1.Font = new System.Drawing.Font("Sylfaen", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.noraktextBox1.Location = new System.Drawing.Point(209, 52);
            this.noraktextBox1.Name = "noraktextBox1";
            this.noraktextBox1.Size = new System.Drawing.Size(150, 36);
            this.noraktextBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sylfaen", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(25, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 28);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tanggal Keluar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sylfaen", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(25, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tanggal Masuk";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sylfaen", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(25, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nomor Rak";
            // 
            // gvrak
            // 
            this.gvrak.AllowUserToAddRows = false;
            this.gvrak.AllowUserToDeleteRows = false;
            this.gvrak.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(236)))), ((int)(((byte)(230)))));
            this.gvrak.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvrak.Location = new System.Drawing.Point(500, 95);
            this.gvrak.Name = "gvrak";
            this.gvrak.ReadOnly = true;
            this.gvrak.RowHeadersWidth = 62;
            this.gvrak.RowTemplate.Height = 33;
            this.gvrak.Size = new System.Drawing.Size(438, 225);
            this.gvrak.TabIndex = 4;
            this.gvrak.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Rak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(121)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(967, 580);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gvrak);
            this.Name = "Rak";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvrak)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private LinkLabel linkLabel1;
        private GroupBox groupBox1;
        private Button deletebutton3;
        private Button updatebutton2;
        private Button insertbutton1;
        private TextBox tglkeluartextBox3;
        private TextBox tglmasuktextBox2;
        private TextBox noraktextBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView gvrak;
    }
}