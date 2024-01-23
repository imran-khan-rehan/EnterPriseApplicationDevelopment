using System;
using System.Collections;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace assignment1
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;

        }

        private void output_Click(object sender, EventArgs e)
        {
            try
            {
                string connections = "Data Source=DESKTOP-K1RP3GB\\SQLEXPRESS;Initial Catalog=mydatabase;Integrated Security=True";
               // SqlConnection con = new SqlConnection(connections);
               //  SqlConnection con=new SqlConnection(connections);
                //con.Open();
                SqlConnection con=new SqlConnection(connections);
                con.Open();
                string query = "SELECT LastName FROM [USERS]";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string firstName = reader["LastName"].ToString();
                            //string lastName = reader["LastName"].ToString();

                            // Do something with the data, for example, add it to a list or display it
                            // For now, let's just print it to the console
                           // Console.WriteLine($"First Name: {firstName}, Last Name: {lastName}");
                           message.Text= firstName;
                        }
                    }
                }
                //ghgh
                ArrayList arrayList = new ArrayList();
                arrayList.Add(firstName.Text);
                arrayList.Add(lastName.Text);
                List<string> list = new List<string>();
                foreach (object item in listOfSubjects.CheckedItems)
                {
                    list.Add(item.ToString());
                }
                if (checkBox.Checked && firstName.Text != "" && lastName.Text != ""&&list.Count>0)
                {
                    
                   // string selectedSubject = subjects.Text.ToString();
                
                  
                        heading.Visible = true;
                    string checkedItemsString ="";
                    foreach(String s in list)
                    {
                        checkedItemsString+=" "+ s;
                    }

                  //  message.Text = $"First Name: {arrayList[0]}      Last Name: {arrayList[1]}        " +
                  //  $"Subject: {checkedItemsString}";
                    
                }
                else
                {
                   // message.Text = "kindly fill all fields with check box";
                }
            }catch(Exception ex)
            {
                message.Text = ex.Message;
            }
           
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listOfSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}