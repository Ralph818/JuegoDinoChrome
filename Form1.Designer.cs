namespace JuegoDinoChrome
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblGo = new System.Windows.Forms.Label();
            this.lblPuntuacion = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.GameOver = new System.Windows.Forms.PictureBox();
            this.Dino = new System.Windows.Forms.PictureBox();
            this.Piso = new System.Windows.Forms.PictureBox();
            this.DetectorChoques = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.GameOver)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dino)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Piso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetectorChoques)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGo
            // 
            this.lblGo.AutoSize = true;
            this.lblGo.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGo.Location = new System.Drawing.Point(165, 9);
            this.lblGo.Name = "lblGo";
            this.lblGo.Size = new System.Drawing.Size(125, 30);
            this.lblGo.TabIndex = 4;
            this.lblGo.Text = "Game Over";
            // 
            // lblPuntuacion
            // 
            this.lblPuntuacion.AutoSize = true;
            this.lblPuntuacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPuntuacion.Location = new System.Drawing.Point(367, 9);
            this.lblPuntuacion.Name = "lblPuntuacion";
            this.lblPuntuacion.Size = new System.Drawing.Size(38, 31);
            this.lblPuntuacion.TabIndex = 5;
            this.lblPuntuacion.Text = "...";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // GameOver
            // 
            this.GameOver.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("GameOver.BackgroundImage")));
            this.GameOver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.GameOver.Location = new System.Drawing.Point(201, 46);
            this.GameOver.Name = "GameOver";
            this.GameOver.Size = new System.Drawing.Size(42, 41);
            this.GameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.GameOver.TabIndex = 3;
            this.GameOver.TabStop = false;
            this.GameOver.Visible = false;
            this.GameOver.Click += new System.EventHandler(this.GameOver_Click);
            // 
            // Dino
            // 
            this.Dino.BackColor = System.Drawing.Color.Transparent;
            this.Dino.BackgroundImage = global::JuegoDinoChrome.Properties.Resources.Dino;
            this.Dino.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Dino.Image = global::JuegoDinoChrome.Properties.Resources.Dino1;
            this.Dino.Location = new System.Drawing.Point(63, 200);
            this.Dino.Name = "Dino";
            this.Dino.Size = new System.Drawing.Size(45, 50);
            this.Dino.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Dino.TabIndex = 2;
            this.Dino.TabStop = false;
            // 
            // Piso
            // 
            this.Piso.BackgroundImage = global::JuegoDinoChrome.Properties.Resources.piso1;
            this.Piso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Piso.Location = new System.Drawing.Point(12, 253);
            this.Piso.Name = "Piso";
            this.Piso.Size = new System.Drawing.Size(393, 10);
            this.Piso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.Piso.TabIndex = 1;
            this.Piso.TabStop = false;
            // 
            // DetectorChoques
            // 
            this.DetectorChoques.Location = new System.Drawing.Point(64, 200);
            this.DetectorChoques.Name = "DetectorChoques";
            this.DetectorChoques.Size = new System.Drawing.Size(21, 50);
            this.DetectorChoques.TabIndex = 0;
            this.DetectorChoques.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 294);
            this.Controls.Add(this.lblPuntuacion);
            this.Controls.Add(this.lblGo);
            this.Controls.Add(this.GameOver);
            this.Controls.Add(this.Dino);
            this.Controls.Add(this.Piso);
            this.Controls.Add(this.DetectorChoques);
            this.Name = "Form1";
            this.Text = "Juego Dino Chrome";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.GameOver)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dino)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Piso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetectorChoques)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox DetectorChoques;
        private System.Windows.Forms.PictureBox Piso;
        private System.Windows.Forms.PictureBox Dino;
        private System.Windows.Forms.PictureBox GameOver;
        private System.Windows.Forms.Label lblGo;
        private System.Windows.Forms.Label lblPuntuacion;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}

