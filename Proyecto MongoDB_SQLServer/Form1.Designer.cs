namespace Proyecto_MongoDB_SQLServer
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
            btnCargarCsv = new Button();
            btnImportar = new Button();
            txtRutaCsv = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // btnCargarCsv
            // 
            btnCargarCsv.Location = new Point(124, 155);
            btnCargarCsv.Name = "btnCargarCsv";
            btnCargarCsv.Size = new Size(75, 23);
            btnCargarCsv.TabIndex = 0;
            btnCargarCsv.Text = "Cargar CSV";
            btnCargarCsv.UseVisualStyleBackColor = true;
            btnCargarCsv.Click += btnCargarCsv_Click;
            // 
            // btnImportar
            // 
            btnImportar.Location = new Point(138, 239);
            btnImportar.Name = "btnImportar";
            btnImportar.Size = new Size(75, 23);
            btnImportar.TabIndex = 1;
            btnImportar.Text = "Importar";
            btnImportar.UseVisualStyleBackColor = true;
            btnImportar.Click += btnImportar_Click;
            // 
            // txtRutaCsv
            // 
            txtRutaCsv.Location = new Point(246, 124);
            txtRutaCsv.Name = "txtRutaCsv";
            txtRutaCsv.Size = new Size(100, 23);
            txtRutaCsv.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtRutaCsv);
            Controls.Add(btnImportar);
            Controls.Add(btnCargarCsv);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCargarCsv;
        private Button btnImportar;
        private TextBox txtRutaCsv;
        private OpenFileDialog openFileDialog1;
    }
}
