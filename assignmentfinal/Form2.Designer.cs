namespace assignmentfinal
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
            groupboc = new GroupBox();
            cbotypeofcustomer = new ComboBox();
            btnshowbill = new Button();
            btnOK = new Button();
            txtthismonthwater = new TextBox();
            txtlastmonthwater = new TextBox();
            txtnumberofperson = new TextBox();
            txtcustomername = new TextBox();
            label2 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            lv = new ListView();
            label6 = new Label();
            txtSearch = new TextBox();
            groupboc.SuspendLayout();
            SuspendLayout();
            // 
            // groupboc
            // 
            groupboc.Controls.Add(cbotypeofcustomer);
            groupboc.Controls.Add(btnshowbill);
            groupboc.Controls.Add(btnOK);
            groupboc.Controls.Add(txtthismonthwater);
            groupboc.Controls.Add(txtlastmonthwater);
            groupboc.Controls.Add(txtnumberofperson);
            groupboc.Controls.Add(txtcustomername);
            groupboc.Controls.Add(label2);
            groupboc.Controls.Add(label5);
            groupboc.Controls.Add(label4);
            groupboc.Controls.Add(label3);
            groupboc.Controls.Add(label1);
            groupboc.Location = new Point(0, 0);
            groupboc.Name = "groupboc";
            groupboc.Size = new Size(334, 449);
            groupboc.TabIndex = 0;
            groupboc.TabStop = false;
            groupboc.Text = "Form ";
            groupboc.Enter += groupboc_Enter;
            // 
            // cbotypeofcustomer
            // 
            cbotypeofcustomer.FormattingEnabled = true;
            cbotypeofcustomer.Location = new Point(60, 117);
            cbotypeofcustomer.Name = "cbotypeofcustomer";
            cbotypeofcustomer.Size = new Size(203, 33);
            cbotypeofcustomer.TabIndex = 4;
            cbotypeofcustomer.SelectedIndexChanged += cbotypeofcustomer_SelectedIndexChanged;
            // 
            // btnshowbill
            // 
            btnshowbill.BackColor = SystemColors.InactiveCaption;
            btnshowbill.Location = new Point(43, 368);
            btnshowbill.Name = "btnshowbill";
            btnshowbill.Size = new Size(112, 34);
            btnshowbill.TabIndex = 3;
            btnshowbill.Text = "Show Bill";
            btnshowbill.UseVisualStyleBackColor = false;
            btnshowbill.TextChanged += btnshowbill_TextChanged;
            btnshowbill.Click += btnshowbill_Click;
            // 
            // btnOK
            // 
            btnOK.BackColor = SystemColors.InactiveCaption;
            btnOK.Location = new Point(189, 368);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(112, 34);
            btnOK.TabIndex = 2;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = false;
            btnOK.Click += btnOK_Click;
            // 
            // txtthismonthwater
            // 
            txtthismonthwater.Location = new Point(60, 303);
            txtthismonthwater.Name = "txtthismonthwater";
            txtthismonthwater.Size = new Size(203, 31);
            txtthismonthwater.TabIndex = 1;
            // 
            // txtlastmonthwater
            // 
            txtlastmonthwater.Location = new Point(60, 241);
            txtlastmonthwater.Name = "txtlastmonthwater";
            txtlastmonthwater.Size = new Size(203, 31);
            txtlastmonthwater.TabIndex = 1;
            // 
            // txtnumberofperson
            // 
            txtnumberofperson.Enabled = false;
            txtnumberofperson.Location = new Point(60, 179);
            txtnumberofperson.Name = "txtnumberofperson";
            txtnumberofperson.Size = new Size(203, 31);
            txtnumberofperson.TabIndex = 1;
            // 
            // txtcustomername
            // 
            txtcustomername.Location = new Point(60, 55);
            txtcustomername.Name = "txtcustomername";
            txtcustomername.Size = new Size(203, 31);
            txtcustomername.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 27);
            label2.Name = "label2";
            label2.Size = new Size(146, 25);
            label2.TabIndex = 0;
            label2.Text = "Customer Name ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 275);
            label5.Name = "label5";
            label5.Size = new Size(152, 25);
            label5.TabIndex = 0;
            label5.Text = "This Month Water";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 213);
            label4.Name = "label4";
            label4.Size = new Size(152, 25);
            label4.TabIndex = 0;
            label4.Text = "Last Month Water";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 151);
            label3.Name = "label3";
            label3.Size = new Size(165, 25);
            label3.TabIndex = 0;
            label3.Text = "Number  Of Person";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 89);
            label1.Name = "label1";
            label1.Size = new Size(156, 25);
            label1.TabIndex = 0;
            label1.Text = "Type Of Customer";
            label1.Click += label1_Click;
            // 
            // lv
            // 
            lv.BackColor = SystemColors.GradientInactiveCaption;
            lv.Location = new Point(340, 96);
            lv.Name = "lv";
            lv.Size = new Size(539, 353);
            lv.TabIndex = 1;
            lv.UseCompatibleStateImageBehavior = false;
            lv.SelectedIndexChanged += lv_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(340, 55);
            label6.Name = "label6";
            label6.Size = new Size(64, 25);
            label6.TabIndex = 2;
            label6.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(434, 52);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(150, 31);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(891, 450);
            Controls.Add(txtSearch);
            Controls.Add(label6);
            Controls.Add(lv);
            Controls.Add(groupboc);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            groupboc.ResumeLayout(false);
            groupboc.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupboc;
        private Label label1;
        private Label label2;
        private Button btnshowbill;
        private Button btnOK;
        private TextBox txtthismonthwater;
        private TextBox txtlastmonthwater;
        private TextBox txtnumberofperson;
        private TextBox txtcustomername;
        private Label label5;
        private Label label4;
        private Label label3;
        private ComboBox cbotypeofcustomer;
        private ListView lv;
        private Label label6;
        private TextBox txtSearch;
    }
}