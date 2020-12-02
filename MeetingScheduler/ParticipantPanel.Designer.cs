namespace MeetingScheduler
{
    partial class ParticipantPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.removeBtn = new System.Windows.Forms.Button();
            this.roleBox = new System.Windows.Forms.ComboBox();
            this.nameLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel1.Controls.Add(this.removeBtn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.roleBox, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.nameLbl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(569, 30);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // removeBtn
            // 
            this.removeBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeBtn.Location = new System.Drawing.Point(502, 3);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(64, 24);
            this.removeBtn.TabIndex = 0;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            // 
            // roleBox
            // 
            this.roleBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.roleBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.roleBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.roleBox.FormattingEnabled = true;
            this.roleBox.Items.AddRange(new object[] {
            "Standard",
            "Important",
            "Guest Speaker"});
            this.roleBox.Location = new System.Drawing.Point(362, 3);
            this.roleBox.MaxDropDownItems = 3;
            this.roleBox.Name = "roleBox";
            this.roleBox.Size = new System.Drawing.Size(134, 21);
            this.roleBox.TabIndex = 1;
            this.roleBox.Text = "Standard";
            this.roleBox.SelectedIndexChanged += new System.EventHandler(this.roleBox_SelectedIndexChanged);
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameLbl.Location = new System.Drawing.Point(73, 0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(283, 30);
            this.nameLbl.TabIndex = 2;
            this.nameLbl.Text = "label1";
            this.nameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.BackgroundImage = global::MeetingScheduler.Properties.Resources.default_user_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 24);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ParticipantPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ParticipantPanel";
            this.Size = new System.Drawing.Size(569, 30);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.ComboBox roleBox;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
