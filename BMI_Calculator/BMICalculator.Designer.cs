namespace BMI_Calculator
{
    partial class BMICalculator
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
            this.RadioHeadLayout = new System.Windows.Forms.TableLayoutPanel();
            this.RadImperial = new System.Windows.Forms.RadioButton();
            this.RadMetric = new System.Windows.Forms.RadioButton();
            this.labelhei = new System.Windows.Forms.Label();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.btnCalculateBMI = new System.Windows.Forms.Button();
            this.lblWeight = new System.Windows.Forms.Label();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.labelwei = new System.Windows.Forms.Label();
            this.lblBMI = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelBmi = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblScale = new System.Windows.Forms.Label();
            this.labelScale = new System.Windows.Forms.Label();
            this.pbUnder = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pbNormal = new System.Windows.Forms.PictureBox();
            this.pbOver = new System.Windows.Forms.PictureBox();
            this.pbObese = new System.Windows.Forms.PictureBox();
            this.RadioHeadLayout.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUnder)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNormal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbObese)).BeginInit();
            this.SuspendLayout();
            // 
            // RadioHeadLayout
            // 
            this.RadioHeadLayout.ColumnCount = 2;
            this.RadioHeadLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.RadioHeadLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.RadioHeadLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.RadioHeadLayout.Controls.Add(this.RadImperial, 1, 0);
            this.RadioHeadLayout.Controls.Add(this.RadMetric, 0, 0);
            this.RadioHeadLayout.Location = new System.Drawing.Point(12, 69);
            this.RadioHeadLayout.Name = "RadioHeadLayout";
            this.RadioHeadLayout.RowCount = 1;
            this.RadioHeadLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.RadioHeadLayout.Size = new System.Drawing.Size(280, 46);
            this.RadioHeadLayout.TabIndex = 0;
            // 
            // RadImperial
            // 
            this.RadImperial.AutoSize = true;
            this.RadImperial.Location = new System.Drawing.Point(123, 3);
            this.RadImperial.Name = "RadImperial";
            this.RadImperial.Size = new System.Drawing.Size(128, 35);
            this.RadImperial.TabIndex = 1;
            this.RadImperial.TabStop = true;
            this.RadImperial.Text = "Imperial";
            this.RadImperial.UseVisualStyleBackColor = true;
            this.RadImperial.CheckedChanged += new System.EventHandler(this.RadImperial_CheckedChanged);
            // 
            // RadMetric
            // 
            this.RadMetric.AutoSize = true;
            this.RadMetric.Location = new System.Drawing.Point(3, 3);
            this.RadMetric.Name = "RadMetric";
            this.RadMetric.Size = new System.Drawing.Size(106, 35);
            this.RadMetric.TabIndex = 0;
            this.RadMetric.TabStop = true;
            this.RadMetric.Text = "Metric";
            this.RadMetric.UseVisualStyleBackColor = true;
            this.RadMetric.CheckedChanged += new System.EventHandler(this.RadMetric_CheckedChanged);
            // 
            // labelhei
            // 
            this.labelhei.AutoSize = true;
            this.labelhei.Location = new System.Drawing.Point(3, 0);
            this.labelhei.Name = "labelhei";
            this.labelhei.Size = new System.Drawing.Size(144, 31);
            this.labelhei.TabIndex = 0;
            this.labelhei.Text = "My Height:";
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(158, 3);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(68, 38);
            this.txtHeight.TabIndex = 2;
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(232, 0);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(49, 31);
            this.lblHeight.TabIndex = 4;
            this.lblHeight.Text = "lbs";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Location = new System.Drawing.Point(64, 24);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(192, 31);
            this.Title.TabIndex = 2;
            this.Title.Text = "BMI Calculator";
            // 
            // btnCalculateBMI
            // 
            this.btnCalculateBMI.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCalculateBMI.Location = new System.Drawing.Point(70, 217);
            this.btnCalculateBMI.Name = "btnCalculateBMI";
            this.btnCalculateBMI.Size = new System.Drawing.Size(155, 75);
            this.btnCalculateBMI.TabIndex = 3;
            this.btnCalculateBMI.Text = "Calculate BMI!";
            this.btnCalculateBMI.UseVisualStyleBackColor = true;
            this.btnCalculateBMI.Click += new System.EventHandler(this.btnCalculateBMI_Click);
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(232, 46);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(43, 31);
            this.lblWeight.TabIndex = 1;
            this.lblWeight.Text = "kg";
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(158, 49);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(66, 38);
            this.txtWeight.TabIndex = 3;
            // 
            // labelwei
            // 
            this.labelwei.AutoSize = true;
            this.labelwei.Location = new System.Drawing.Point(3, 46);
            this.labelwei.Name = "labelwei";
            this.labelwei.Size = new System.Drawing.Size(149, 31);
            this.labelwei.TabIndex = 5;
            this.labelwei.Text = "My Weight:";
            // 
            // lblBMI
            // 
            this.lblBMI.AutoSize = true;
            this.lblBMI.Location = new System.Drawing.Point(99, 0);
            this.lblBMI.Name = "lblBMI";
            this.lblBMI.Size = new System.Drawing.Size(74, 31);
            this.lblBMI.TabIndex = 4;
            this.lblBMI.Text = "0000";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.68559F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.31441F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel1.Controls.Add(this.labelhei, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtHeight, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelwei, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtWeight, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblHeight, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblWeight, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(9, 121);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(286, 93);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // labelBmi
            // 
            this.labelBmi.AutoSize = true;
            this.labelBmi.Location = new System.Drawing.Point(3, 0);
            this.labelBmi.Name = "labelBmi";
            this.labelBmi.Size = new System.Drawing.Size(70, 31);
            this.labelBmi.TabIndex = 7;
            this.labelBmi.Text = "BMI:";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.51957F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.48043F));
            this.tableLayoutPanel2.Controls.Add(this.lblScale, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelScale, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelBmi, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblBMI, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(9, 298);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(281, 100);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // lblScale
            // 
            this.lblScale.AutoSize = true;
            this.lblScale.Location = new System.Drawing.Point(99, 50);
            this.lblScale.Name = "lblScale";
            this.lblScale.Size = new System.Drawing.Size(172, 31);
            this.lblScale.TabIndex = 9;
            this.lblScale.Text = "UnderWeight";
            // 
            // labelScale
            // 
            this.labelScale.AutoSize = true;
            this.labelScale.Location = new System.Drawing.Point(3, 50);
            this.labelScale.Name = "labelScale";
            this.labelScale.Size = new System.Drawing.Size(90, 31);
            this.labelScale.TabIndex = 8;
            this.labelScale.Text = "Scale:";
            // 
            // pbUnder
            // 
            this.pbUnder.BackColor = System.Drawing.Color.Yellow;
            this.pbUnder.Location = new System.Drawing.Point(18, 404);
            this.pbUnder.Name = "pbUnder";
            this.pbUnder.Size = new System.Drawing.Size(74, 25);
            this.pbUnder.TabIndex = 9;
            this.pbUnder.TabStop = false;
            this.pbUnder.Click += new System.EventHandler(this.BoxScaleBar_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(304, 24);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            // 
            // pbNormal
            // 
            this.pbNormal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pbNormal.Location = new System.Drawing.Point(18, 404);
            this.pbNormal.Name = "pbNormal";
            this.pbNormal.Size = new System.Drawing.Size(138, 25);
            this.pbNormal.TabIndex = 11;
            this.pbNormal.TabStop = false;
            // 
            // pbOver
            // 
            this.pbOver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pbOver.Location = new System.Drawing.Point(18, 404);
            this.pbOver.Name = "pbOver";
            this.pbOver.Size = new System.Drawing.Size(207, 25);
            this.pbOver.TabIndex = 12;
            this.pbOver.TabStop = false;
            // 
            // pbObese
            // 
            this.pbObese.BackColor = System.Drawing.Color.Red;
            this.pbObese.Location = new System.Drawing.Point(18, 404);
            this.pbObese.Name = "pbObese";
            this.pbObese.Size = new System.Drawing.Size(262, 25);
            this.pbObese.TabIndex = 13;
            this.pbObese.TabStop = false;
            // 
            // BMICalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 441);
            this.Controls.Add(this.pbUnder);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnCalculateBMI);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.RadioHeadLayout);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pbNormal);
            this.Controls.Add(this.pbOver);
            this.Controls.Add(this.pbObese);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMICalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.RadioHeadLayout.ResumeLayout(false);
            this.RadioHeadLayout.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUnder)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNormal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbObese)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel RadioHeadLayout;
        private System.Windows.Forms.RadioButton RadImperial;
        private System.Windows.Forms.RadioButton RadMetric;
        private System.Windows.Forms.Label labelhei;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button btnCalculateBMI;
        private System.Windows.Forms.Label labelwei;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblBMI;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelBmi;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label lblScale;
        private System.Windows.Forms.Label labelScale;
        private System.Windows.Forms.PictureBox pbUnder;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbNormal;
        private System.Windows.Forms.PictureBox pbOver;
        private System.Windows.Forms.PictureBox pbObese;
    }
}

