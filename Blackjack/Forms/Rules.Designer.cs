namespace Blackjack.Forms
{
    partial class Rules
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
            this.tb_rules = new System.Windows.Forms.TextBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_rules
            // 
            this.tb_rules.BackColor = System.Drawing.Color.White;
            this.tb_rules.Enabled = false;
            this.tb_rules.Location = new System.Drawing.Point(12, 12);
            this.tb_rules.Multiline = true;
            this.tb_rules.Name = "tb_rules";
            this.tb_rules.Size = new System.Drawing.Size(776, 342);
            this.tb_rules.TabIndex = 0;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(264, 360);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(258, 78);
            this.btn_back.TabIndex = 1;
            this.btn_back.Text = "Назад";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // Rules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.tb_rules);
            this.Name = "Rules";
            this.Text = "Rules";
            this.Load += new System.EventHandler(this.Rules_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_rules;
        private System.Windows.Forms.Button btn_back;
    }
}