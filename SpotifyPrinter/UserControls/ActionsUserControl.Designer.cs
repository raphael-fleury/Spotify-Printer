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
            this.label = new System.Windows.Forms.Label();
            this.chooseFolderButton = new System.Windows.Forms.Button();
            this.toJsonButton = new System.Windows.Forms.Button();
            this.toTxtButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label.Location = new System.Drawing.Point(5, 105);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(190, 13);
            this.label.TabIndex = 2;
            this.label.Text = "0 playlists selected";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chooseFolderButton
            // 
            this.chooseFolderButton.AutoSize = true;
            this.chooseFolderButton.BackColor = System.Drawing.Color.DarkCyan;
            this.chooseFolderButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.chooseFolderButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chooseFolderButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.chooseFolderButton.FlatAppearance.BorderSize = 0;
            this.chooseFolderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.chooseFolderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.chooseFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chooseFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chooseFolderButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.chooseFolderButton.Location = new System.Drawing.Point(0, 360);
            this.chooseFolderButton.Name = "chooseFolderButton";
            this.chooseFolderButton.Size = new System.Drawing.Size(200, 40);
            this.chooseFolderButton.TabIndex = 3;
            this.chooseFolderButton.Text = "Choose Folder";
            this.chooseFolderButton.UseVisualStyleBackColor = false;
            // 
            // toJsonButton
            // 
            this.toJsonButton.AutoSize = true;
            this.toJsonButton.BackColor = System.Drawing.Color.DarkCyan;
            this.toJsonButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toJsonButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toJsonButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.toJsonButton.FlatAppearance.BorderSize = 0;
            this.toJsonButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.toJsonButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.toJsonButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toJsonButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toJsonButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toJsonButton.Location = new System.Drawing.Point(0, 320);
            this.toJsonButton.Name = "toJsonButton";
            this.toJsonButton.Size = new System.Drawing.Size(200, 40);
            this.toJsonButton.TabIndex = 4;
            this.toJsonButton.Text = "Save as JSON";
            this.toJsonButton.UseVisualStyleBackColor = false;
            // 
            // toTxtButton
            // 
            this.toTxtButton.AutoSize = true;
            this.toTxtButton.BackColor = System.Drawing.Color.DarkCyan;
            this.toTxtButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toTxtButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toTxtButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.toTxtButton.FlatAppearance.BorderSize = 0;
            this.toTxtButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.toTxtButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.toTxtButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toTxtButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toTxtButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toTxtButton.Location = new System.Drawing.Point(0, 280);
            this.toTxtButton.Name = "toTxtButton";
            this.toTxtButton.Size = new System.Drawing.Size(200, 40);
            this.toTxtButton.TabIndex = 5;
            this.toTxtButton.Text = "Save as TXT";
            this.toTxtButton.UseVisualStyleBackColor = false;
            // 
            // ActionsUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.Controls.Add(this.toTxtButton);
            this.Controls.Add(this.toJsonButton);
            this.Controls.Add(this.chooseFolderButton);
            this.Controls.Add(this.label);
            this.MaximumSize = new System.Drawing.Size(250, 0);
            this.MinimumSize = new System.Drawing.Size(150, 400);
            this.Name = "ActionsUserControl";
            this.Size = new System.Drawing.Size(200, 400);
            this.Resize += new System.EventHandler(this.ActionsUserControl_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button chooseFolderButton;
        private System.Windows.Forms.Button toJsonButton;
        private System.Windows.Forms.Button toTxtButton;
    }
}
