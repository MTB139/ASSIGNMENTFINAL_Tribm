namespace assignmentfinal
{
    partial class Form3
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
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox6 = new TextBox();
            txtcustomername = new TextBox();
            txttypeofcustomer = new TextBox();
            txtnumberofperson = new TextBox();
            txtlast = new TextBox();
            txtthis = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("MV Boli", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(197, 9);
            label1.Name = "label1";
            label1.Size = new Size(374, 95);
            label1.TabIndex = 0;
            label1.Text = "THE BILL";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.InactiveCaption;
            textBox1.Font = new Font("MV Boli", 16F, FontStyle.Bold | FontStyle.Italic);
            textBox1.Location = new Point(70, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(303, 59);
            textBox1.TabIndex = 1;
            textBox1.Text = "Customer Name";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.InactiveCaption;
            textBox2.Font = new Font("MV Boli", 16F, FontStyle.Bold | FontStyle.Italic);
            textBox2.Location = new Point(70, 172);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(303, 59);
            textBox2.TabIndex = 1;
            textBox2.Text = "Type Of Customer";
            // 
            // textBox3
            // 
            textBox3.BackColor = SystemColors.InactiveCaption;
            textBox3.Font = new Font("MV Boli", 16F, FontStyle.Bold | FontStyle.Italic);
            textBox3.Location = new Point(70, 233);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(303, 59);
            textBox3.TabIndex = 1;
            textBox3.Text = "Number Of Person";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.BackColor = SystemColors.InactiveCaption;
            textBox4.Font = new Font("MV Boli", 16F, FontStyle.Bold | FontStyle.Italic);
            textBox4.Location = new Point(69, 298);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(303, 59);
            textBox4.TabIndex = 1;
            textBox4.Text = "Last Month Water";
            // 
            // textBox6
            // 
            textBox6.BackColor = SystemColors.InactiveCaption;
            textBox6.Font = new Font("MV Boli", 16F, FontStyle.Bold | FontStyle.Italic);
            textBox6.Location = new Point(70, 357);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(303, 59);
            textBox6.TabIndex = 1;
            textBox6.Text = "This Month Water";
            // 
            // txtcustomername
            // 
            txtcustomername.BackColor = SystemColors.InactiveCaption;
            txtcustomername.Location = new Point(460, 125);
            txtcustomername.Name = "txtcustomername";
            txtcustomername.Size = new Size(150, 31);
            txtcustomername.TabIndex = 1;
            // 
            // txttypeofcustomer
            // 
            txttypeofcustomer.BackColor = SystemColors.InactiveCaption;
            txttypeofcustomer.Location = new Point(460, 185);
            txttypeofcustomer.Name = "txttypeofcustomer";
            txttypeofcustomer.Size = new Size(150, 31);
            txttypeofcustomer.TabIndex = 1;
            // 
            // txtnumberofperson
            // 
            txtnumberofperson.BackColor = SystemColors.InactiveCaption;
            txtnumberofperson.Location = new Point(460, 246);
            txtnumberofperson.Name = "txtnumberofperson";
            txtnumberofperson.Size = new Size(150, 31);
            txtnumberofperson.TabIndex = 1;
            // 
            // txtlast
            // 
            txtlast.BackColor = SystemColors.InactiveCaption;
            txtlast.Location = new Point(459, 311);
            txtlast.Name = "txtlast";
            txtlast.Size = new Size(150, 31);
            txtlast.TabIndex = 1;
            // 
            // txtthis
            // 
            txtthis.BackColor = SystemColors.InactiveCaption;
            txtthis.Location = new Point(460, 370);
            txtthis.Name = "txtthis";
            txtthis.Size = new Size(150, 31);
            txtthis.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Location = new Point(676, 404);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "OK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtthis);
            Controls.Add(textBox6);
            Controls.Add(txtlast);
            Controls.Add(txtnumberofperson);
            Controls.Add(textBox4);
            Controls.Add(txttypeofcustomer);
            Controls.Add(textBox3);
            Controls.Add(txtcustomername);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox6;
        private TextBox txtcustomername;
        private TextBox txttypeofcustomer;
        private TextBox txtnumberofperson;
        private TextBox txtlast;
        private TextBox txtthis;
        private Button button1;
    }
}