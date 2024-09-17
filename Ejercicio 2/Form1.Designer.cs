namespace Ejercicio_2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.rdoSmoking = new System.Windows.Forms.RadioButton();
            this.rdoNonSmoking = new System.Windows.Forms.RadioButton();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblBoardingPass = new System.Windows.Forms.Label();
            this.SuspendLayout();
            
           //Label1
           
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(38, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione su preferecia de asiento:";
            // 
            // rdofumadores
            // 
            this.rdoSmoking.AutoSize = true;
            this.rdoSmoking.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoSmoking.ForeColor = System.Drawing.Color.Red;
            this.rdoSmoking.Location = new System.Drawing.Point(41, 67);
            this.rdoSmoking.Margin = new System.Windows.Forms.Padding(2);
            this.rdoSmoking.Name = "rdoSmoking";
            this.rdoSmoking.Size = new System.Drawing.Size(88, 28);
            this.rdoSmoking.TabIndex = 1;
            this.rdoSmoking.TabStop = true;
            this.rdoSmoking.Text = "Fumar";
            this.rdoSmoking.UseVisualStyleBackColor = true;
            // 
            // rdoNoFumadores
            // 
            this.rdoNonSmoking.AutoSize = true;
            this.rdoNonSmoking.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoNonSmoking.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rdoNonSmoking.Location = new System.Drawing.Point(42, 131);
            this.rdoNonSmoking.Margin = new System.Windows.Forms.Padding(2);
            this.rdoNonSmoking.Name = "rdoNonSmoking";
            this.rdoNonSmoking.Size = new System.Drawing.Size(121, 28);
            this.rdoNonSmoking.TabIndex = 2;
            this.rdoNonSmoking.TabStop = true;
            this.rdoNonSmoking.Text = "No Fumar";
            this.rdoNonSmoking.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Blue;
            this.btnSubmit.Location = new System.Drawing.Point(244, 153);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(169, 32);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Asignar lugar";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblBoardingPass
            // 
            this.lblBoardingPass.AutoSize = true;
            this.lblBoardingPass.Location = new System.Drawing.Point(38, 166);
            this.lblBoardingPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBoardingPass.Name = "lblBoardingPass";
            this.lblBoardingPass.Size = new System.Drawing.Size(0, 13);
            this.lblBoardingPass.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(523, 372);
            this.Controls.Add(this.lblBoardingPass);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.rdoNonSmoking);
            this.Controls.Add(this.rdoSmoking);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Elegir Asiento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdoSmoking;
        private System.Windows.Forms.RadioButton rdoNonSmoking;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblBoardingPass;
    }
}