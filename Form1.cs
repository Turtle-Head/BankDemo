using Amazon.DynamoDBv2;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using MySqlX.XDevAPI;
using NHibernate.Mapping;
using System.Data.SqlClient;
using System.Reflection.Metadata.Ecma335;

namespace BankDemo
{
    public partial class Form1 : Form
    {
        SqlConnection connobj;

        int CurrentID = 0;
        string datOfBirth;
        string firstname;
        string lastname;
        string eml;
        string phone_home;
        string streetNumber;
        string streetNam;
        string cities;
        string prov;
        string postal;
        int balanc;

        private object connobj2;

        public Form1()
        {
            InitializeComponent();
            datOfBirth = "";
            firstname = "";
            lastname = "";
            eml = "";
            phone_home = "";
            streetNumber = "";
            streetNam = "";
            cities = "";
            prov = "";
            postal = "";
            balanc = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connobj = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Stark\OneDrive\Documents\BankDemo\BankDemo\Database1.mdf;Integrated Security=True");
            connobj.Open();
            SqlCommand command = new SqlCommand("Select * from Client; ", connobj);
        }

        private bool CheckFormForValues()
        {
            if ((fname.Text == "") || (lname.Text == "") || (email.Text == "") || (phone.Text == "") || (streetNo.Text == "") || (streetName.Text == "") || (city.Text == "") || (province.Text == "") || (postalCode.Text == ""))
            {
                MessageBox.Show("Please fill out form");
                return (false);
            }
            else
            {
                datOfBirth = Convert.ToString(dob.Text);
                firstname = Convert.ToString(fname.Text);
                lastname = Convert.ToString(lname.Text);
                eml = Convert.ToString(email.Text);
                phone_home = Convert.ToString(phone.Text);
                streetNumber = Convert.ToString(streetNo.Text);
                streetNam = Convert.ToString(streetName.Text);
                cities = Convert.ToString(city.Text);
                prov = Convert.ToString(province.Text);
                postal = Convert.ToString(postalCode.Text);
                balanc = Convert.ToInt32(balbox.Text);
                return (true);
            }

        }
        private void insert_Click(object sender, EventArgs e)
        {
            // Check to make sure the form is filled out >> Semd Message if missing data
            if (CheckFormForValues() == false)
            {
                MessageBox.Show("Please fill out form");
                return;
            }
            else if (CheckFormForValues() == true)
            {


                string sql = $"INSERT INTO Client ( dob, fname, lname, email, phone, streetNo, streetName, city, province, postalCode, balance) Values ('{datOfBirth}','{firstname}','{lastname}','{eml}','{phone_home}','{streetNumber}','{streetNam}','{cities}','{prov}','{postal}','{balanc}')";
                try
                {
                    SqlCommand SqlCommand;
                    using (SqlCommand = new SqlCommand(sql, connobj)) ;
                    int addedRow = SqlCommand.ExecuteNonQuery();
                    if (addedRow > 0)
                    {
                        MessageBox.Show("Record Added Successfully");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Insert Failed: " + ex.Message);
                }
            }
            // ------------This is a requierment--------------//
            //You should have a connection to the data base on your form load
            // Using SqlCommand and SqlDataReader do the following

            //make sure all of the textboxes are filled in
            //search if the record already exists (use sqlCommand to make the query, SqlDataReader go through the data)
            //    if it doesn't exist proceed to adding the record 
            //    if it does then tell the user it already exists 
            //instert the data into the database    (use sqlCommand to insert data and a function that is part of the sqlCommand called .ExecuteNonQuery())
            //Let the user know it was successful
            //----------Optional--------//
            //add another form that connects to accounts so you can add a chequing account for the user
        }

        private void update_Click(object sender, EventArgs e)
        {

            if (CheckFormForValues() == true)
            {
                string UpdateClient = $"UPDATE Client Set dob = '{datOfBirth}', fName = '{firstname}', lName = '{lastname}',  email = '{eml}', phone = '{phone_home}', streetNo = '{streetNumber}', streetName = '{streetNam}', city = '{cities}', province = '{prov}', postalCode ='{postal}', balance =  '{balanc}' WHERE ClientID = '{CurrentID}'; ";
                try
                {
                    SqlCommand command = new SqlCommand(UpdateClient, connobj);
                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Record Updated");
                    }
                    else MessageBox.Show("Record Update Failed");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            //-------- this is a requierment ---//
            //You should have a connection to the data base on your form load
            // Using SqlCommand and SqlDataReader do the following

            //make sure all of the textboxes are filled in
            //if not ask them to fill it in
            //Use an sql statement to update the data (use sqlCommand to Update data and a function that is part of the sqlCommand called .ExecuteNonQuery())
            //Let the user know it was successful   

        }

        private void Find_Click(object sender, EventArgs e)//Required step 4
        {
            if (c_id.Text == "")
            {
                MessageBox.Show("Please enter Client ID...");
                return;
            }
            else
            {
                try
                {
                    SqlCommand cmd = new SqlCommand("Select * FROM Client WHERE ClientID=@CurrentID;", connobj);
                    cmd.Parameters.AddWithValue("@CurrentID", int.Parse(c_id.Text));
                    SqlDataReader da = cmd.ExecuteReader();
                    while (da.Read())
                    {
                        c_id.Text = da["ClientID"].ToString();
                        fname.Text = da["fname"].ToString();
                        lname.Text = da["lname"].ToString();
                        email.Text = da["email"].ToString();
                        phone.Text = da["phone"].ToString();
                        streetNo.Text = da["streetNo"].ToString();
                        streetName.Text = da["streetName"].ToString();
                        city.Text = da["city"].ToString();
                        province.Text = da["province"].ToString();
                        postalCode.Text = da["postalCode"].ToString();
                        balbox.Text = da["balance"].ToString();

                    }
                    da.Close();
                    
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                

            }
            //-------- this is a requierment ---//
            //if the customer ID is empty, let the user know to fill it in and leave the function
            //Search for the record
            //if found add to the textboxes using DataReader
            //if not found let the user know          


        }
        private void del_Click_1(object sender, EventArgs e)//Required step 5
        {
            DialogResult delete = MessageBox.Show("Do you want to Delete?","Delete",MessageBoxButtons.YesNo);
            if ((CheckFormForValues() == false) && (c_id.Text == "") || (delete == DialogResult.No))
            {
                return;
            }
            
            string query = $"DELETE FROM Client WHERE ClientID = '{c_id.Text}' ";
            SqlCommand command = new SqlCommand(query, connobj);
            int RowAffected = command.ExecuteNonQuery();
            if (RowAffected > 0)
            {
                MessageBox.Show("Record Deleted Successfully");
            }
            else
            {
                MessageBox.Show("Record not deleted");
            }
            //-------- Delete is a requierment ---//
            // ask the user if they are sure they want to 
            //    if they dont want to delete, leave the function
            //    if they do proceed to the next step
            //search for the record
            //if you find it delete it
            //inform the user it had successfuly been deleted
            // clear data form form
        }

        private void Clear_Form()//Required step 6
        {
            //clear all textboxes
            c_id.Clear();
            fname.Clear();
            lname.Clear();
            streetNo.Clear();
            streetName.Clear();
            city.Clear();
            province.Clear();
            postalCode.Clear();
            balbox.Clear();
            email.Clear();
            phone.Clear();
            dob.Refresh();
        }
        private void Previous_Click(object sender, EventArgs e)//Optional
        {

            //search the Database for the first customer that who Has an ID less than the current customer
            //if there is not ID less than the current, let the user know they are at the beginning of the file
            //If you do find the data, Display in the Texboxes   
        }
        private void Read_Click(object sender, EventArgs e)
        {
            //-------- this is not a requierment but can be fun to add to your form ---//
            // show all customers in a new form 
        }


        private void Next_Click(object sender, EventArgs e)//Optional
        {
            //-------- this is a requierment ---//
            //search the Database for the first customer that who Has an ID Greater than the current customer
            //if there is no ID greater than the current, let the user know they are at the end of the file
            //If you do find the data, Display in the Texboxes          


        }
        private void Find_Click_1(object sender, EventArgs e)
        {

        }
        private bool Find_Data(string sql = "SELECT * from Client")//Optional, you are welcome to do everthing in the button fuction and then remove duplicated code after
        {
            //-------- this function was made to prevent duplication of code-----// this is not a requierment
            // use SqlCommand
            // use data reader to find search for data
            //read data from data readerand output to textboxes
            //SqlCommand cmd = //dont know what to do with you yet stay put so I can change you
            return true;
        }

        private void Get_Accounts_Click(object sender, EventArgs e)
        {

            //-------- this is not a requierment but can be fun to add to your form ---//
            //// You would open a new form to get accounts
        }


        private bool FillVariables()//Required
        {
            //-------- this function was made to prevent duplication of code-----// this is not a requierment
            //fill the variables 
            return false;
        }

        private void clrForm_Click(object sender, EventArgs e)
        {
            Clear_Form();
        }

        private void streetNo_TextChanged(object sender, EventArgs e)
        {
            streetNumber = streetNo.Text;
        }

        private void streetName_TextChanged(object sender, EventArgs e)
        {
            streetNam = streetName.Text;
        }

        private void city_TextChanged(object sender, EventArgs e)
        {
            cities = city.Text;
        }

        private void province_TextChanged(object sender, EventArgs e)
        {
            prov = province.Text;
        }

        private void postalCode_TextChanged(object sender, EventArgs e)
        {
            postal = postalCode.Text;
        }

        private void email_TextChanged(object sender, EventArgs e)
        {
            eml = email.Text;
        }

        private void phone_TextChanged(object sender, EventArgs e)
        {
            phone_home = phone.Text;
        }

        private void fname_TextChanged(object sender, EventArgs e)
        {
            firstname = fname.Text;
        }

        private void lname_TextChanged(object sender, EventArgs e)
        {
            lastname = lname.Text;
        }

        private void dob_ValueChanged(object sender, EventArgs e)
        {
            datOfBirth = dob.Text;
        }

        private void c_id_TextChanged(object sender, EventArgs e)
        {

            CurrentID = c_id.Text == "" ? 0 : Convert.ToInt32(c_id.Text);
        }
    }
}