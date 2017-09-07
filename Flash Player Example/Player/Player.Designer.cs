namespace CADLearning.Windows.Player
{
    partial class Player
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;



        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player));
            this.flash = new AxShockwaveFlashObjects.AxShockwaveFlash();
            ((System.ComponentModel.ISupportInitialize)(this.flash)).BeginInit();
            this.SuspendLayout();
            // 
            // flash
            // 
            this.flash.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flash.Enabled = true;
            this.flash.Location = new System.Drawing.Point(0, 0);
            this.flash.Name = "flash";
            this.flash.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("flash.OcxState")));
            this.flash.Size = new System.Drawing.Size(958, 645);
            this.flash.TabIndex = 0;
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.flash);
            this.Name = "Player";
            this.Size = new System.Drawing.Size(958, 645);
            ((System.ComponentModel.ISupportInitialize)(this.flash)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxShockwaveFlashObjects.AxShockwaveFlash flash;
    }
}
