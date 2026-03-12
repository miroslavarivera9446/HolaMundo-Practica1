namespace HolaMundo
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
            validar = new Button();
            label1 = new Label();
            label2 = new Label();
            tex1 = new TextBox();
            tex2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // validar
            // 
            validar.Location = new Point(510, 313);
            validar.Name = "validar";
            validar.Size = new Size(129, 59);
            validar.TabIndex = 0;
            validar.Text = "Validar";
            validar.UseVisualStyleBackColor = true;
            validar.Click += validar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(142, 84);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 1;
            label1.Text = "Ingresar Contraseña";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(129, 145);
            label2.Name = "label2";
            label2.Size = new Size(152, 20);
            label2.TabIndex = 2;
            label2.Text = "Reingrese Contreseña";
            // 
            // tex1
            // 
            tex1.Location = new Point(288, 84);
            tex1.Name = "tex1";
            tex1.Size = new Size(125, 27);
            tex1.TabIndex = 3;
            tex1.TextChanged += tex1_TextChanged;
            // 
            // tex2
            // 
            tex2.ForeColor = Color.Black;
            tex2.Location = new Point(288, 138);
            tex2.Name = "tex2";
            tex2.Size = new Size(125, 27);
            tex2.TabIndex = 4;
            tex2.TextChanged += tex2_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Red;
            label3.Location = new Point(265, 30);
            label3.Name = "label3";
            label3.Size = new Size(180, 20);
            label3.TabIndex = 5;
            label3.Text = "Practica 1     Hola Mundo ";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(235, 234);
            label4.Name = "label4";
            label4.Size = new Size(178, 20);
            label4.TabIndex = 6;
            label4.Text = "Tarea de Miroslava Rivera";
            label4.Click += label4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(tex2);
            Controls.Add(tex1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(validar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button validar;
        private Label label1;
        private Label label2;
        private TextBox tex1;
        private TextBox tex2;
        private Label label3;
        private Label label4;
    }
}
