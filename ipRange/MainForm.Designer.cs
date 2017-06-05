namespace ipRange
{
    partial class MainForm
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
            this.lbIp = new System.Windows.Forms.ListBox();
            this.numPart1 = new System.Windows.Forms.NumericUpDown();
            this.numPart2 = new System.Windows.Forms.NumericUpDown();
            this.numPart3 = new System.Windows.Forms.NumericUpDown();
            this.numPart4 = new System.Windows.Forms.NumericUpDown();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numPart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPart4)).BeginInit();
            this.SuspendLayout();
            // 
            // lbIp
            // 
            this.lbIp.FormattingEnabled = true;
            this.lbIp.Location = new System.Drawing.Point(37, 87);
            this.lbIp.Name = "lbIp";
            this.lbIp.Size = new System.Drawing.Size(296, 95);
            this.lbIp.TabIndex = 0;
            // 
            // numPart1
            // 
            this.numPart1.Location = new System.Drawing.Point(37, 50);
            this.numPart1.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numPart1.Name = "numPart1";
            this.numPart1.Size = new System.Drawing.Size(60, 20);
            this.numPart1.TabIndex = 5;
            this.numPart1.ValueChanged += new System.EventHandler(this.numPart1_ValueChanged);
            // 
            // numPart2
            // 
            this.numPart2.Location = new System.Drawing.Point(114, 50);
            this.numPart2.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numPart2.Name = "numPart2";
            this.numPart2.Size = new System.Drawing.Size(60, 20);
            this.numPart2.TabIndex = 6;
            this.numPart2.ValueChanged += new System.EventHandler(this.numPart2_ValueChanged);
            // 
            // numPart3
            // 
            this.numPart3.Location = new System.Drawing.Point(190, 50);
            this.numPart3.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numPart3.Name = "numPart3";
            this.numPart3.Size = new System.Drawing.Size(60, 20);
            this.numPart3.TabIndex = 7;
            this.numPart3.ValueChanged += new System.EventHandler(this.numPart3_ValueChanged);
            // 
            // numPart4
            // 
            this.numPart4.Location = new System.Drawing.Point(273, 50);
            this.numPart4.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numPart4.Name = "numPart4";
            this.numPart4.Size = new System.Drawing.Size(60, 20);
            this.numPart4.TabIndex = 8;
            this.numPart4.ValueChanged += new System.EventHandler(this.numPart4_ValueChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(358, 50);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 255);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.numPart4);
            this.Controls.Add(this.numPart3);
            this.Controls.Add(this.numPart2);
            this.Controls.Add(this.numPart1);
            this.Controls.Add(this.lbIp);
            this.Name = "MainForm";
            this.Text = "Диапазон ip адресов";
            ((System.ComponentModel.ISupportInitialize)(this.numPart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPart4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbIp;
        private System.Windows.Forms.NumericUpDown numPart1;
        private System.Windows.Forms.NumericUpDown numPart2;
        private System.Windows.Forms.NumericUpDown numPart3;
        private System.Windows.Forms.NumericUpDown numPart4;
        private System.Windows.Forms.Button btnAdd;
    }
}

