using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_Rental_2Assignment
{
    public partial class Form1 : Form
    {
        // please change connection string here only once required 
        String conStr = "Data Source=DESKTOP-G2UGPMF\\SQLEXPRESS;Initial Catalog=MovieBookngSystem;Integrated Security=True";
        int customerID = 0,videoID=0,RentID=0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Rentals_Click(object sender, EventArgs e)
        {

        }

        private void customer_add_Click(object sender, EventArgs e)
        {
            try {
                using (SqlConnection conn = new SqlConnection())
                {
                    // Create the connectionString  
                    // Trusted_Connection is used to denote the connection uses Windows Authentication  
                    conn.ConnectionString = conStr;
                    conn.Open();
                    String sql = "insert into customer(Name,Age,Contact) values('" + nameofcustomer.Text + "','" + age.Text + "','" + contact.Text + "')";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.ExecuteNonQuery();
                    command.Dispose();
                    conn.Close();
                    MessageBox.Show(" ExecuteNonQuery of insert command is done !!");
                    
                    conn.Close();
                    nameofcustomer.Text = "";
                    age.Text = "";
                    contact.Text = "";
                    customerID = 0;
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Must need to check again");
            }
            

        }

        private void nameofcustomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void customer_del_Click(object sender, EventArgs e)
        {
            //try
            //{
                using (SqlConnection conn = new SqlConnection())
                {
                    // Create the connectionString  
                    // Trusted_Connection is used to denote the connection uses Windows Authentication  
                    conn.ConnectionString = conStr;
                    conn.Open();
                    String sql = "delete from customer where CustomerID=" + customerID + "";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.ExecuteNonQuery();
                    command.Dispose();
                    conn.Close();
                    MessageBox.Show(" Execution of the deletion is done !!");
                    
                    conn.Close();
                    nameofcustomer.Text = "";
                    age.Text = "";
                    contact.Text = "";
                    customerID = 0;
            }
            /*}
            catch (Exception ex)
            {
                MessageBox.Show("Must need to check again");
            }*/
        }

        private void customer_update_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    // Create the connectionString  
                    // Trusted_Connection is used to denote the connection uses Windows Authentication  
                    conn.ConnectionString = conStr;
                    conn.Open();
                    String sql = "update customer set Name='"+nameofcustomer.Text+"',Age='"+age.Text+"',Contact='"+contact.Text+"' where CustomerID="+ customerID + "";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.ExecuteNonQuery();
                    command.Dispose();
                    conn.Close();
                    MessageBox.Show(" Execution of the updation is done !!");
                    
                    conn.Close();

                    nameofcustomer.Text = "";
                    age.Text = "";
                    contact.Text = "";
                    customerID = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Must need to check again");
            }
        }

        // adding movies

        private void add_mov_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    // Create the connectionString  
                    // Trusted_Connection is used to denote the connection uses Windows Authentication  
                    conn.ConnectionString = conStr;
                    conn.Open();
                    String sql = "insert into Movie(Name,Point,Year,Copies,Cost,Genre) values('" + mov_name.Text + "','" + points.Text + "','" + Yearpermov.Text + "','"+text_copies.Text+"','"+Costs.Text+"','"+genres.Text+"')";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.ExecuteNonQuery();
                    command.Dispose();
                    conn.Close();
                    MessageBox.Show(" Execution of the Insertion  is done !!");

                    conn.Close();
                    mov_name.Text = "";
                    points.Text = "";
                    Yearpermov.Text = "";
                    Cost.Text = "";
                    text_copies.Text = "";
                    Costs.Text = "";
                    genres.Text = "";

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Must need to check again");
            }

        }

        // showing delete movies

        private void delete_movon_rentals_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    // Create the connectionString  
                    // Trusted_Connection is used to denote the connection uses Windows Authentication  
                    conn.ConnectionString = conStr;
                    conn.Open();
                    String sql = "delete from booking  where BookingID=" + RentID + "";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.ExecuteNonQuery();
                    command.Dispose();
                    conn.Close();
                    MessageBox.Show(" Execution of the delete command is done !!");

                    conn.Close();

                    videoID = 0;
                    mov_name.Text = "";
                    points.Text = "";
                    Yearpermov.Text = "";
                    Cost.Text = "";
                    text_copies.Text = "";
                    Costs.Text = "";
                    genres.Text = "";

                    customerID = 0;
                    nameofcustomer.Text = "";
                    age.Text = "";
                    contact.Text = "";
                    rental_cus_name.Text = "";
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Must need to check again");
            }
        }

        // to uodate movie

        private void mov_update_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    // Create the connectionString  
                    // Trusted_Connection is used to denote the connection uses Windows Authentication  
                    conn.ConnectionString = conStr;
                    conn.Open();
                    String sql = "update Movie set Name='"+mov_name.Text+"',Point='"+points.Text+"',Year='"+Yearpermov.Text+"',Copies='"+text_copies.Text+"',Cost='"+Costs.Text+"',Genre='"+genres.Text+"' where MovieID="+videoID+"";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.ExecuteNonQuery();
                    command.Dispose();
                    conn.Close();
                    MessageBox.Show(" Execution of the Updation   is done !!");

                    conn.Close();
                    mov_name.Text = "";
                    points.Text = "";
                    Yearpermov.Text = "";
                    
                    text_copies.Text = "";
                    Costs.Text = "";
                    genres.Text = "";
                    videoID = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Must need to check again");
            }
        }


         // to delete movie

        private void mov_delete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection())
                {
                    // Create the connectionString  
                    // Trusted_Connection is used to denote the connection uses Windows Authentication  
                    conn.ConnectionString = conStr;
                    conn.Open();
                    String sql = "delete Movie where MovieID=" + videoID + "";
                    SqlCommand command = new SqlCommand(sql, conn);
                    command.ExecuteNonQuery();
                    command.Dispose();
                    conn.Close();
                    MessageBox.Show(" Execution of the Deletion   is done !!");

                    conn.Close();
                    videoID = 0; mov_name.Text = "";
                    points.Text = "";
                    Yearpermov.Text = "";
            
                    text_copies.Text = "";
                    Costs.Text = "";
                    genres.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Must need to check again");
            }
        }

         // showing movies

        private void choose_movies_CheckedChanged(object sender, EventArgs e)
        {
            if (choose_movies.Checked == true)
            {
                using (SqlConnection conn = new SqlConnection())
                {


                    DataTable tbl = new DataTable();
                    conn.ConnectionString = conStr;
                    conn.Open();
                    String qry = "select * from Movie";
                    SqlCommand sqlcmd = new SqlCommand(qry, conn);

                    SqlDataReader DReader = sqlcmd.ExecuteReader();

                    tbl.Load(DReader);
                    dataGridView1.DataSource = tbl;
                    conn.Close();
                }
            }
        }
        // data grid view showing data

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (choose_movies.Checked==true) {
                mov_rental_name.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
                videoID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                mov_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                points.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                Yearpermov.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                text_copies.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                Costs.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                genres.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

            }
            if (choose_customers.Checked==true) {
                rental_cus_name.Text= dataGridView1.CurrentRow.Cells[1].Value.ToString();
                customerID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                nameofcustomer.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                age.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                contact.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }

            if (Issued_movies.Checked==true) {
                RentID = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                rental_cus_name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                mov_rental_name.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                BookingDate.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            }

            choose_customers.Checked = false;
            choose_movies.Checked = false;
            Issued_movies.Checked = false;
        }

        // showing custoers on grid

        private void choose_customers_CheckedChanged(object sender, EventArgs e)
        {
            if (choose_customers.Checked == true)
            {
                using (SqlConnection conn = new SqlConnection())
                {


                    DataTable tbl = new DataTable();
                    conn.ConnectionString = conStr;
                    conn.Open();
                    String qry = "select * from customer";
                    SqlCommand sqlcmd = new SqlCommand(qry, conn);

                    SqlDataReader DReader = sqlcmd.ExecuteReader();

                    tbl.Load(DReader);
                    dataGridView1.DataSource = tbl;
                    conn.Close();
                }
            }
        }

        // showing Issue Movies

        private void Issued_movies_CheckedChanged(object sender, EventArgs e)
        {
            if (Issued_movies.Checked == true)
            {
                using (SqlConnection conn = new SqlConnection())
                {


                    DataTable tbl = new DataTable();
                    conn.ConnectionString = conStr;
                    conn.Open();
                    String qry = "select * from Booking";
                    SqlCommand sqlcmd = new SqlCommand(qry, conn);

                    SqlDataReader DReader = sqlcmd.ExecuteReader();

                    tbl.Load(DReader);
                    dataGridView1.DataSource =tbl;
                    conn.Close();
                }
            }
        }

        private void Yearpermov_TextChanged(object sender, EventArgs e)
        {
            try
            {

                DateTime dateNow = DateTime.Now;

                int Currentyear = dateNow.Year;

                int diffYear = Currentyear - Convert.ToInt32(Yearpermov.Text);
                int Vcost = 0;
                // MessageBox.Show(diff.ToString());
                if (diffYear >= 5)
                {
                    Vcost = 2;
                }
                if (diffYear >= 0 && diffYear < 5)
                {
                    Vcost = 5;
                }
                Costs.Text = Vcost.ToString();
            }
            catch (Exception ex) {
                    
            }
        }

        // show popular movie

        private void popular_movie_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {


                DataTable tbl = new DataTable();
                conn.ConnectionString = conStr;
                conn.Open();
                String qry = "select * from Movie";
                SqlCommand sqlcmd = new SqlCommand(qry, conn);

                SqlDataReader DReader = sqlcmd.ExecuteReader();

                tbl.Load(DReader);
                int x = 0, count = 0;
                String cstName = "";
                for (x = 0; x < tbl.Rows.Count; x++)
                {
                    String qry1 = "select * from Booking where VideoName='" + tbl.Rows[x]["Name"].ToString() + "'";
                    SqlCommand sqlcmd1 = new SqlCommand(qry1, conn);

                    SqlDataReader DReader1 = sqlcmd.ExecuteReader();
                    DataTable tbl1 = new DataTable();
                    tbl1.Load(DReader1);

                    if (tbl1.Rows.Count > count)
                    {
                        cstName = tbl1.Rows[x]["Name"].ToString();

                        count = tbl1.Rows.Count;
                      
                    }
                }
                conn.Close();
                MessageBox.Show("Best Movie is " + cstName);
            }



        }

        // to show popular customer

        private void popular_customer_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection())
            {


                DataTable tbl = new DataTable();
                conn.ConnectionString = conStr;
                conn.Open();
                String qry = "select * from customer";
                SqlCommand sqlcmd = new SqlCommand(qry, conn);

                SqlDataReader DReader = sqlcmd.ExecuteReader();

                tbl.Load(DReader);
                int x = 0, count = 0;
                String cstName = "";
                for (x = 0; x < tbl.Rows.Count - 1; x++)
                {
                    String qry1 = "select * from Booking where CustomerName='" + tbl.Rows[x]["Name"].ToString() + "'";
                    SqlCommand sqlcmd1 = new SqlCommand(qry, conn);

                    SqlDataReader DReader1 = sqlcmd.ExecuteReader();
                    DataTable tbl1 = new DataTable();
                    tbl1.Load(DReader1);

                    if (tbl1.Rows.Count > count)
                    {
                        cstName = tbl1.Rows[x]["Name"].ToString();
                        count = tbl1.Rows.Count;
                    }
                }
                conn.Close();
                MessageBox.Show("Best Customer is " + cstName);
            }
            
        }
        public void testInsert(String nm,String age,String contact) {
            using (SqlConnection conn = new SqlConnection())
            {
                // Create the connectionString  
                // Trusted_Connection is used to denote the connection uses Windows Authentication  
                conn.ConnectionString = conStr;
                conn.Open();
                String sql = "insert into customer(Name,Age,Contact) values('"+nm+"','" + age + "','" + contact + "')";
                SqlCommand command = new SqlCommand(sql, conn);
                command.ExecuteNonQuery();
                command.Dispose();
                conn.Close();
                MessageBox.Show(" ExecuteNonQuery of insert command is done !!");

                conn.Close();
                nameofcustomer.Text = "";
               
                customerID = 0;
            }
        }

        // issue button coding
        private void now_issue_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!rental_cus_name.Text.Equals("") && mov_rental_name.Text.Equals(""))
                {




                    using (SqlConnection conn = new SqlConnection())
                    {
                        // Create the connectionString  
                        // Trusted_Connection is used to denote the connection uses Windows Authentication  
                        conn.ConnectionString = conStr;
                        conn.Open();
                        String sql = "insert into booking(CustomerName,VideoName,BookingDate,ReturnDate) values('" + rental_cus_name.Text + "','" + mov_rental_name.Text + "','" + BookingDate.Text + "','booked')";
                        SqlCommand command = new SqlCommand(sql, conn);
                        command.ExecuteNonQuery();
                        command.Dispose();
                        conn.Close();
                        MessageBox.Show(" Execution of the updation is done !!");

                        conn.Close();

                        videoID = 0;

                        mov_rental_name.Text = "";
                        mov_name.Text = "";
                        points.Text = "";
                        Yearpermov.Text = "";
                        text_copies.Text = "";
                        Costs.Text = "";
                        genres.Text = "";

                        customerID = 0;
                        nameofcustomer.Text = "";
                        age.Text = "";
                        contact.Text = "";
                        rental_cus_name.Text = "";

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Must need to check again");
            }

        }

        //return button coding
        private void return_btn_Click(object sender, EventArgs e)
        {
            try
            {

                if (!rental_cus_name.Text.Equals("") && mov_rental_name.Text.Equals(""))
                {



                    using (SqlConnection conn = new SqlConnection())
                    {
                        // Create the connectionString  
                        // Trusted_Connection is used to denote the connection uses Windows Authentication  
                        conn.ConnectionString = conStr;
                        conn.Open();

                        String qry = "select * from Movie where Name='" + mov_rental_name.Text + "'";
                        SqlCommand sqlcmd = new SqlCommand(qry, conn);

                        SqlDataReader DReader = sqlcmd.ExecuteReader();
                        DataTable tbl = new DataTable();

                        tbl.Load(DReader);
                        int charges = Convert.ToInt32(tbl.Rows[0]["cost"].ToString());

                        DateTime current_date = DateTime.Now;

                        //convert the old date from string to Date fromat
                        DateTime prev_date = Convert.ToDateTime(BookingDate.Text);


                        //get the difference in the days fromat
                        String Daysdiff = (current_date - prev_date).TotalDays.ToString();


                        // calculate the round off value 
                        Double DaysInterval = Math.Round(Convert.ToDouble(Daysdiff));

                        if (DaysInterval < 1)
                        {
                            DaysInterval = 1;
                        }
                        int total = charges * Convert.ToInt32(DaysInterval);




                        String sql = "update Booking set CustomerName='" + rental_cus_name.Text + "',VideoName='" + mov_rental_name.Text + "',BookingDate='" + BookingDate.Text + "',ReturnDate='" + returnDate.Text + "' where BookingID=" + RentID + "";
                        SqlCommand command = new SqlCommand(sql, conn);
                        command.ExecuteNonQuery();
                        command.Dispose();
                        conn.Close();
                        MessageBox.Show(" Execution of the return command is done !! and Bill is ==$" + total);

                        conn.Close();
                        videoID = 0;
                        mov_rental_name.Text = "";
                        mov_name.Text = "";
                        points.Text = "";
                        Yearpermov.Text = "";

                        genres.Text = "";
                        text_copies.Text = "";
                        Costs.Text = "";

                        customerID = 0;
                        nameofcustomer.Text = "";
                        age.Text = "";
                        contact.Text = "";
                        rental_cus_name.Text = "";


                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Must need to check again");
            }
        }
    }
}
