namespace Tur_og_Retur_kørselslogbog
{
    partial class Hovedmenu
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
            this.Kørselslog = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.TilføjLog_knap = new System.Windows.Forms.Button();
            this.Tilføj = new System.Windows.Forms.Label();
            this.StartTextbox = new System.Windows.Forms.TextBox();
            this.SlutTextbox = new System.Windows.Forms.TextBox();
            this.KilometerTextbox = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Label();
            this.Slut = new System.Windows.Forms.Label();
            this.Kilometer = new System.Windows.Forms.Label();
            this.TilføjInformationer = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Kørselslog
            // 
            this.Kørselslog.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kørselslog.Location = new System.Drawing.Point(518, 71);
            this.Kørselslog.Name = "Kørselslog";
            this.Kørselslog.Size = new System.Drawing.Size(132, 33);
            this.Kørselslog.TabIndex = 0;
            this.Kørselslog.Text = "Kørselslog";
            this.Kørselslog.Click += new System.EventHandler(this.Kørselslog_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Gainsboro;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(410, 121);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(345, 318);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // TilføjLog_knap
            // 
            this.TilføjLog_knap.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TilføjLog_knap.Location = new System.Drawing.Point(149, 121);
            this.TilføjLog_knap.Name = "TilføjLog_knap";
            this.TilføjLog_knap.Size = new System.Drawing.Size(95, 35);
            this.TilføjLog_knap.TabIndex = 2;
            this.TilføjLog_knap.Text = "Tilføj";
            this.TilføjLog_knap.UseVisualStyleBackColor = true;
            this.TilføjLog_knap.Click += new System.EventHandler(this.TilføjLog_knap_Click);
            // 
            // Tilføj
            // 
            this.Tilføj.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tilføj.Location = new System.Drawing.Point(111, 71);
            this.Tilføj.Name = "Tilføj";
            this.Tilføj.Size = new System.Drawing.Size(195, 33);
            this.Tilføj.TabIndex = 4;
            this.Tilføj.Text = "Tilføj Kørelslog";
            this.Tilføj.Click += new System.EventHandler(this.Tilføj_Click);
            // 
            // StartTextbox
            // 
            this.StartTextbox.Location = new System.Drawing.Point(86, 199);
            this.StartTextbox.Name = "StartTextbox";
            this.StartTextbox.Size = new System.Drawing.Size(245, 20);
            this.StartTextbox.TabIndex = 5;
            this.StartTextbox.Visible = false;
            this.StartTextbox.TextChanged += new System.EventHandler(this.StartTextbox_TextChanged);
            // 
            // SlutTextbox
            // 
            this.SlutTextbox.Location = new System.Drawing.Point(86, 252);
            this.SlutTextbox.Name = "SlutTextbox";
            this.SlutTextbox.Size = new System.Drawing.Size(245, 20);
            this.SlutTextbox.TabIndex = 7;
            this.SlutTextbox.Visible = false;
            this.SlutTextbox.TextChanged += new System.EventHandler(this.SlutTextbox_TextChanged);
            // 
            // KilometerTextbox
            // 
            this.KilometerTextbox.Location = new System.Drawing.Point(86, 306);
            this.KilometerTextbox.Name = "KilometerTextbox";
            this.KilometerTextbox.Size = new System.Drawing.Size(245, 20);
            this.KilometerTextbox.TabIndex = 9;
            this.KilometerTextbox.Visible = false;
            this.KilometerTextbox.TextChanged += new System.EventHandler(this.KilometerTextbox_TextChanged);
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(86, 180);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(100, 23);
            this.Start.TabIndex = 10;
            this.Start.Text = "Start Lokation";
            this.Start.Visible = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Slut
            // 
            this.Slut.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slut.Location = new System.Drawing.Point(86, 235);
            this.Slut.Name = "Slut";
            this.Slut.Size = new System.Drawing.Size(100, 23);
            this.Slut.TabIndex = 11;
            this.Slut.Text = "Slut Lokation";
            this.Slut.Visible = false;
            this.Slut.Click += new System.EventHandler(this.Slut_Click);
            // 
            // Kilometer
            // 
            this.Kilometer.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Kilometer.Location = new System.Drawing.Point(86, 291);
            this.Kilometer.Name = "Kilometer";
            this.Kilometer.Size = new System.Drawing.Size(117, 23);
            this.Kilometer.TabIndex = 12;
            this.Kilometer.Text = "Antal Kilometer Kørt";
            this.Kilometer.Visible = false;
            this.Kilometer.Click += new System.EventHandler(this.Kilometer_Click);
            // 
            // TilføjInformationer
            // 
            this.TilføjInformationer.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TilføjInformationer.Location = new System.Drawing.Point(131, 345);
            this.TilføjInformationer.Name = "TilføjInformationer";
            this.TilføjInformationer.Size = new System.Drawing.Size(135, 35);
            this.TilføjInformationer.TabIndex = 14;
            this.TilføjInformationer.Text = "Tilføj informationer";
            this.TilføjInformationer.UseVisualStyleBackColor = true;
            this.TilføjInformationer.Visible = false;
            this.TilføjInformationer.Click += new System.EventHandler(this.TilføjInformationer_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Login Menu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Hovedmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 451);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TilføjInformationer);
            this.Controls.Add(this.KilometerTextbox);
            this.Controls.Add(this.SlutTextbox);
            this.Controls.Add(this.StartTextbox);
            this.Controls.Add(this.Tilføj);
            this.Controls.Add(this.TilføjLog_knap);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Kørselslog);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.Slut);
            this.Controls.Add(this.Kilometer);
            this.Name = "Hovedmenu";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Hovedmenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Kørselslog;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button TilføjLog_knap;
        private System.Windows.Forms.Label Tilføj;
        private System.Windows.Forms.TextBox StartTextbox;
        private System.Windows.Forms.TextBox SlutTextbox;
        private System.Windows.Forms.TextBox KilometerTextbox;
        private System.Windows.Forms.Label Start;
        private System.Windows.Forms.Label Slut;
        private System.Windows.Forms.Label Kilometer;
        private System.Windows.Forms.Button TilføjInformationer;
        private System.Windows.Forms.Button button1;
    }
}