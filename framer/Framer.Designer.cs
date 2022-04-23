namespace framer
{
    partial class Framer
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFile = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPNG = new System.Windows.Forms.Button();
            this.btnJPG = new System.Windows.Forms.Button();
            this.btnBMP = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(522, 301);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(516, 219);
            this.panel1.TabIndex = 0;
            // 
            // btnFile
            // 
            this.btnFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFile.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFile.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnFile.Location = new System.Drawing.Point(64, 38);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(390, 63);
            this.btnFile.TabIndex = 0;
            this.btnFile.Text = "Select File";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnPNG);
            this.panel2.Controls.Add(this.btnJPG);
            this.panel2.Controls.Add(this.btnBMP);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 228);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(516, 70);
            this.panel2.TabIndex = 1;
            // 
            // btnPNG
            // 
            this.btnPNG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPNG.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPNG.Enabled = false;
            this.btnPNG.FlatAppearance.BorderSize = 0;
            this.btnPNG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPNG.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPNG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPNG.Location = new System.Drawing.Point(344, 0);
            this.btnPNG.Name = "btnPNG";
            this.btnPNG.Size = new System.Drawing.Size(172, 70);
            this.btnPNG.TabIndex = 0;
            this.btnPNG.Text = "PNG";
            this.btnPNG.UseVisualStyleBackColor = true;
            // 
            // btnJPG
            // 
            this.btnJPG.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJPG.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnJPG.Enabled = false;
            this.btnJPG.FlatAppearance.BorderSize = 0;
            this.btnJPG.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJPG.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnJPG.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnJPG.Location = new System.Drawing.Point(172, 0);
            this.btnJPG.Name = "btnJPG";
            this.btnJPG.Size = new System.Drawing.Size(172, 70);
            this.btnJPG.TabIndex = 0;
            this.btnJPG.Text = "JPG";
            this.btnJPG.UseVisualStyleBackColor = true;
            // 
            // btnBMP
            // 
            this.btnBMP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.btnBMP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBMP.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBMP.Enabled = false;
            this.btnBMP.FlatAppearance.BorderSize = 0;
            this.btnBMP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBMP.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBMP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBMP.Location = new System.Drawing.Point(0, 0);
            this.btnBMP.Name = "btnBMP";
            this.btnBMP.Size = new System.Drawing.Size(172, 70);
            this.btnBMP.TabIndex = 0;
            this.btnBMP.Text = "BMP";
            this.btnBMP.UseVisualStyleBackColor = false;
            // 
            // ofd
            // 
            this.ofd.DefaultExt = "mp4";
            this.ofd.FileName = "ofd";
            this.ofd.Multiselect = true;
            this.ofd.Title = "select a video file..";
            // 
            // Framer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(522, 301);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(538, 340);
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(538, 340);
            this.Name = "Framer";
            this.Opacity = 0.95D;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Framer";
            this.Load += new System.EventHandler(this.Framer_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Button btnPNG;
        private Button btnJPG;
        private Button btnBMP;
        private Button btnFile;
        private OpenFileDialog ofd;
    }
}