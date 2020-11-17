namespace Prova.Forms
{
    partial class Lista
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
            this.richTextBoxPacientes = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBoxPacientes
            // 
            this.richTextBoxPacientes.Location = new System.Drawing.Point(248, 176);
            this.richTextBoxPacientes.Name = "richTextBoxPacientes";
            this.richTextBoxPacientes.Size = new System.Drawing.Size(305, 98);
            this.richTextBoxPacientes.TabIndex = 4;
            this.richTextBoxPacientes.Text = "";
            this.richTextBoxPacientes.TextChanged += new System.EventHandler(this.richTextBoxPacientes_TextChanged);
            // 
            // Lista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBoxPacientes);
            this.Name = "Lista";
            this.Text = "Lista";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxPacientes;
    }
}