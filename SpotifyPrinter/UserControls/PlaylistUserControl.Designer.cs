namespace SpotifyPrinter
{
    partial class PlaylistUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlaylistUserControl));
            this.picture = new System.Windows.Forms.PictureBox();
            this.title = new System.Windows.Forms.Label();
            this.desc = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.Color.DarkCyan;
            this.picture.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picture.BackgroundImage")));
            this.picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picture.Dock = System.Windows.Forms.DockStyle.Left;
            this.picture.Location = new System.Drawing.Point(0, 0);
            this.picture.Margin = new System.Windows.Forms.Padding(15);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(100, 100);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // title
            // 
            this.title.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(113, 10);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(173, 20);
            this.title.TabIndex = 1;
            this.title.Text = "Title";
            // 
            // desc
            // 
            this.desc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.desc.Location = new System.Drawing.Point(113, 39);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(172, 43);
            this.desc.TabIndex = 2;
            this.desc.Text = "URI: 4eLslb9s9PXmkr8mOgfrXF";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.DarkRed;
            this.deleteButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteButton.BackgroundImage")));
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.deleteButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.deleteButton.FlatAppearance.BorderSize = 0;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(301, 0);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(49, 100);
            this.deleteButton.TabIndex = 3;
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // PlaylistUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.desc);
            this.Controls.Add(this.title);
            this.Controls.Add(this.picture);
            this.MinimumSize = new System.Drawing.Size(350, 75);
            this.Name = "PlaylistUserControl";
            this.Size = new System.Drawing.Size(350, 100);
            this.Click += new System.EventHandler(this.PlaylistUserControl_Click);
            this.Resize += new System.EventHandler(this.PlaylistUserControl_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label desc;
        private System.Windows.Forms.Button deleteButton;
    }
}
