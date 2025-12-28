namespace Converter
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            kryptonManager1 = new Krypton.Toolkit.KryptonManager(components);
            kryptonTextBox1 = new Krypton.Toolkit.KryptonTextBox();
            kryptonTextBox2 = new Krypton.Toolkit.KryptonTextBox();
            kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            kryptonHeader1 = new Krypton.Toolkit.KryptonHeader();
            SuspendLayout();
            // 
            // kryptonManager1
            // 
            kryptonManager1.GlobalPaletteMode = Krypton.Toolkit.PaletteMode.Office2007Silver;
            kryptonManager1.ToolkitStrings.MessageBoxStrings.LessDetails = "L&ess Details...";
            kryptonManager1.ToolkitStrings.MessageBoxStrings.MoreDetails = "&More Details...";
            // 
            // kryptonTextBox1
            // 
            kryptonTextBox1.Location = new Point(12, 81);
            kryptonTextBox1.Multiline = true;
            kryptonTextBox1.Name = "kryptonTextBox1";
            kryptonTextBox1.Size = new Size(172, 73);
            kryptonTextBox1.TabIndex = 3;
            kryptonTextBox1.Text = " ";
            kryptonTextBox1.TextChanged += kryptonTextBox1_TextChanged;
            // 
            // kryptonTextBox2
            // 
            kryptonTextBox2.Location = new Point(209, 81);
            kryptonTextBox2.Multiline = true;
            kryptonTextBox2.Name = "kryptonTextBox2";
            kryptonTextBox2.Size = new Size(172, 73);
            kryptonTextBox2.TabIndex = 4;
            kryptonTextBox2.Text = " ";
            kryptonTextBox2.TextChanged += kryptonTextBox2_TextChanged;
            // 
            // kryptonLabel1
            // 
            kryptonLabel1.Location = new Point(12, 55);
            kryptonLabel1.Name = "kryptonLabel1";
            kryptonLabel1.Size = new Size(21, 20);
            kryptonLabel1.TabIndex = 5;
            kryptonLabel1.Values.Text = "In";
            // 
            // kryptonLabel2
            // 
            kryptonLabel2.Location = new Point(209, 55);
            kryptonLabel2.Name = "kryptonLabel2";
            kryptonLabel2.Size = new Size(31, 20);
            kryptonLabel2.TabIndex = 6;
            kryptonLabel2.Values.Text = "Out";
            // 
            // kryptonHeader1
            // 
            kryptonHeader1.Location = new Point(12, 12);
            kryptonHeader1.Name = "kryptonHeader1";
            kryptonHeader1.Size = new Size(351, 31);
            kryptonHeader1.TabIndex = 7;
            kryptonHeader1.Values.Description = "This converts base64 i guess\r\n";
            kryptonHeader1.Values.Heading = "Base64 Converter";
            kryptonHeader1.Values.Image = null;
            kryptonHeader1.Paint += kryptonHeader1_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(393, 167);
            Controls.Add(kryptonHeader1);
            Controls.Add(kryptonLabel2);
            Controls.Add(kryptonLabel1);
            Controls.Add(kryptonTextBox2);
            Controls.Add(kryptonTextBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            FormTitleAlign = Krypton.Toolkit.PaletteRelativeAlign.Center;
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            Text = "Base64";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonManager kryptonManager1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox1;
        private Krypton.Toolkit.KryptonTextBox kryptonTextBox2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonHeader kryptonHeader1;
    }
}
