namespace Practica3Poe.Forms
{
    partial class StudenSystem
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
            label1 = new Label();
            lblAlumno = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtPhone = new TextBox();
            txtCarrera = new TextBox();
            RegistroAlumno = new ListBox();
            btnAgregar = new Button();
            txtEliminar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Script", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(278, 32);
            label1.Name = "label1";
            label1.Size = new Size(213, 30);
            label1.TabIndex = 0;
            label1.Text = "Registro De Alumnos";
            // 
            // lblAlumno
            // 
            lblAlumno.AutoSize = true;
            lblAlumno.Font = new Font("Segoe Script", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAlumno.Location = new Point(153, 121);
            lblAlumno.Name = "lblAlumno";
            lblAlumno.Size = new Size(213, 28);
            lblAlumno.TabIndex = 1;
            lblAlumno.Text = "Nombre Del Alumno :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Script", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(138, 173);
            label3.Name = "label3";
            label3.Size = new Size(228, 28);
            label3.TabIndex = 2;
            label3.Text = "Apellidos Del Alumno :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Script", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(39, 223);
            label4.Name = "label4";
            label4.Size = new Size(327, 28);
            label4.TabIndex = 3;
            label4.Text = "Numero De Telefono Del Alumno :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Script", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(155, 273);
            label5.Name = "label5";
            label5.Size = new Size(211, 28);
            label5.TabIndex = 4;
            label5.Text = "Carrera Del Alumno :";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(391, 121);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(277, 27);
            txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(391, 163);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(277, 27);
            txtApellido.TabIndex = 6;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(391, 223);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(277, 27);
            txtPhone.TabIndex = 7;
            // 
            // txtCarrera
            // 
            txtCarrera.Location = new Point(391, 273);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(277, 27);
            txtCarrera.TabIndex = 8;
            // 
            // RegistroAlumno
            // 
            RegistroAlumno.Font = new Font("Segoe Script", 9F, FontStyle.Bold);
            RegistroAlumno.FormattingEnabled = true;
            RegistroAlumno.ItemHeight = 25;
            RegistroAlumno.Location = new Point(39, 439);
            RegistroAlumno.Name = "RegistroAlumno";
            RegistroAlumno.Size = new Size(790, 179);
            RegistroAlumno.TabIndex = 9;
            // 
            // btnAgregar
            // 
            btnAgregar.Font = new Font("Segoe Script", 9F, FontStyle.Bold);
            btnAgregar.Location = new Point(252, 342);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // txtEliminar
            // 
            txtEliminar.Font = new Font("Segoe Script", 9F, FontStyle.Bold);
            txtEliminar.Location = new Point(411, 342);
            txtEliminar.Name = "txtEliminar";
            txtEliminar.Size = new Size(94, 29);
            txtEliminar.TabIndex = 11;
            txtEliminar.Text = "Eliminar";
            txtEliminar.UseVisualStyleBackColor = true;
            txtEliminar.Click += txtEliminar_Click;
            // 
            // StudenSystem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(864, 648);
            Controls.Add(txtEliminar);
            Controls.Add(btnAgregar);
            Controls.Add(RegistroAlumno);
            Controls.Add(txtCarrera);
            Controls.Add(txtPhone);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lblAlumno);
            Controls.Add(label1);
            ForeColor = Color.FromArgb(192, 192, 255);
            Name = "StudenSystem";
            Text = "StudenSystem";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblAlumno;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtPhone;
        private TextBox txtCarrera;
        private ListBox RegistroAlumno;
        private Button btnAgregar;
        private Button txtEliminar;
    }
}