
namespace SimpleCalculator
{
    partial class QuadraticEquationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuadraticEquationForm));
            this.lbX2 = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.lbZero = new System.Windows.Forms.Label();
            this.tbB = new System.Windows.Forms.TextBox();
            this.tbC = new System.Windows.Forms.TextBox();
            this.lbInfo = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbX2
            // 
            this.lbX2.AutoSize = true;
            this.lbX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbX2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(102)))));
            this.lbX2.Location = new System.Drawing.Point(69, 51);
            this.lbX2.Name = "lbX2";
            this.lbX2.Size = new System.Drawing.Size(43, 26);
            this.lbX2.TabIndex = 0;
            this.lbX2.Text = "x²±";
            // 
            // tbA
            // 
            this.tbA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(102)))));
            this.tbA.Location = new System.Drawing.Point(12, 51);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(59, 26);
            this.tbA.TabIndex = 1;
            this.tbA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbA_KeyPress);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(102)))));
            this.lblX.Location = new System.Drawing.Point(163, 51);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(36, 26);
            this.lblX.TabIndex = 6;
            this.lblX.Text = "x±";
            // 
            // lbZero
            // 
            this.lbZero.AutoSize = true;
            this.lbZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbZero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(102)))));
            this.lbZero.Location = new System.Drawing.Point(254, 51);
            this.lbZero.Name = "lbZero";
            this.lbZero.Size = new System.Drawing.Size(43, 26);
            this.lbZero.TabIndex = 7;
            this.lbZero.Text = "= 0";
            // 
            // tbB
            // 
            this.tbB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(102)))));
            this.tbB.Location = new System.Drawing.Point(106, 52);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(59, 26);
            this.tbB.TabIndex = 8;
            this.tbB.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbB_KeyPress);
            // 
            // tbC
            // 
            this.tbC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(102)))));
            this.tbC.Location = new System.Drawing.Point(195, 52);
            this.tbC.Name = "tbC";
            this.tbC.Size = new System.Drawing.Size(59, 26);
            this.tbC.TabIndex = 9;
            this.tbC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbC_KeyPress);
            // 
            // lbInfo
            // 
            this.lbInfo.AutoSize = true;
            this.lbInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lbInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(102)))));
            this.lbInfo.Location = new System.Drawing.Point(7, 9);
            this.lbInfo.Name = "lbInfo";
            this.lbInfo.Size = new System.Drawing.Size(341, 26);
            this.lbInfo.TabIndex = 10;
            this.lbInfo.Text = "Введите квадратное уравнение:";
            // 
            // btnOk
            // 
            this.btnOk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(191)))), ((int)(((byte)(187)))));
            this.btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(254)))), ((int)(((byte)(169)))));
            this.btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(102)))));
            this.btnOk.Location = new System.Drawing.Point(119, 94);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(229, 31);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "Рассчитать";
            this.btnOk.UseVisualStyleBackColor = false;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(191)))), ((int)(((byte)(187)))));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.btnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(254)))), ((int)(((byte)(169)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(76)))), ((int)(((byte)(102)))));
            this.btnCancel.Location = new System.Drawing.Point(12, 94);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(101, 31);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // QuadraticEquationForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(359, 141);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lbInfo);
            this.Controls.Add(this.tbC);
            this.Controls.Add(this.tbB);
            this.Controls.Add(this.lbZero);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.tbA);
            this.Controls.Add(this.lbX2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(375, 180);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(375, 180);
            this.Name = "QuadraticEquationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Решение квадратных уравнений";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbX2;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.Label lbZero;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.TextBox tbC;
        private System.Windows.Forms.Label lbInfo;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnCancel;
    }
}