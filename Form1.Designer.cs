namespace BankDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            c_id = new TextBox();
            fname = new TextBox();
            lname = new TextBox();
            email = new TextBox();
            phone = new TextBox();
            streetNo = new TextBox();
            streetName = new TextBox();
            city = new TextBox();
            province = new TextBox();
            panel1 = new Panel();
            searchbox = new TextBox();
            postalCode = new TextBox();
            dob = new DateTimePicker();
            insert = new Button();
            update = new Button();
            del = new Button();
            panel2 = new Panel();
            Transfer = new Button();
            Find = new Button();
            clrForm = new Button();
            panel3 = new Panel();
            label1 = new Label();
            balbox = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // c_id
            // 
            c_id.Location = new Point(16, 14);
            c_id.Name = "c_id";
            c_id.PlaceholderText = "CurrentID";
            c_id.Size = new Size(118, 23);
            c_id.TabIndex = 0;
            c_id.Text = "0";
            c_id.TextAlign = HorizontalAlignment.Center;
            c_id.TextChanged += c_id_TextChanged;
            // 
            // fname
            // 
            fname.Location = new Point(16, 43);
            fname.Name = "fname";
            fname.PlaceholderText = "fname";
            fname.Size = new Size(118, 23);
            fname.TabIndex = 1;
            fname.Text = "Jack";
            fname.TextAlign = HorizontalAlignment.Center;
            fname.TextChanged += fname_TextChanged;
            // 
            // lname
            // 
            lname.Location = new Point(140, 43);
            lname.Name = "lname";
            lname.PlaceholderText = "lname";
            lname.Size = new Size(129, 23);
            lname.TabIndex = 2;
            lname.Text = "Spratt";
            lname.TextAlign = HorizontalAlignment.Center;
            lname.TextChanged += lname_TextChanged;
            // 
            // email
            // 
            email.Location = new Point(16, 72);
            email.Name = "email";
            email.PlaceholderText = "email";
            email.Size = new Size(118, 23);
            email.TabIndex = 3;
            email.Text = "spratt@nowhere.org";
            email.TextAlign = HorizontalAlignment.Center;
            email.TextChanged += email_TextChanged;
            // 
            // phone
            // 
            phone.Location = new Point(140, 72);
            phone.Name = "phone";
            phone.PlaceholderText = "phone";
            phone.Size = new Size(129, 23);
            phone.TabIndex = 4;
            phone.Text = "6049593679";
            phone.TextAlign = HorizontalAlignment.Center;
            phone.TextChanged += phone_TextChanged;
            // 
            // streetNo
            // 
            streetNo.Location = new Point(16, 101);
            streetNo.Name = "streetNo";
            streetNo.PlaceholderText = "streetNo";
            streetNo.Size = new Size(118, 23);
            streetNo.TabIndex = 5;
            streetNo.Text = "759";
            streetNo.TextAlign = HorizontalAlignment.Center;
            streetNo.TextChanged += streetNo_TextChanged;
            // 
            // streetName
            // 
            streetName.Location = new Point(140, 101);
            streetName.Name = "streetName";
            streetName.PlaceholderText = "streetName";
            streetName.Size = new Size(129, 23);
            streetName.TabIndex = 6;
            streetName.Text = "Disco rd";
            streetName.TextAlign = HorizontalAlignment.Center;
            streetName.TextChanged += streetName_TextChanged;
            // 
            // city
            // 
            city.Location = new Point(16, 130);
            city.Name = "city";
            city.PlaceholderText = "city";
            city.Size = new Size(118, 23);
            city.TabIndex = 7;
            city.Text = "Impossible";
            city.TextAlign = HorizontalAlignment.Center;
            city.TextChanged += city_TextChanged;
            // 
            // province
            // 
            province.Location = new Point(140, 130);
            province.Name = "province";
            province.PlaceholderText = "province";
            province.Size = new Size(129, 23);
            province.TabIndex = 8;
            province.Text = "BC";
            province.TextAlign = HorizontalAlignment.Center;
            province.TextChanged += province_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(searchbox);
            panel1.Controls.Add(postalCode);
            panel1.Controls.Add(dob);
            panel1.Controls.Add(c_id);
            panel1.Controls.Add(province);
            panel1.Controls.Add(fname);
            panel1.Controls.Add(city);
            panel1.Controls.Add(lname);
            panel1.Controls.Add(streetName);
            panel1.Controls.Add(email);
            panel1.Controls.Add(streetNo);
            panel1.Controls.Add(phone);
            panel1.Location = new Point(22, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(293, 199);
            panel1.TabIndex = 9;
            // 
            // searchbox
            // 
            searchbox.Location = new Point(140, 159);
            searchbox.Name = "searchbox";
            searchbox.PlaceholderText = "search";
            searchbox.Size = new Size(129, 23);
            searchbox.TabIndex = 11;
            searchbox.TextAlign = HorizontalAlignment.Center;
            // 
            // postalCode
            // 
            postalCode.Location = new Point(18, 157);
            postalCode.Name = "postalCode";
            postalCode.PlaceholderText = "postalCode";
            postalCode.Size = new Size(116, 23);
            postalCode.TabIndex = 10;
            postalCode.Text = "V4V1N9";
            postalCode.TextAlign = HorizontalAlignment.Center;
            postalCode.TextChanged += postalCode_TextChanged;
            // 
            // dob
            // 
            dob.Location = new Point(140, 11);
            dob.Name = "dob";
            dob.Size = new Size(129, 23);
            dob.TabIndex = 9;
            dob.ValueChanged += dob_ValueChanged;
            // 
            // insert
            // 
            insert.Location = new Point(20, 14);
            insert.Name = "insert";
            insert.Size = new Size(75, 36);
            insert.TabIndex = 10;
            insert.Text = "INSERT";
            insert.UseVisualStyleBackColor = true;
            insert.Click += insert_Click;
            // 
            // update
            // 
            update.Location = new Point(20, 64);
            update.Name = "update";
            update.Size = new Size(75, 36);
            update.TabIndex = 11;
            update.Text = "UPDATE";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // del
            // 
            del.Location = new Point(110, 14);
            del.Name = "del";
            del.Size = new Size(75, 36);
            del.TabIndex = 12;
            del.Text = "DELETE";
            del.UseVisualStyleBackColor = true;
            del.Click += del_Click_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(Transfer);
            panel2.Controls.Add(Find);
            panel2.Controls.Add(clrForm);
            panel2.Controls.Add(insert);
            panel2.Controls.Add(update);
            panel2.Controls.Add(del);
            panel2.Location = new Point(331, 21);
            panel2.Name = "panel2";
            panel2.Size = new Size(207, 153);
            panel2.TabIndex = 13;
            // 
            // Transfer
            // 
            Transfer.Location = new Point(110, 106);
            Transfer.Name = "Transfer";
            Transfer.Size = new Size(75, 36);
            Transfer.TabIndex = 15;
            Transfer.Text = "Transfer";
            Transfer.UseVisualStyleBackColor = true;
            // 
            // Find
            // 
            Find.Location = new Point(20, 106);
            Find.Name = "Find";
            Find.Size = new Size(75, 36);
            Find.TabIndex = 14;
            Find.Text = "Find";
            Find.UseVisualStyleBackColor = true;
            Find.Click += Find_Click;
            // 
            // clrForm
            // 
            clrForm.Location = new Point(110, 64);
            clrForm.Name = "clrForm";
            clrForm.Size = new Size(75, 36);
            clrForm.TabIndex = 13;
            clrForm.Text = "Clear";
            clrForm.UseVisualStyleBackColor = true;
            clrForm.Click += clrForm_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Controls.Add(balbox);
            panel3.Location = new Point(22, 226);
            panel3.Name = "panel3";
            panel3.Size = new Size(293, 56);
            panel3.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 20);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 3;
            label1.Text = "Balance";
            // 
            // balbox
            // 
            balbox.Location = new Point(100, 17);
            balbox.Name = "balbox";
            balbox.PlaceholderText = "chequing";
            balbox.Size = new Size(169, 23);
            balbox.TabIndex = 0;
            balbox.Text = "50000";
            balbox.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(615, 291);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "BankDemo";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox c_id;
        private TextBox fname;
        private TextBox lname;
        private TextBox email;
        private TextBox phone;
        private TextBox streetNo;
        private TextBox streetName;
        private TextBox city;
        private TextBox province;
        private Panel panel1;
        private DateTimePicker dob;
        private Button insert;
        private Button update;
        private Button del;
        private Panel panel2;
        private TextBox searchbox;
        private TextBox postalCode;
        private Button clrForm;
        private Button Find;
        private Panel panel3;
        private TextBox invbox;
        private TextBox savbox;
        private TextBox balbox;
        private Button Transfer;
        private Label label1;
    }
}