
namespace Study_Time_Software
{
    partial class FormRegistros
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
            this.DeleteRowBtn = new System.Windows.Forms.Button();
            this.SesionDGV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SesionDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteRowBtn
            // 
            this.DeleteRowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteRowBtn.Location = new System.Drawing.Point(298, 237);
            this.DeleteRowBtn.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteRowBtn.Name = "DeleteRowBtn";
            this.DeleteRowBtn.Size = new System.Drawing.Size(73, 21);
            this.DeleteRowBtn.TabIndex = 13;
            this.DeleteRowBtn.Text = "Eliminar Sesion";
            this.DeleteRowBtn.UseVisualStyleBackColor = true;
            // 
            // SesionDGV
            // 
            this.SesionDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SesionDGV.Location = new System.Drawing.Point(12, 12);
            this.SesionDGV.Name = "SesionDGV";
            this.SesionDGV.Size = new System.Drawing.Size(776, 210);
            this.SesionDGV.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(722, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "By: DevElop";
            // 
            // FormRegistros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 372);
            this.Controls.Add(this.DeleteRowBtn);
            this.Controls.Add(this.SesionDGV);
            this.Controls.Add(this.label2);
            this.Name = "FormRegistros";
            this.Text = "FormRegistros";
            ((System.ComponentModel.ISupportInitialize)(this.SesionDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteRowBtn;
        private System.Windows.Forms.DataGridView SesionDGV;
        private System.Windows.Forms.Label label2;
    }
}