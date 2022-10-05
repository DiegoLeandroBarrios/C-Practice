namespace TpLab2022
{
    partial class PersonasVer
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
            this.apellido = new System.Windows.Forms.Label();
            this.textBox_apellido = new System.Windows.Forms.TextBox();
            this.nombre_1 = new System.Windows.Forms.Label();
            this.legajo1 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_legajo = new System.Windows.Forms.TextBox();
            this.password1 = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.save1 = new System.Windows.Forms.Button();
            this.cancel1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // apellido
            // 
            this.apellido.AutoSize = true;
            this.apellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellido.Location = new System.Drawing.Point(24, 34);
            this.apellido.Name = "apellido";
            this.apellido.Size = new System.Drawing.Size(87, 24);
            this.apellido.TabIndex = 0;
            this.apellido.Text = "Apellido";
            // 
            // textBox_apellido
            // 
            this.textBox_apellido.Location = new System.Drawing.Point(141, 38);
            this.textBox_apellido.Name = "textBox_apellido";
            this.textBox_apellido.Size = new System.Drawing.Size(247, 20);
            this.textBox_apellido.TabIndex = 1;
            // 
            // nombre_1
            // 
            this.nombre_1.AutoSize = true;
            this.nombre_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_1.Location = new System.Drawing.Point(24, 111);
            this.nombre_1.Name = "nombre_1";
            this.nombre_1.Size = new System.Drawing.Size(85, 24);
            this.nombre_1.TabIndex = 2;
            this.nombre_1.Text = "Nombre";
            // 
            // legajo1
            // 
            this.legajo1.AutoSize = true;
            this.legajo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.legajo1.Location = new System.Drawing.Point(24, 185);
            this.legajo1.Name = "legajo1";
            this.legajo1.Size = new System.Drawing.Size(73, 24);
            this.legajo1.TabIndex = 3;
            this.legajo1.Text = "Legajo";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(141, 115);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(247, 20);
            this.textBox_name.TabIndex = 4;
            // 
            // textBox_legajo
            // 
            this.textBox_legajo.Location = new System.Drawing.Point(141, 189);
            this.textBox_legajo.Name = "textBox_legajo";
            this.textBox_legajo.Size = new System.Drawing.Size(247, 20);
            this.textBox_legajo.TabIndex = 5;
            // 
            // password1
            // 
            this.password1.AutoSize = true;
            this.password1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password1.Location = new System.Drawing.Point(24, 260);
            this.password1.Name = "password1";
            this.password1.Size = new System.Drawing.Size(100, 24);
            this.password1.TabIndex = 6;
            this.password1.Text = "Password";
            // 
            // textBox_password
            // 
            this.textBox_password.Location = new System.Drawing.Point(141, 264);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(247, 20);
            this.textBox_password.TabIndex = 7;
            // 
            // save1
            // 
            this.save1.Location = new System.Drawing.Point(164, 342);
            this.save1.Name = "save1";
            this.save1.Size = new System.Drawing.Size(85, 36);
            this.save1.TabIndex = 8;
            this.save1.Text = "Save";
            this.save1.UseVisualStyleBackColor = true;
            this.save1.Click += new System.EventHandler(this.save1_Click);
            // 
            // cancel1
            // 
            this.cancel1.Location = new System.Drawing.Point(287, 342);
            this.cancel1.Name = "cancel1";
            this.cancel1.Size = new System.Drawing.Size(89, 36);
            this.cancel1.TabIndex = 9;
            this.cancel1.Text = "Cancel";
            this.cancel1.UseVisualStyleBackColor = true;
            this.cancel1.Click += new System.EventHandler(this.cancel1_Click);
            // 
            // Personas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 450);
            this.Controls.Add(this.cancel1);
            this.Controls.Add(this.save1);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.password1);
            this.Controls.Add(this.textBox_legajo);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.legajo1);
            this.Controls.Add(this.nombre_1);
            this.Controls.Add(this.textBox_apellido);
            this.Controls.Add(this.apellido);
            this.Name = "Personas";
            this.Text = "Personas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label apellido;
        private System.Windows.Forms.TextBox textBox_apellido;
        private System.Windows.Forms.Label nombre_1;
        private System.Windows.Forms.Label legajo1;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.TextBox textBox_legajo;
        private System.Windows.Forms.Label password1;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button save1;
        private System.Windows.Forms.Button cancel1;
    }
}