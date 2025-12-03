namespace SlotMachineDemo
{
    partial class Slots
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
            this.BPull = new System.Windows.Forms.Button();
            this.UDCycles = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TbMesaj = new System.Windows.Forms.TextBox();
            this.TbCredits = new System.Windows.Forms.TextBox();
            this.Credite = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.gl4 = new OpenTK.GLControl();
            this.gl6 = new OpenTK.GLControl();
            this.gl5 = new OpenTK.GLControl();
            this.gl1 = new OpenTK.GLControl();
            this.gl7 = new OpenTK.GLControl();
            this.gl2 = new OpenTK.GLControl();
            this.gl3 = new OpenTK.GLControl();
            this.gl8 = new OpenTK.GLControl();
            this.gl9 = new OpenTK.GLControl();
            ((System.ComponentModel.ISupportInitialize)(this.UDCycles)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BPull
            // 
            this.BPull.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.BPull.Font = new System.Drawing.Font("Microsoft Uighur", 20.29091F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BPull.ForeColor = System.Drawing.Color.Maroon;
            this.BPull.Location = new System.Drawing.Point(705, 524);
            this.BPull.Name = "BPull";
            this.BPull.Size = new System.Drawing.Size(129, 72);
            this.BPull.TabIndex = 4;
            this.BPull.Text = "TRAGE!!!";
            this.BPull.UseVisualStyleBackColor = false;
            // 
            // UDCycles
            // 
            this.UDCycles.Location = new System.Drawing.Point(705, 480);
            this.UDCycles.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.UDCycles.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.UDCycles.Name = "UDCycles";
            this.UDCycles.Size = new System.Drawing.Size(129, 20);
            this.UDCycles.TabIndex = 5;
            this.UDCycles.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // timer1
            // 
            this.timer1.Interval = 80;
            // 
            // timer2
            // 
            this.timer2.Interval = 80;
            // 
            // timer3
            // 
            this.timer3.Interval = 80;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Controls.Add(this.gl9);
            this.groupBox1.Controls.Add(this.gl8);
            this.groupBox1.Controls.Add(this.gl3);
            this.groupBox1.Controls.Add(this.gl2);
            this.groupBox1.Controls.Add(this.gl7);
            this.groupBox1.Controls.Add(this.gl1);
            this.groupBox1.Controls.Add(this.gl5);
            this.groupBox1.Controls.Add(this.gl6);
            this.groupBox1.Controls.Add(this.gl4);
            this.groupBox1.Location = new System.Drawing.Point(74, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 416);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // TbMesaj
            // 
            this.TbMesaj.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TbMesaj.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TbMesaj.Font = new System.Drawing.Font("Monotype Corsiva", 20.29091F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TbMesaj.Location = new System.Drawing.Point(244, 500);
            this.TbMesaj.Name = "TbMesaj";
            this.TbMesaj.ReadOnly = true;
            this.TbMesaj.Size = new System.Drawing.Size(433, 35);
            this.TbMesaj.TabIndex = 10;
            // 
            // TbCredits
            // 
            this.TbCredits.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.70909F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TbCredits.Location = new System.Drawing.Point(95, 523);
            this.TbCredits.Name = "TbCredits";
            this.TbCredits.ReadOnly = true;
            this.TbCredits.Size = new System.Drawing.Size(122, 35);
            this.TbCredits.TabIndex = 9;
            // 
            // Credite
            // 
            this.Credite.AutoSize = true;
            this.Credite.Font = new System.Drawing.Font("Microsoft YaHei", 11.78182F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Credite.Location = new System.Drawing.Point(101, 495);
            this.Credite.Name = "Credite";
            this.Credite.Size = new System.Drawing.Size(87, 26);
            this.Credite.TabIndex = 11;
            this.Credite.Text = "Credite:";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Papyrus", 22.25455F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Green;
            this.title.Location = new System.Drawing.Point(283, 1);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(342, 55);
            this.title.TabIndex = 12;
            this.title.Text = "Winter Wonderland";
            // 
            // gl4
            // 
            this.gl4.BackColor = System.Drawing.Color.Black;
            this.gl4.Location = new System.Drawing.Point(44, 9);
            this.gl4.Name = "gl4";
            this.gl4.Size = new System.Drawing.Size(130, 133);
            this.gl4.TabIndex = 0;
            this.gl4.VSync = true;
            // 
            // gl6
            // 
            this.gl6.BackColor = System.Drawing.Color.Black;
            this.gl6.Location = new System.Drawing.Point(598, 9);
            this.gl6.Name = "gl6";
            this.gl6.Size = new System.Drawing.Size(130, 133);
            this.gl6.TabIndex = 2;
            this.gl6.VSync = true;
            // 
            // gl5
            // 
            this.gl5.BackColor = System.Drawing.Color.Black;
            this.gl5.Location = new System.Drawing.Point(322, 9);
            this.gl5.Name = "gl5";
            this.gl5.Size = new System.Drawing.Size(130, 133);
            this.gl5.TabIndex = 3;
            this.gl5.VSync = true;
            // 
            // gl1
            // 
            this.gl1.BackColor = System.Drawing.Color.Black;
            this.gl1.Location = new System.Drawing.Point(44, 148);
            this.gl1.Name = "gl1";
            this.gl1.Size = new System.Drawing.Size(130, 133);
            this.gl1.TabIndex = 4;
            this.gl1.VSync = true;
            // 
            // gl7
            // 
            this.gl7.BackColor = System.Drawing.Color.Black;
            this.gl7.Location = new System.Drawing.Point(44, 277);
            this.gl7.Name = "gl7";
            this.gl7.Size = new System.Drawing.Size(130, 133);
            this.gl7.TabIndex = 5;
            this.gl7.VSync = true;
            this.gl7.Load += new System.EventHandler(this.glControl5_Load);
            // 
            // gl2
            // 
            this.gl2.BackColor = System.Drawing.Color.Black;
            this.gl2.Location = new System.Drawing.Point(322, 148);
            this.gl2.Name = "gl2";
            this.gl2.Size = new System.Drawing.Size(130, 133);
            this.gl2.TabIndex = 6;
            this.gl2.VSync = true;
            // 
            // gl3
            // 
            this.gl3.BackColor = System.Drawing.Color.Black;
            this.gl3.Location = new System.Drawing.Point(598, 148);
            this.gl3.Name = "gl3";
            this.gl3.Size = new System.Drawing.Size(130, 133);
            this.gl3.TabIndex = 7;
            this.gl3.VSync = true;
            // 
            // gl8
            // 
            this.gl8.BackColor = System.Drawing.Color.Black;
            this.gl8.Location = new System.Drawing.Point(322, 277);
            this.gl8.Name = "gl8";
            this.gl8.Size = new System.Drawing.Size(130, 133);
            this.gl8.TabIndex = 8;
            this.gl8.VSync = true;
            // 
            // gl9
            // 
            this.gl9.BackColor = System.Drawing.Color.Black;
            this.gl9.Location = new System.Drawing.Point(598, 277);
            this.gl9.Name = "gl9";
            this.gl9.Size = new System.Drawing.Size(130, 133);
            this.gl9.TabIndex = 9;
            this.gl9.VSync = true;
            // 
            // Slots
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Ivory;
            this.ClientSize = new System.Drawing.Size(911, 608);
            this.Controls.Add(this.title);
            this.Controls.Add(this.Credite);
            this.Controls.Add(this.TbMesaj);
            this.Controls.Add(this.TbCredits);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UDCycles);
            this.Controls.Add(this.BPull);
            this.Name = "Slots";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.UDCycles)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BPull;
        private System.Windows.Forms.NumericUpDown UDCycles;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TbMesaj;
        private System.Windows.Forms.TextBox TbCredits;
        private System.Windows.Forms.Label Credite;
        private System.Windows.Forms.Label title;
        private OpenTK.GLControl gl7;
        private OpenTK.GLControl gl1;
        private OpenTK.GLControl gl5;
        private OpenTK.GLControl gl6;
        private OpenTK.GLControl gl4;
        private OpenTK.GLControl gl9;
        private OpenTK.GLControl gl8;
        private OpenTK.GLControl gl3;
        private OpenTK.GLControl gl2;
    }
}

