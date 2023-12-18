
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelButtons_GAM = new System.Windows.Forms.Panel();
            this.buttonHandVodstvo_GAM = new System.Windows.Forms.Button();
            this.buttonHelp_GAM = new System.Windows.Forms.Button();
            this.buttonGraph_GAM = new System.Windows.Forms.Button();
            this.buttonSave_GAM = new System.Windows.Forms.Button();
            this.buttonInPut_GAM = new System.Windows.Forms.Button();
            this.buttonFilters_GAM = new System.Windows.Forms.Button();
            this.panelMain_GAM = new System.Windows.Forms.Panel();
            this.dataGridViewBase_GAM = new System.Windows.Forms.DataGridView();
            this.splitterBandG_GAM = new System.Windows.Forms.Splitter();
            this.openFileDialog_GAM = new System.Windows.Forms.OpenFileDialog();
            this.panelButtons_GAM.SuspendLayout();
            this.panelMain_GAM.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBase_GAM)).BeginInit();
            this.SuspendLayout();
            // 
            // panelButtons_GAM
            // 
            this.panelButtons_GAM.Controls.Add(this.buttonHandVodstvo_GAM);
            this.panelButtons_GAM.Controls.Add(this.buttonHelp_GAM);
            this.panelButtons_GAM.Controls.Add(this.buttonGraph_GAM);
            this.panelButtons_GAM.Controls.Add(this.buttonSave_GAM);
            this.panelButtons_GAM.Controls.Add(this.buttonInPut_GAM);
            this.panelButtons_GAM.Controls.Add(this.buttonFilters_GAM);
            this.panelButtons_GAM.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelButtons_GAM.Location = new System.Drawing.Point(0, 0);
            this.panelButtons_GAM.Name = "panelButtons_GAM";
            this.panelButtons_GAM.Size = new System.Drawing.Size(131, 411);
            this.panelButtons_GAM.TabIndex = 0;
            // 
            // buttonHandVodstvo_GAM
            // 
            this.buttonHandVodstvo_GAM.BackColor = System.Drawing.Color.Indigo;
            this.buttonHandVodstvo_GAM.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.buttonHandVodstvo_GAM.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonHandVodstvo_GAM.Location = new System.Drawing.Point(13, 365);
            this.buttonHandVodstvo_GAM.Name = "buttonHandVodstvo_GAM";
            this.buttonHandVodstvo_GAM.Size = new System.Drawing.Size(106, 23);
            this.buttonHandVodstvo_GAM.TabIndex = 2;
            this.buttonHandVodstvo_GAM.Text = "Руководство";
            this.buttonHandVodstvo_GAM.UseVisualStyleBackColor = false;
            // 
            // buttonHelp_GAM
            // 
            this.buttonHelp_GAM.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonHelp_GAM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonHelp_GAM.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp_GAM.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonHelp_GAM.Location = new System.Drawing.Point(29, 336);
            this.buttonHelp_GAM.Name = "buttonHelp_GAM";
            this.buttonHelp_GAM.Size = new System.Drawing.Size(75, 23);
            this.buttonHelp_GAM.TabIndex = 2;
            this.buttonHelp_GAM.Text = "Справка";
            this.buttonHelp_GAM.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonHelp_GAM.UseVisualStyleBackColor = false;
            // 
            // buttonGraph_GAM
            // 
            this.buttonGraph_GAM.BackColor = System.Drawing.Color.Transparent;
            this.buttonGraph_GAM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonGraph_GAM.BackgroundImage")));
            this.buttonGraph_GAM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonGraph_GAM.FlatAppearance.BorderSize = 0;
            this.buttonGraph_GAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGraph_GAM.Location = new System.Drawing.Point(29, 174);
            this.buttonGraph_GAM.Name = "buttonGraph_GAM";
            this.buttonGraph_GAM.Size = new System.Drawing.Size(75, 75);
            this.buttonGraph_GAM.TabIndex = 1;
            this.buttonGraph_GAM.UseVisualStyleBackColor = false;
            this.buttonGraph_GAM.Click += new System.EventHandler(this.buttonSave_GAM_Click);
            // 
            // buttonSave_GAM
            // 
            this.buttonSave_GAM.BackColor = System.Drawing.Color.Transparent;
            this.buttonSave_GAM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSave_GAM.BackgroundImage")));
            this.buttonSave_GAM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSave_GAM.FlatAppearance.BorderSize = 0;
            this.buttonSave_GAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave_GAM.Location = new System.Drawing.Point(29, 93);
            this.buttonSave_GAM.Name = "buttonSave_GAM";
            this.buttonSave_GAM.Size = new System.Drawing.Size(75, 75);
            this.buttonSave_GAM.TabIndex = 1;
            this.buttonSave_GAM.UseVisualStyleBackColor = false;
            this.buttonSave_GAM.Click += new System.EventHandler(this.buttonSave_GAM_Click);
            // 
            // buttonInPut_GAM
            // 
            this.buttonInPut_GAM.BackColor = System.Drawing.Color.Transparent;
            this.buttonInPut_GAM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonInPut_GAM.BackgroundImage")));
            this.buttonInPut_GAM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonInPut_GAM.FlatAppearance.BorderSize = 0;
            this.buttonInPut_GAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInPut_GAM.Location = new System.Drawing.Point(29, 12);
            this.buttonInPut_GAM.Name = "buttonInPut_GAM";
            this.buttonInPut_GAM.Size = new System.Drawing.Size(75, 75);
            this.buttonInPut_GAM.TabIndex = 1;
            this.buttonInPut_GAM.UseVisualStyleBackColor = false;
            this.buttonInPut_GAM.Click += new System.EventHandler(this.buttonInPut_GAM_Click);
            // 
            // buttonFilters_GAM
            // 
            this.buttonFilters_GAM.BackColor = System.Drawing.Color.Transparent;
            this.buttonFilters_GAM.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonFilters_GAM.BackgroundImage")));
            this.buttonFilters_GAM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonFilters_GAM.FlatAppearance.BorderSize = 0;
            this.buttonFilters_GAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFilters_GAM.Location = new System.Drawing.Point(29, 255);
            this.buttonFilters_GAM.Name = "buttonFilters_GAM";
            this.buttonFilters_GAM.Size = new System.Drawing.Size(75, 75);
            this.buttonFilters_GAM.TabIndex = 0;
            this.buttonFilters_GAM.UseVisualStyleBackColor = false;
            // 
            // panelMain_GAM
            // 
            this.panelMain_GAM.Controls.Add(this.dataGridViewBase_GAM);
            this.panelMain_GAM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain_GAM.Location = new System.Drawing.Point(131, 0);
            this.panelMain_GAM.Name = "panelMain_GAM";
            this.panelMain_GAM.Size = new System.Drawing.Size(653, 411);
            this.panelMain_GAM.TabIndex = 1;
            // 
            // dataGridViewBase_GAM
            // 
            this.dataGridViewBase_GAM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBase_GAM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewBase_GAM.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewBase_GAM.Name = "dataGridViewBase_GAM";
            this.dataGridViewBase_GAM.RowHeadersVisible = false;
            this.dataGridViewBase_GAM.Size = new System.Drawing.Size(653, 411);
            this.dataGridViewBase_GAM.TabIndex = 0;
            // 
            // splitterBandG_GAM
            // 
            this.splitterBandG_GAM.Location = new System.Drawing.Point(131, 0);
            this.splitterBandG_GAM.Name = "splitterBandG_GAM";
            this.splitterBandG_GAM.Size = new System.Drawing.Size(3, 411);
            this.splitterBandG_GAM.TabIndex = 2;
            this.splitterBandG_GAM.TabStop = false;
            // 
            // openFileDialog_GAM
            // 
            this.openFileDialog_GAM.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.splitterBandG_GAM);
            this.Controls.Add(this.panelMain_GAM);
            this.Controls.Add(this.panelButtons_GAM);
            this.Name = "FormMain";
            this.Text = "Каталог видео-клипов";
            this.panelButtons_GAM.ResumeLayout(false);
            this.panelMain_GAM.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBase_GAM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelButtons_GAM;
        private System.Windows.Forms.Panel panelMain_GAM;
        private System.Windows.Forms.Button buttonSave_GAM;
        private System.Windows.Forms.Button buttonInPut_GAM;
        private System.Windows.Forms.Button buttonFilters_GAM;
        private System.Windows.Forms.Splitter splitterBandG_GAM;
        private System.Windows.Forms.Button buttonGraph_GAM;
        private System.Windows.Forms.Button buttonHandVodstvo_GAM;
        private System.Windows.Forms.Button buttonHelp_GAM;
        private System.Windows.Forms.OpenFileDialog openFileDialog_GAM;
        public System.Windows.Forms.DataGridView dataGridViewBase_GAM;
    }
}

