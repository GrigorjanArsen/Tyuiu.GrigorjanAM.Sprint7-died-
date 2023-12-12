
namespace Tyuiu.GrigorjanAM.Sprint7
{
    partial class FormMain
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
            this.panelButtons_GAM = new System.Windows.Forms.Panel();
            this.panelMain_GAM = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelButtons_GAM
            // 
            this.panelButtons_GAM.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons_GAM.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_GAM.Name = "panelButtons_GAM";
            this.panelButtons_GAM.Size = new System.Drawing.Size(884, 87);
            this.panelButtons_GAM.TabIndex = 0;
            // 
            // panelMain_GAM
            // 
            this.panelMain_GAM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain_GAM.Location = new System.Drawing.Point(0, 87);
            this.panelMain_GAM.Name = "panelMain_GAM";
            this.panelMain_GAM.Size = new System.Drawing.Size(884, 374);
            this.panelMain_GAM.TabIndex = 1;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.panelMain_GAM);
            this.Controls.Add(this.panelButtons_GAM);
            this.Name = "FormMain";
            this.Text = "Каталог видео-клипов";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_GAM;
        private System.Windows.Forms.Panel panelMain_GAM;
    }
}

