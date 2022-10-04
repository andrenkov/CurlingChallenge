namespace CurlingChallengeUI
{
    partial class fMain
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
            this.pnlView = new System.Windows.Forms.Panel();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.lbxResult = new System.Windows.Forms.ListBox();
            this.btClear = new System.Windows.Forms.Button();
            this.lbStatus = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.edDiskRadius = new System.Windows.Forms.NumericUpDown();
            this.edNumDisks = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btPlay = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.pnlControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edDiskRadius)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.edNumDisks)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlView
            // 
            this.pnlView.AutoScroll = true;
            this.pnlView.AutoSize = true;
            this.pnlView.BackColor = System.Drawing.SystemColors.Info;
            this.pnlView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlView.Location = new System.Drawing.Point(0, 0);
            this.pnlView.Name = "pnlView";
            this.pnlView.Size = new System.Drawing.Size(984, 545);
            this.pnlView.TabIndex = 6;
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.lbxResult);
            this.pnlControls.Controls.Add(this.btClear);
            this.pnlControls.Controls.Add(this.lbStatus);
            this.pnlControls.Controls.Add(this.label3);
            this.pnlControls.Controls.Add(this.edDiskRadius);
            this.pnlControls.Controls.Add(this.edNumDisks);
            this.pnlControls.Controls.Add(this.label2);
            this.pnlControls.Controls.Add(this.label1);
            this.pnlControls.Controls.Add(this.btPlay);
            this.pnlControls.Controls.Add(this.btClose);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Size = new System.Drawing.Size(279, 545);
            this.pnlControls.TabIndex = 7;
            // 
            // lbxResult
            // 
            this.lbxResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbxResult.FormattingEnabled = true;
            this.lbxResult.ItemHeight = 15;
            this.lbxResult.Location = new System.Drawing.Point(0, 181);
            this.lbxResult.Name = "lbxResult";
            this.lbxResult.ScrollAlwaysVisible = true;
            this.lbxResult.Size = new System.Drawing.Size(279, 364);
            this.lbxResult.TabIndex = 15;
            this.lbxResult.TabStop = false;
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(187, 118);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 3;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(63, 97);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(16, 15);
            this.lbStatus.TabIndex = 13;
            this.lbStatus.Text = "...";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Status: ";
            // 
            // edDiskRadius
            // 
            this.edDiskRadius.Location = new System.Drawing.Point(142, 48);
            this.edDiskRadius.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.edDiskRadius.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edDiskRadius.Name = "edDiskRadius";
            this.edDiskRadius.Size = new System.Drawing.Size(120, 23);
            this.edDiskRadius.TabIndex = 1;
            this.edDiskRadius.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // edNumDisks
            // 
            this.edNumDisks.Location = new System.Drawing.Point(142, 19);
            this.edNumDisks.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.edNumDisks.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.edNumDisks.Name = "edNumDisks";
            this.edNumDisks.Size = new System.Drawing.Size(120, 23);
            this.edNumDisks.TabIndex = 0;
            this.edNumDisks.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Disk radius";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Number of disks";
            // 
            // btPlay
            // 
            this.btPlay.Enabled = false;
            this.btPlay.Location = new System.Drawing.Point(187, 89);
            this.btPlay.Name = "btPlay";
            this.btPlay.Size = new System.Drawing.Size(75, 23);
            this.btPlay.TabIndex = 2;
            this.btPlay.Text = "Play";
            this.btPlay.UseVisualStyleBackColor = true;
            this.btPlay.Click += new System.EventHandler(this.btPlay_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(187, 144);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(75, 23);
            this.btClose.TabIndex = 4;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 545);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.pnlView);
            this.Name = "fMain";
            this.Text = "Curling challenge";
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edDiskRadius)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.edNumDisks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnlView;
        private Panel pnlControls;
        private NumericUpDown edDiskRadius;
        private NumericUpDown edNumDisks;
        private Label label2;
        private Label label1;
        private Button btPlay;
        private Button btClose;
        private Label lbStatus;
        private Label label3;
        private Button btClear;
        private ListBox lbxResult;
    }
}