
namespace PABD
{
    partial class Form2
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
            this.DataGrid = new System.Windows.Forms.Label();
            this.DataBinding = new System.Windows.Forms.Label();
            this.BTNDataGrid = new System.Windows.Forms.Button();
            this.BTNDataBinding = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DataGrid
            // 
            this.DataGrid.AutoSize = true;
            this.DataGrid.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataGrid.ForeColor = System.Drawing.Color.White;
            this.DataGrid.Location = new System.Drawing.Point(31, 71);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Size = new System.Drawing.Size(218, 34);
            this.DataGrid.TabIndex = 0;
            this.DataGrid.Text = "Data Grid View";
            this.DataGrid.Click += new System.EventHandler(this.label1_Click);
            // 
            // DataBinding
            // 
            this.DataBinding.AutoSize = true;
            this.DataBinding.Font = new System.Drawing.Font("Bauhaus 93", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataBinding.ForeColor = System.Drawing.Color.White;
            this.DataBinding.Location = new System.Drawing.Point(41, 198);
            this.DataBinding.Name = "DataBinding";
            this.DataBinding.Size = new System.Drawing.Size(192, 34);
            this.DataBinding.TabIndex = 1;
            this.DataBinding.Text = "Data Binding";
            // 
            // BTNDataGrid
            // 
            this.BTNDataGrid.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDataGrid.Location = new System.Drawing.Point(63, 119);
            this.BTNDataGrid.Name = "BTNDataGrid";
            this.BTNDataGrid.Size = new System.Drawing.Size(137, 38);
            this.BTNDataGrid.TabIndex = 2;
            this.BTNDataGrid.Text = "Select";
            this.BTNDataGrid.UseVisualStyleBackColor = true;
            this.BTNDataGrid.Click += new System.EventHandler(this.BTNDataGrid_Click);
            // 
            // BTNDataBinding
            // 
            this.BTNDataBinding.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDataBinding.Location = new System.Drawing.Point(63, 250);
            this.BTNDataBinding.Name = "BTNDataBinding";
            this.BTNDataBinding.Size = new System.Drawing.Size(137, 38);
            this.BTNDataBinding.TabIndex = 3;
            this.BTNDataBinding.Text = "Select";
            this.BTNDataBinding.UseVisualStyleBackColor = true;
            this.BTNDataBinding.Click += new System.EventHandler(this.BTNDataBinding_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(272, 392);
            this.Controls.Add(this.BTNDataBinding);
            this.Controls.Add(this.BTNDataGrid);
            this.Controls.Add(this.DataBinding);
            this.Controls.Add(this.DataGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form2";
            this.Text = "Menu Select";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label DataGrid;
        private System.Windows.Forms.Label DataBinding;
        private System.Windows.Forms.Button BTNDataGrid;
        private System.Windows.Forms.Button BTNDataBinding;
    }
}