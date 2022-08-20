namespace Mask
{
    partial class FrmMask
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtMask = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInput.Location = new System.Drawing.Point(36, 118);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(288, 50);
            this.txtInput.TabIndex = 0;
            // 
            // txtMask
            // 
            this.txtMask.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMask.Location = new System.Drawing.Point(346, 118);
            this.txtMask.Name = "txtMask";
            this.txtMask.Size = new System.Drawing.Size(293, 50);
            this.txtMask.TabIndex = 0;
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtResult.Location = new System.Drawing.Point(741, 118);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(490, 50);
            this.txtResult.TabIndex = 0;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGo
            // 
            this.btnGo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnGo.Location = new System.Drawing.Point(661, 118);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(63, 50);
            this.btnGo.TabIndex = 1;
            this.btnGo.Text = "=";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.BtnGo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Argument";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(346, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Edition Mask";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(741, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Formatted Text";
            // 
            // FrmMask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1270, 298);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtMask);
            this.Controls.Add(this.txtInput);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Name = "FrmMask";
            this.Text = "FrmMask";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtInput;
        private TextBox txtMask;
        private TextBox txtResult;
        private Button btnGo;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}