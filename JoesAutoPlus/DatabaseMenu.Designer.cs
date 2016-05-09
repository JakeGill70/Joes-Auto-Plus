namespace JoesAutoPlus {
    partial class DatabaseMenu {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.salesDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // salesDataGrid
            // 
            this.salesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.salesDataGrid.Location = new System.Drawing.Point(12, 12);
            this.salesDataGrid.Name = "salesDataGrid";
            this.salesDataGrid.Size = new System.Drawing.Size(581, 237);
            this.salesDataGrid.TabIndex = 0;
            // 
            // DatabaseMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 261);
            this.Controls.Add(this.salesDataGrid);
            this.Name = "DatabaseMenu";
            this.Text = "DatabaseMenu";
            this.Load += new System.EventHandler(this.DatabaseMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salesDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView salesDataGrid;
    }
}