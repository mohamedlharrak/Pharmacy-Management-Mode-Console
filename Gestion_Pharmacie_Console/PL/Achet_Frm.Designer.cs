namespace Gestion_Pharmacie_Console.PL
{
    partial class Achet_Frm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtQte = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtChifa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConx = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Green;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 2);
            this.panel2.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Green;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(412, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 381);
            this.panel1.TabIndex = 11;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Green;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 381);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(412, 2);
            this.panel4.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Green;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 379);
            this.panel3.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = global::Gestion_Pharmacie_Console.Properties.Resources.Button_Delete_icon;
            this.button1.Location = new System.Drawing.Point(374, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 30);
            this.button1.TabIndex = 27;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel7.Location = new System.Drawing.Point(72, 280);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(259, 1);
            this.panel7.TabIndex = 36;
            // 
            // txtQte
            // 
            this.txtQte.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.txtQte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtQte.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtQte.Location = new System.Drawing.Point(74, 252);
            this.txtQte.Multiline = true;
            this.txtQte.Name = "txtQte";
            this.txtQte.Size = new System.Drawing.Size(245, 29);
            this.txtQte.TabIndex = 33;
            this.txtQte.Text = "Quantité";
            this.txtQte.TextChanged += new System.EventHandler(this.txtQte_TextChanged);
            this.txtQte.Enter += new System.EventHandler(this.txtQte_Enter);
            this.txtQte.Validated += new System.EventHandler(this.txtQte_Validated);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel5.Location = new System.Drawing.Point(72, 228);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(259, 1);
            this.panel5.TabIndex = 37;
            // 
            // txtRef
            // 
            this.txtRef.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.txtRef.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRef.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRef.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtRef.Location = new System.Drawing.Point(74, 200);
            this.txtRef.Multiline = true;
            this.txtRef.Name = "txtRef";
            this.txtRef.Size = new System.Drawing.Size(245, 29);
            this.txtRef.TabIndex = 34;
            this.txtRef.Text = "Referance De Produit";
            this.txtRef.TextChanged += new System.EventHandler(this.txtRef_TextChanged);
            this.txtRef.Enter += new System.EventHandler(this.txtRef_Enter);
            this.txtRef.Validated += new System.EventHandler(this.txtRef_Validated);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel6.Location = new System.Drawing.Point(72, 176);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(259, 1);
            this.panel6.TabIndex = 38;
            // 
            // txtChifa
            // 
            this.txtChifa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.txtChifa.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtChifa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChifa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtChifa.Location = new System.Drawing.Point(74, 148);
            this.txtChifa.Multiline = true;
            this.txtChifa.Name = "txtChifa";
            this.txtChifa.Size = new System.Drawing.Size(245, 29);
            this.txtChifa.TabIndex = 35;
            this.txtChifa.Text = "N° Chifa De Client";
            this.txtChifa.TextChanged += new System.EventHandler(this.txtChifa_TextChanged);
            this.txtChifa.Enter += new System.EventHandler(this.txtChifa_Enter);
            this.txtChifa.Validated += new System.EventHandler(this.txtChifa_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FloralWhite;
            this.label1.Location = new System.Drawing.Point(65, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 37);
            this.label1.TabIndex = 39;
            this.label1.Text = "Achat un produit";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnConx
            // 
            this.btnConx.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btnConx.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnConx.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConx.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConx.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConx.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConx.Location = new System.Drawing.Point(45, 314);
            this.btnConx.Name = "btnConx";
            this.btnConx.Size = new System.Drawing.Size(316, 37);
            this.btnConx.TabIndex = 40;
            this.btnConx.Text = "Achat";
            this.btnConx.UseVisualStyleBackColor = true;
            this.btnConx.Click += new System.EventHandler(this.btnConx_Click);
            // 
            // Achet_Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(414, 383);
            this.Controls.Add(this.btnConx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.txtQte);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtRef);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txtChifa);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Achet_Frm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Achet_Frm";
            this.Load += new System.EventHandler(this.Achet_Frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtQte;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtChifa;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnConx;
    }
}