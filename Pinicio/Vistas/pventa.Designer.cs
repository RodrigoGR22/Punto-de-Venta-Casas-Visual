
namespace Pinicio
{
    partial class pventa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pventa));
            this.btnComprar = new System.Windows.Forms.Button();
            this.casa_imagen = new System.Windows.Forms.PictureBox();
            this.casa_nombre = new System.Windows.Forms.Label();
            this.casa_descripcion = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registroDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeCasasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.casa_precio = new System.Windows.Forms.Label();
            this.btnAnterior = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.casa_imagen)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnComprar
            // 
            this.btnComprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnComprar.FlatAppearance.BorderSize = 0;
            this.btnComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnComprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnComprar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnComprar.Location = new System.Drawing.Point(423, 260);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(129, 38);
            this.btnComprar.TabIndex = 0;
            this.btnComprar.Text = "COMPRAR";
            this.btnComprar.UseVisualStyleBackColor = false;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // casa_imagen
            // 
            this.casa_imagen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.casa_imagen.Location = new System.Drawing.Point(51, 46);
            this.casa_imagen.Name = "casa_imagen";
            this.casa_imagen.Size = new System.Drawing.Size(278, 185);
            this.casa_imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.casa_imagen.TabIndex = 3;
            this.casa_imagen.TabStop = false;
            // 
            // casa_nombre
            // 
            this.casa_nombre.AutoSize = true;
            this.casa_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.casa_nombre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.casa_nombre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.casa_nombre.Location = new System.Drawing.Point(356, 35);
            this.casa_nombre.Name = "casa_nombre";
            this.casa_nombre.Size = new System.Drawing.Size(256, 24);
            this.casa_nombre.TabIndex = 4;
            this.casa_nombre.Text = "Casa con 2 Pisos y Balcón";
            // 
            // casa_descripcion
            // 
            this.casa_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.casa_descripcion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.casa_descripcion.Location = new System.Drawing.Point(357, 59);
            this.casa_descripcion.Name = "casa_descripcion";
            this.casa_descripcion.Size = new System.Drawing.Size(277, 183);
            this.casa_descripcion.TabIndex = 6;
            this.casa_descripcion.Text = resources.GetString("casa_descripcion.Text");
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroDeUsuariosToolStripMenuItem,
            this.registroDeCasasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(677, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registroDeUsuariosToolStripMenuItem
            // 
            this.registroDeUsuariosToolStripMenuItem.Name = "registroDeUsuariosToolStripMenuItem";
            this.registroDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.registroDeUsuariosToolStripMenuItem.Text = "Registro de Usuarios";
            this.registroDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.registroDeUsuariosToolStripMenuItem_Click);
            // 
            // registroDeCasasToolStripMenuItem
            // 
            this.registroDeCasasToolStripMenuItem.Name = "registroDeCasasToolStripMenuItem";
            this.registroDeCasasToolStripMenuItem.Size = new System.Drawing.Size(111, 20);
            this.registroDeCasasToolStripMenuItem.Text = "Registro de Casas";
            this.registroDeCasasToolStripMenuItem.Click += new System.EventHandler(this.registroDeCasasToolStripMenuItem_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.Location = new System.Drawing.Point(629, 135);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(36, 43);
            this.btnSiguiente.TabIndex = 8;
            this.btnSiguiente.Text = ">";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // casa_precio
            // 
            this.casa_precio.AutoSize = true;
            this.casa_precio.Font = new System.Drawing.Font("Constantia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.casa_precio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.casa_precio.Location = new System.Drawing.Point(101, 250);
            this.casa_precio.Name = "casa_precio";
            this.casa_precio.Size = new System.Drawing.Size(180, 19);
            this.casa_precio.TabIndex = 9;
            this.casa_precio.Text = "PRECIO: $5,000,000.00";
            // 
            // btnAnterior
            // 
            this.btnAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAnterior.Enabled = false;
            this.btnAnterior.FlatAppearance.BorderSize = 0;
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.Location = new System.Drawing.Point(6, 134);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(36, 43);
            this.btnAnterior.TabIndex = 10;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = false;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // pventa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.ClientSize = new System.Drawing.Size(677, 336);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.casa_precio);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.casa_descripcion);
            this.Controls.Add(this.casa_nombre);
            this.Controls.Add(this.casa_imagen);
            this.Controls.Add(this.btnComprar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "pventa";
            this.Text = "House Centre";
            this.Load += new System.EventHandler(this.pventa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.casa_imagen)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.PictureBox casa_imagen;
        private System.Windows.Forms.Label casa_nombre;
        private System.Windows.Forms.Label casa_descripcion;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registroDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeCasasToolStripMenuItem;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Label casa_precio;
        private System.Windows.Forms.Button btnAnterior;
    }
}