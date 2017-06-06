namespace SoustavaFormApp
{
    partial class MainWindow
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.Platno = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Platno)).BeginInit();
            this.SuspendLayout();
            // 
            // Timer
            // 
            this.Timer.Enabled = true;
            this.Timer.Interval = 10;
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // Platno
            // 
            this.Platno.Location = new System.Drawing.Point(0, 0);
            this.Platno.Name = "Platno";
            this.Platno.Size = new System.Drawing.Size(1181, 538);
            this.Platno.TabIndex = 0;
            this.Platno.TabStop = false;
            this.Platno.Paint += new System.Windows.Forms.PaintEventHandler(this.Platno_Paint);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 535);
            this.Controls.Add(this.Platno);
            this.Name = "MainWindow";
            this.Text = "p";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainWindow_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.Platno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.PictureBox Platno;
    }
}

