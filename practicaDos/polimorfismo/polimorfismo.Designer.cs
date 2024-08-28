namespace practicaDos.polimorfismo
{
    partial class polimorfismo
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
            Encender = new Button();
            SuspendLayout();
            // 
            // Encender
            // 
            Encender.Location = new Point(66, 33);
            Encender.Name = "Encender";
            Encender.Size = new Size(646, 393);
            Encender.TabIndex = 0;
            Encender.Text = "Encender computadora";
            Encender.UseVisualStyleBackColor = true;
            Encender.Click += Encender_Click;
            // 
            // polimorfismo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(800, 450);
            Controls.Add(Encender);
            Name = "polimorfismo";
            Text = "polimorfismo";
            Load += polimorfismo_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Encender;
    }
}