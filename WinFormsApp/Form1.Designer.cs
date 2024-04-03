namespace WinFormsApp
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
            panel = new Panel();
            lblEredmenyek = new Label();
            btnSorsol = new Button();
            btnBezar = new Button();
            SuspendLayout();
            // 
            // panel
            // 
            panel.Location = new Point(22, 18);
            panel.Name = "panel";
            panel.Size = new Size(400, 221);
            panel.TabIndex = 0;
            // 
            // lblEredmenyek
            // 
            lblEredmenyek.AutoSize = true;
            lblEredmenyek.Location = new Point(447, 159);
            lblEredmenyek.Name = "lblEredmenyek";
            lblEredmenyek.Size = new Size(38, 15);
            lblEredmenyek.TabIndex = 1;
            lblEredmenyek.Text = "label1";
            lblEredmenyek.Click += label1_Click;
            // 
            // btnSorsol
            // 
            btnSorsol.Location = new Point(447, 18);
            btnSorsol.Name = "btnSorsol";
            btnSorsol.Size = new Size(75, 23);
            btnSorsol.TabIndex = 2;
            btnSorsol.Text = "Sorsol";
            btnSorsol.UseVisualStyleBackColor = true;
            btnSorsol.Click += btnSorsol_Click;
            // 
            // btnBezar
            // 
            btnBezar.Location = new Point(447, 60);
            btnBezar.Name = "btnBezar";
            btnBezar.Size = new Size(75, 23);
            btnBezar.TabIndex = 3;
            btnBezar.Text = "Bezar";
            btnBezar.UseVisualStyleBackColor = true;
            btnBezar.Click += btnBezar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 260);
            Controls.Add(btnBezar);
            Controls.Add(btnSorsol);
            Controls.Add(lblEredmenyek);
            Controls.Add(panel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel;
        private Label lblEredmenyek;
        private Button btnSorsol;
        private Button btnBezar;
    }
}