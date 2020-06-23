namespace SpotifyPrinter
{
    partial class AuthenticationForm
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox = new System.Windows.Forms.TextBox();
            this.authButton = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 34);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(449, 20);
            this.textBox.TabIndex = 0;
            // 
            // authButton
            // 
            this.authButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.authButton.Location = new System.Drawing.Point(196, 67);
            this.authButton.Name = "authButton";
            this.authButton.Size = new System.Drawing.Size(75, 23);
            this.authButton.TabIndex = 1;
            this.authButton.Text = "Authenticate";
            this.authButton.UseVisualStyleBackColor = true;
            this.authButton.Click += new System.EventHandler(this.authButton_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(12, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(151, 13);
            this.label.TabIndex = 2;
            this.label.Text = "Insert the authentication code:";
            // 
            // AuthenticationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 102);
            this.Controls.Add(this.label);
            this.Controls.Add(this.authButton);
            this.Controls.Add(this.textBox);
            this.Name = "AuthenticationForm";
            this.Text = "Authentication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button authButton;
        private System.Windows.Forms.Label label;
    }
}

