namespace Tur_og_Retur_kørselslogbog
{
    partial class LoginMenu
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.Adgangskode_input = new System.Windows.Forms.TextBox();
            this.Login_knap = new System.Windows.Forms.Button();
            this.Hovedmenu_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(165, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Brugernavn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 301);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Adgangskode";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(233, 250);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(329, 20);
            this.usernameInput.TabIndex = 7;
            this.usernameInput.TextChanged += new System.EventHandler(this.usernameInput_TextChanged);
            // 
            // Adgangskode_input
            // 
            this.Adgangskode_input.Location = new System.Drawing.Point(233, 298);
            this.Adgangskode_input.Name = "Adgangskode_input";
            this.Adgangskode_input.Size = new System.Drawing.Size(329, 20);
            this.Adgangskode_input.TabIndex = 9;
            this.Adgangskode_input.TextChanged += new System.EventHandler(this.Adgangskode_input_TextChanged);
            // 
            // Login_knap
            // 
            this.Login_knap.Location = new System.Drawing.Point(351, 346);
            this.Login_knap.Name = "Login_knap";
            this.Login_knap.Size = new System.Drawing.Size(75, 23);
            this.Login_knap.TabIndex = 10;
            this.Login_knap.Text = "Login";
            this.Login_knap.UseVisualStyleBackColor = true;
            this.Login_knap.Click += new System.EventHandler(this.Login_knap_Click);
            // 
            // Hovedmenu_text
            // 
            this.Hovedmenu_text.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hovedmenu_text.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.Hovedmenu_text.Location = new System.Drawing.Point(220, 96);
            this.Hovedmenu_text.Name = "Hovedmenu_text";
            this.Hovedmenu_text.Size = new System.Drawing.Size(361, 81);
            this.Hovedmenu_text.TabIndex = 11;
            this.Hovedmenu_text.Text = "Tur og Retur";
            this.Hovedmenu_text.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Hovedmenu_text.Click += new System.EventHandler(this.Hovedmenu_text_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.Hovedmenu_text);
            this.Controls.Add(this.Login_knap);
            this.Controls.Add(this.Adgangskode_input);
            this.Controls.Add(this.usernameInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.TextBox Adgangskode_input;
        private System.Windows.Forms.Button Login_knap;
        private System.Windows.Forms.Label Hovedmenu_text;
    }
}

