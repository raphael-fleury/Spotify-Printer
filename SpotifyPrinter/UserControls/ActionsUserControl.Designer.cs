namespace SpotifyPrinter.UserControls
{
    partial class ActionsUserControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.toTxtButton = new System.Windows.Forms.Button();
            this.toJsonButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // toTxtButton
            // 
            this.toTxtButton.AutoSize = true;
            this.toTxtButton.Location = new System.Drawing.Point(50, 132);
            this.toTxtButton.Name = "toTxtButton";
            this.toTxtButton.Size = new System.Drawing.Size(100, 25);
            this.toTxtButton.TabIndex = 0;
            this.toTxtButton.Text = "Convert to TXT";
            this.toTxtButton.UseVisualStyleBackColor = true;
            // 
            // toJsonButton
            // 
            this.toJsonButton.AutoSize = true;
            this.toJsonButton.Location = new System.Drawing.Point(50, 163);
            this.toJsonButton.Name = "toJsonButton";
            this.toJsonButton.Size = new System.Drawing.Size(100, 25);
            this.toJsonButton.TabIndex = 1;
            this.toJsonButton.Text = "Convert to JSON";
            this.toJsonButton.UseVisualStyleBackColor = true;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(83, 103);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(35, 13);
            this.label.TabIndex = 2;
            this.label.Text = "label1";
            // 
            // ActionsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.Controls.Add(this.label);
            this.Controls.Add(this.toJsonButton);
            this.Controls.Add(this.toTxtButton);
            this.MaximumSize = new System.Drawing.Size(250, 0);
            this.MinimumSize = new System.Drawing.Size(150, 400);
            this.Name = "ActionsUserControl";
            this.Size = new System.Drawing.Size(200, 400);
            this.Resize += new System.EventHandler(this.ActionsUserControl_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button toTxtButton;
        private System.Windows.Forms.Button toJsonButton;
        private System.Windows.Forms.Label label;
    }
}
