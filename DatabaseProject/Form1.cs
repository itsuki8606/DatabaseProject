using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace DatabaseProject
{   
    public partial class Form1 : Form
    {
        String SQL_Text;
        public Form1()
        {
            InitializeComponent();
        }

        private void selectTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectAttribute.Text = null;
            selectAttribute.Items.Clear();
            switch (selectTable.Text)
            {
                case "College":
                    selectAttribute.Items.Add("CollegeID");
                    selectAttribute.Items.Add("Name");
                    selectAttribute.Items.Add("District");
                    break;
                case "Department":
                    selectAttribute.Items.Add("CollegeID");
                    selectAttribute.Items.Add("DepartID");
                    selectAttribute.Items.Add("Name");
                    selectAttribute.Items.Add("Chairman");
                    selectAttribute.Items.Add("TeacherNum");
                    selectAttribute.Items.Add("StudentNum");
                    break;
                case "Teacher":
                    selectAttribute.Items.Add("DepartID");
                    selectAttribute.Items.Add("TeacherID");
                    selectAttribute.Items.Add("Name");
                    selectAttribute.Items.Add("Positionn");
                    selectAttribute.Items.Add("Sex");
                    selectAttribute.Items.Add("Age");
                    selectAttribute.Items.Add("Salary");
                    break;
                case "Student":
                    selectAttribute.Items.Add("DepartID");
                    selectAttribute.Items.Add("StudentID");
                    selectAttribute.Items.Add("Name");
                    selectAttribute.Items.Add("Sex");
                    selectAttribute.Items.Add("Age");
                    break;
                case "Course":
                    selectAttribute.Items.Add("DepartID");
                    selectAttribute.Items.Add("CourseID");
                    selectAttribute.Items.Add("Name");
                    selectAttribute.Items.Add("Instructor");
                    break;
                case "StudentCourse":
                    selectAttribute.Items.Add("SerialID");
                    selectAttribute.Items.Add("StudentID");
                    selectAttribute.Items.Add("CourseID");
                    break;
            }
            SQL_Text = "SELECT * FROM " + selectTable.Text;
            //建立SqlConnection物件cn
            SqlConnection cn = new SqlConnection();
            //設定cn連接Northwind.mdf資料庫檔案
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|CourseDatabase.mdf;" +
                 "Integrated Security=True";
            //建立DataAdapter物件da
            //da帶入查詢的SQL語法為toolStripTextBox1文字方塊的內容
            SqlDataAdapter da = new SqlDataAdapter(SQL_Text, cn);
            //建立DataSet物件ds
            DataSet ds = new DataSet();
            //將da物件所取得的資料填入ds物件
            da.Fill(ds);
            //dataGridView呈現的資料來源為ds內的第一個DataTable資料表(即Tables[0])
            selectDataGridView.DataSource = ds.Tables[0];
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            if (selectTable.SelectedIndex == -1)
            {
                MessageBox.Show("資料表選項選項必填！", "錯誤");
            }
            else
            {
                String attribute = "", constraint = "";
                if (!string.IsNullOrWhiteSpace(selectConstraint.Text))
                    constraint = " WHERE " + selectConstraint.Text;

                if (selectAttribute.SelectedIndex == -1)
                    attribute = "*";
                else
                    attribute = selectAttribute.Text;
                SQL_Text = "SELECT " + attribute + " FROM " + selectTable.Text + constraint;
                Console.WriteLine(SQL_Text);

                try
                {
                    //建立SqlConnection物件cn
                    SqlConnection cn = new SqlConnection();
                    //設定cn連接Northwind.mdf資料庫檔案
                    cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                        "AttachDbFilename=|DataDirectory|CourseDatabase.mdf;" +
                         "Integrated Security=True;";
                    //建立DataAdapter物件da
                    //da帶入查詢的SQL語法為toolStripTextBox1文字方塊的內容
                    SqlDataAdapter da = new SqlDataAdapter(SQL_Text, cn);
                    //建立DataSet物件ds
                    DataSet ds = new DataSet();
                    //將da物件所取得的資料填入ds物件
                    da.Fill(ds);
                    //dataGridView呈現的資料來源為ds內的第一個DataTable資料表(即Tables[0])
                    selectDataGridView.DataSource = ds.Tables[0];
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    SQL_Text = "SELECT * FROM " + selectTable.Text;
                    //建立SqlConnection物件cn
                    SqlConnection cn = new SqlConnection();
                    //設定cn連接Northwind.mdf資料庫檔案
                    cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                        "AttachDbFilename=|DataDirectory|CourseDatabase.mdf;" +
                         "Integrated Security=True";
                    //建立DataAdapter物件da
                    //da帶入查詢的SQL語法為toolStripTextBox1文字方塊的內容
                    SqlDataAdapter da = new SqlDataAdapter(SQL_Text, cn);
                    //建立DataSet物件ds
                    DataSet ds = new DataSet();
                    //將da物件所取得的資料填入ds物件
                    da.Fill(ds);
                    //dataGridView呈現的資料來源為ds內的第一個DataTable資料表(即Tables[0])
                    selectDataGridView.DataSource = ds.Tables[0];
                }
            }
        }

        private void updateTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateAttribute.Text = null;
            updateAttribute.Items.Clear();
            switch (updateTable.Text)
            {
                case "College":
                    updateAttribute.Items.Add("CollegeID");
                    updateAttribute.Items.Add("Name");
                    updateAttribute.Items.Add("District");
                    break;
                case "Department":
                    updateAttribute.Items.Add("CollegeID");
                    updateAttribute.Items.Add("DepartID");
                    updateAttribute.Items.Add("Name");
                    updateAttribute.Items.Add("Chairman");
                    updateAttribute.Items.Add("TeacherNum");
                    updateAttribute.Items.Add("StudentNum");
                    break;
                case "Teacher":
                    updateAttribute.Items.Add("DepartID");
                    updateAttribute.Items.Add("TeacherID");
                    updateAttribute.Items.Add("Name");
                    updateAttribute.Items.Add("Positionn");
                    updateAttribute.Items.Add("Sex");
                    updateAttribute.Items.Add("Age");
                    updateAttribute.Items.Add("Salary");
                    break;
                case "Student":
                    updateAttribute.Items.Add("DepartID");
                    updateAttribute.Items.Add("StudentID");
                    updateAttribute.Items.Add("Name");
                    updateAttribute.Items.Add("Sex");
                    updateAttribute.Items.Add("Age");
                    break;
                case "Course":
                    updateAttribute.Items.Add("DepartID");
                    updateAttribute.Items.Add("CourseID");
                    updateAttribute.Items.Add("Name");
                    updateAttribute.Items.Add("Instructor");
                    break;
                case "StudentCourse":
                    updateAttribute.Items.Add("SerialID");
                    updateAttribute.Items.Add("StudentID");
                    updateAttribute.Items.Add("CourseID");
                    break;
            }
            SQL_Text = "SELECT * FROM " + updateTable.Text;
            //建立SqlConnection物件cn
            SqlConnection cn = new SqlConnection();
            //設定cn連接Northwind.mdf資料庫檔案
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|CourseDatabase.mdf;" +
                 "Integrated Security=True";
            //建立DataAdapter物件da
            //da帶入查詢的SQL語法為toolStripTextBox1文字方塊的內容
            SqlDataAdapter da = new SqlDataAdapter(SQL_Text, cn);
            //建立DataSet物件ds
            DataSet ds = new DataSet();
            //將da物件所取得的資料填入ds物件
            da.Fill(ds);
            //dataGridView呈現的資料來源為ds內的第一個DataTable資料表(即Tables[0])
            updateDataGridView.DataSource = ds.Tables[0];
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if(updateTable.SelectedIndex == -1 || updateAttribute.SelectedIndex == -1 || string.IsNullOrWhiteSpace(updateContent.Text))
            {
                MessageBox.Show("除了更新條件其他選項必填！", "錯誤");
            }
            else
            {
                String constraint = "";
                if (!string.IsNullOrWhiteSpace(updateConstraint.Text))
                    constraint = " WHERE " + updateConstraint.Text;
                SQL_Text = "UPDATE " + updateTable.Text + " SET " + updateAttribute.Text + " = '" + updateContent.Text + "'" + constraint;
                Console.WriteLine(SQL_Text);

                try
                {
                    //建立SqlConnection物件cn
                    SqlConnection cn = new SqlConnection();
                    //設定cn連接Northwind.mdf資料庫檔案
                    cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                        "AttachDbFilename=|DataDirectory|CourseDatabase.mdf;" +
                         "Integrated Security=True";
                    //建立DataAdapter物件da
                    //da帶入查詢的SQL語法為toolStripTextBox1文字方塊的內容
                    SqlDataAdapter da = new SqlDataAdapter(SQL_Text, cn);
                    //建立DataSet物件ds
                    DataSet ds = new DataSet();
                    //將da物件所取得的資料填入ds物件
                    da.Fill(ds);
                    //dataGridView呈現的資料來源為ds內的第一個DataTable資料表(即Tables[0])
                    updateDataGridView.DataSource = ds.Tables[0];
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    SQL_Text = "SELECT * FROM " + updateTable.Text;
                    //建立SqlConnection物件cn
                    SqlConnection cn = new SqlConnection();
                    //設定cn連接Northwind.mdf資料庫檔案
                    cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                        "AttachDbFilename=|DataDirectory|CourseDatabase.mdf;" +
                         "Integrated Security=True";
                    //建立DataAdapter物件da
                    //da帶入查詢的SQL語法為toolStripTextBox1文字方塊的內容
                    SqlDataAdapter da = new SqlDataAdapter(SQL_Text, cn);
                    //建立DataSet物件ds
                    DataSet ds = new DataSet();
                    //將da物件所取得的資料填入ds物件
                    da.Fill(ds);
                    //dataGridView呈現的資料來源為ds內的第一個DataTable資料表(即Tables[0])
                    updateDataGridView.DataSource = ds.Tables[0];
                }
            }
        }
      
        private void addTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            addAttribute.Text = "";
            switch (addTable.Text)
            {
                case "College":
                    addAttribute.Text = "請依照對應欄位以此格式輸入內容，例如：(10, 'Center', 'East')。";
                    break;
                case "Department":
                    addAttribute.Text = "請依照對應欄位以此格式輸入內容，例如：('Z3', 10, 'EG', 'Z30', 15, 216)。";
                    break;
                case "Teacher":
                    addAttribute.Text = "請依照對應欄位以此格式輸入內容，例如：('Z3', 'Z30', 'Tony', 'Professor', 'M', 49, 103600)";
                    break;
                case "Student":
                    addAttribute.Text = "請依照對應欄位以此格式輸入內容，例如：('Z3', 'Z340641208', 'Lisa', 'F', 22)";
                    break;
                case "Course":
                    addAttribute.Text = "請依照對應欄位以此格式輸入內容，例如：('Z3', 'Z3150', 'Computer', 'Tony')";
                    break;
                case "StudentCourse":
                    addAttribute.Text = "請依照對應欄位以此格式輸入內容，例如：('99', 'Z340641208', 'Z3150')";
                    break;
            }
            SQL_Text = "SELECT * FROM " + addTable.Text;
            //建立SqlConnection物件cn
            SqlConnection cn = new SqlConnection();
            //設定cn連接Northwind.mdf資料庫檔案
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|CourseDatabase.mdf;" +
                 "Integrated Security=True";
            //建立DataAdapter物件da
            //da帶入查詢的SQL語法為toolStripTextBox1文字方塊的內容
            SqlDataAdapter da = new SqlDataAdapter(SQL_Text, cn);
            //建立DataSet物件ds
            DataSet ds = new DataSet();
            //將da物件所取得的資料填入ds物件
            da.Fill(ds);
            //dataGridView呈現的資料來源為ds內的第一個DataTable資料表(即Tables[0])
            addDataGridView.DataSource = ds.Tables[0];
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (addTable.SelectedIndex == -1 || string.IsNullOrWhiteSpace(addContent.Text))
            {
                MessageBox.Show("所有欄位必填！", "錯誤");
            }
            else
            {
                SQL_Text = "INSERT INTO " + addTable.Text + " VALUES " + addContent.Text;
                Console.WriteLine(SQL_Text);

                try
                {
                    //建立SqlConnection物件cn
                    SqlConnection cn = new SqlConnection();
                    //設定cn連接Northwind.mdf資料庫檔案
                    cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                        "AttachDbFilename=|DataDirectory|CourseDatabase.mdf;" +
                         "Integrated Security=True";
                    //建立DataAdapter物件da
                    //da帶入查詢的SQL語法為toolStripTextBox1文字方塊的內容
                    SqlDataAdapter da = new SqlDataAdapter(SQL_Text, cn);
                    //建立DataSet物件ds
                    DataSet ds = new DataSet();
                    //將da物件所取得的資料填入ds物件
                    da.Fill(ds);
                    //dataGridView呈現的資料來源為ds內的第一個DataTable資料表(即Tables[0])
                    addDataGridView.DataSource = ds.Tables[0];
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    SQL_Text = "SELECT * FROM " + addTable.Text;
                    //建立SqlConnection物件cn
                    SqlConnection cn = new SqlConnection();
                    //設定cn連接Northwind.mdf資料庫檔案
                    cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                        "AttachDbFilename=|DataDirectory|CourseDatabase.mdf;" +
                         "Integrated Security=True";
                    //建立DataAdapter物件da
                    //da帶入查詢的SQL語法為toolStripTextBox1文字方塊的內容
                    SqlDataAdapter da = new SqlDataAdapter(SQL_Text, cn);
                    //建立DataSet物件ds
                    DataSet ds = new DataSet();
                    //將da物件所取得的資料填入ds物件
                    da.Fill(ds);
                    //dataGridView呈現的資料來源為ds內的第一個DataTable資料表(即Tables[0])
                    addDataGridView.DataSource = ds.Tables[0];
                }
            }
        }

        private void deleteTable_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SQL_Text = "SELECT * FROM " + deleteTable.Text;
            //建立SqlConnection物件cn
            SqlConnection cn = new SqlConnection();
            //設定cn連接Northwind.mdf資料庫檔案
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|CourseDatabase.mdf;" +
                 "Integrated Security=True";
            //建立DataAdapter物件da
            //da帶入查詢的SQL語法為toolStripTextBox1文字方塊的內容
            SqlDataAdapter da = new SqlDataAdapter(SQL_Text, cn);
            //建立DataSet物件ds
            DataSet ds = new DataSet();
            //將da物件所取得的資料填入ds物件
            da.Fill(ds);
            //dataGridView呈現的資料來源為ds內的第一個DataTable資料表(即Tables[0])
            deleteDataGridView.DataSource = ds.Tables[0];
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (deleteTable.SelectedIndex == -1)
            {
                MessageBox.Show("資料表選項選項必填！", "錯誤");
            }
            else
            {
                String constraint = "";
                if (!string.IsNullOrWhiteSpace(deleteConstraint.Text))
                    constraint = " WHERE " + deleteConstraint.Text;
                SQL_Text = "DELETE " + deleteTable.Text + constraint;
                Console.WriteLine(SQL_Text);

                try
                {
                    //建立SqlConnection物件cn
                    SqlConnection cn = new SqlConnection();
                    //設定cn連接Northwind.mdf資料庫檔案
                    cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                        "AttachDbFilename=|DataDirectory|CourseDatabase.mdf;" +
                         "Integrated Security=True;";
                    //建立DataAdapter物件da
                    //da帶入查詢的SQL語法為toolStripTextBox1文字方塊的內容
                    SqlDataAdapter da = new SqlDataAdapter(SQL_Text, cn);
                    //建立DataSet物件ds
                    DataSet ds = new DataSet();
                    //將da物件所取得的資料填入ds物件
                    da.Fill(ds);
                    //dataGridView呈現的資料來源為ds內的第一個DataTable資料表(即Tables[0])
                    deleteDataGridView.DataSource = ds.Tables[0];
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    SQL_Text = "SELECT * FROM " + deleteTable.Text;
                    //建立SqlConnection物件cn
                    SqlConnection cn = new SqlConnection();
                    //設定cn連接Northwind.mdf資料庫檔案
                    cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                        "AttachDbFilename=|DataDirectory|CourseDatabase.mdf;" +
                         "Integrated Security=True";
                    //建立DataAdapter物件da
                    //da帶入查詢的SQL語法為toolStripTextBox1文字方塊的內容
                    SqlDataAdapter da = new SqlDataAdapter(SQL_Text, cn);
                    //建立DataSet物件ds
                    DataSet ds = new DataSet();
                    //將da物件所取得的資料填入ds物件
                    da.Fill(ds);
                    //dataGridView呈現的資料來源為ds內的第一個DataTable資料表(即Tables[0])
                    deleteDataGridView.DataSource = ds.Tables[0];
                }
            }

        }
        private void mySQLButton_Click(object sender, EventArgs e)
        {
            //為防止SQL語法錯誤, 或資料庫連接失敗...等例外
            //故將相關程式碼置於try...catch內
            try
            {
                //建立SqlConnection物件cn
                SqlConnection cn = new SqlConnection();
                //設定cn連接Northwind.mdf資料庫檔案
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|CourseDAtabase.mdf;" +
                     "Integrated Security=True";
                //建立DataAdapter物件da
                //da帶入查詢的SQL語法為toolStripTextBox1文字方塊的內容
                SqlDataAdapter da = new SqlDataAdapter(mySQLText.Text, cn);
                //建立DataSet物件ds
                DataSet ds = new DataSet();
                //將da物件所取得的資料填入ds物件
                da.Fill(ds);
                //dataGridView呈現的資料來源為ds內的第一個DataTable資料表(即Tables[0])
                mySQLDataGridView.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                SQL_Text = "SELECT * FROM " + updateTable.Text;
                //建立SqlConnection物件cn
                SqlConnection cn = new SqlConnection();
                //設定cn連接Northwind.mdf資料庫檔案
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|CourseDatabase.mdf;" +
                     "Integrated Security=True";
                //建立DataAdapter物件da
                //da帶入查詢的SQL語法為toolStripTextBox1文字方塊的內容
                SqlDataAdapter da = new SqlDataAdapter(SQL_Text, cn);
                //建立DataSet物件ds
                DataSet ds = new DataSet();
                //將da物件所取得的資料填入ds物件
                da.Fill(ds);
                //dataGridView呈現的資料來源為ds內的第一個DataTable資料表(即Tables[0])
                updateDataGridView.DataSource = ds.Tables[0];
            }
        }
        private void inExistTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            inExistAttribute.Text = null;
            inExistAttribute.Items.Clear();
            inExistRange.Text = null;
            inExistRange.Items.Clear();
            switch (inExistTable.Text)
            {
                case "College":
                    inExistAttribute.Items.Add("CollegeID");
                    inExistAttribute.Items.Add("Name");
                    inExistAttribute.Items.Add("District");
                    inExistRange.Items.Add("CollegeID");
                    inExistRange.Items.Add("Name");
                    inExistRange.Items.Add("District");
                    break;
                case "Department":
                    inExistAttribute.Items.Add("CollegeID");
                    inExistAttribute.Items.Add("DepartID");
                    inExistAttribute.Items.Add("Name");
                    inExistAttribute.Items.Add("Chairman");
                    inExistAttribute.Items.Add("TeacherNum");
                    inExistAttribute.Items.Add("StudentNum");
                    inExistRange.Items.Add("CollegeID");
                    inExistRange.Items.Add("DepartID");
                    inExistRange.Items.Add("Name");
                    inExistRange.Items.Add("Chairman");
                    inExistRange.Items.Add("TeacherNum");
                    inExistRange.Items.Add("StudentNum");
                    break;
                case "Teacher":
                    inExistAttribute.Items.Add("DepartID");
                    inExistAttribute.Items.Add("TeacherID");
                    inExistAttribute.Items.Add("Name");
                    inExistAttribute.Items.Add("Positionn");
                    inExistAttribute.Items.Add("Sex");
                    inExistAttribute.Items.Add("Age");
                    inExistAttribute.Items.Add("Salary");
                    inExistRange.Items.Add("DepartID");
                    inExistRange.Items.Add("TeacherID");
                    inExistRange.Items.Add("Name");
                    inExistRange.Items.Add("Positionn");
                    inExistRange.Items.Add("Sex");
                    inExistRange.Items.Add("Age");
                    inExistRange.Items.Add("Salary");
                    break;
                case "Student":
                    inExistAttribute.Items.Add("DepartID");
                    inExistAttribute.Items.Add("StudentID");
                    inExistAttribute.Items.Add("Name");
                    inExistAttribute.Items.Add("Sex");
                    inExistAttribute.Items.Add("Age");
                    inExistRange.Items.Add("DepartID");
                    inExistRange.Items.Add("StudentID");
                    inExistRange.Items.Add("Name");
                    inExistRange.Items.Add("Sex");
                    inExistRange.Items.Add("Age");
                    break;
                case "Course":
                    inExistAttribute.Items.Add("DepartID");
                    inExistAttribute.Items.Add("CourseID");
                    inExistAttribute.Items.Add("Name");
                    inExistAttribute.Items.Add("Instructor");
                    inExistRange.Items.Add("DepartID");
                    inExistRange.Items.Add("CourseID");
                    inExistRange.Items.Add("Name");
                    inExistRange.Items.Add("Instructor");
                    break;
                case "StudentCourse":
                    inExistAttribute.Items.Add("SerialID");
                    inExistAttribute.Items.Add("StudentID");
                    inExistAttribute.Items.Add("CourseID");
                    inExistRange.Items.Add("SerialID");
                    inExistRange.Items.Add("StudentID");
                    inExistRange.Items.Add("CourseID");
                    break;
            }
            SQL_Text = "SELECT * FROM " + inExistTable.Text;
            //建立SqlConnection物件cn
            SqlConnection cn = new SqlConnection();
            //設定cn連接Northwind.mdf資料庫檔案
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|CourseDatabase.mdf;" +
                 "Integrated Security=True";
            //建立DataAdapter物件da
            //da帶入查詢的SQL語法為toolStripTextBox1文字方塊的內容
            SqlDataAdapter da = new SqlDataAdapter(SQL_Text, cn);
            //建立DataSet物件ds
            DataSet ds = new DataSet();
            //將da物件所取得的資料填入ds物件
            da.Fill(ds);
            //dataGridView呈現的資料來源為ds內的第一個DataTable資料表(即Tables[0])
            inExistDataGridView.DataSource = ds.Tables[0];
        }

        private void inExistFunctionSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (inExistFunctionSelect.Text)
            {
                case "IN":
                    inExistRange.Enabled = true;
                    break;
                case "NOT IN":
                    inExistRange.Enabled = true;
                    break;
                case "EXISTS":
                    inExistRange.Enabled = false;
                    break;
                case "NOT EXISTS":
                    inExistRange.Enabled = false;
                    break;
            }
        }

        private void inExistButton_Click(object sender, EventArgs e)
        {
            switch (inExistFunctionSelect.Text)
            {
                case "IN":
                    if (inExistTable.SelectedIndex == -1)
                    {
                        MessageBox.Show("資料表選項選項必填！", "錯誤");
                    }
                    else
                    {
                        String attribute = "", constraint = "", range = "";
                        if (inExistRange.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(inExistConstraint.Text))
                        {
                            range = " WHERE " + inExistRange.Text;
                            constraint = " IN " + inExistConstraint.Text;
                        }

                        if (inExistAttribute.SelectedIndex == -1)
                            attribute = "*";
                        else
                            attribute = inExistAttribute.Text;

                        SQL_Text = "SELECT " + attribute + " FROM " + inExistTable.Text + range + constraint;
                        Console.WriteLine(SQL_Text);
                    }
                    break;
                case "NOT IN":
                    if (inExistTable.SelectedIndex == -1)
                    {
                        MessageBox.Show("資料表選項選項必填！", "錯誤");
                    }
                    else
                    {
                        String attribute = "", constraint = "", range = "";
                        if (inExistRange.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(inExistConstraint.Text))
                        {
                            range = " WHERE " + inExistRange.Text;
                            constraint = " NOT IN " + inExistConstraint.Text;
                        }

                        if (inExistAttribute.SelectedIndex == -1)
                            attribute = "*";
                        else
                            attribute = inExistAttribute.Text;

                        SQL_Text = "SELECT " + attribute + " FROM " + inExistTable.Text + range + constraint;
                        Console.WriteLine(SQL_Text);
                    }
                    break;
                case "EXISTS":
                    if (inExistTable.SelectedIndex == -1)
                    {
                        MessageBox.Show("資料表選項選項必填！", "錯誤");
                    }
                    else
                    {
                        String attribute = "", constraint = "";
                        if (!string.IsNullOrWhiteSpace(inExistConstraint.Text))
                        {
                            constraint = " WHERE EXISTS (" + inExistConstraint.Text + ")";
                        }

                        if (inExistAttribute.SelectedIndex == -1)
                            attribute = "*";
                        else
                            attribute = inExistAttribute.Text;

                        SQL_Text = "SELECT " + attribute + " FROM " + inExistTable.Text + constraint;
                        Console.WriteLine(SQL_Text);
                    }
                    break;
                case "NOT EXISTS":
                    if (inExistTable.SelectedIndex == -1)
                    {
                        MessageBox.Show("資料表選項選項必填！", "錯誤");
                    }
                    else
                    {
                        String attribute = "", constraint = "";
                        if (!string.IsNullOrWhiteSpace(inExistConstraint.Text))
                        {
                            constraint = " WHERE NOT EXISTS (" + inExistConstraint.Text + ")";
                        }

                        if (inExistAttribute.SelectedIndex == -1)
                            attribute = "*";
                        else
                            attribute = inExistAttribute.Text;

                        SQL_Text = "SELECT " + attribute + " FROM " + inExistTable.Text + constraint;
                        Console.WriteLine(SQL_Text);
                    }
                    break;
                }
                try
                {
                    //建立SqlConnection物件cn
                    SqlConnection cn = new SqlConnection();
                    //設定cn連接Northwind.mdf資料庫檔案
                    cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                        "AttachDbFilename=|DataDirectory|CourseDatabase.mdf;" +
                         "Integrated Security=True;";
                    //建立DataAdapter物件da
                    //da帶入查詢的SQL語法為toolStripTextBox1文字方塊的內容
                    SqlDataAdapter da = new SqlDataAdapter(SQL_Text, cn);
                    //建立DataSet物件ds
                    DataSet ds = new DataSet();
                    //將da物件所取得的資料填入ds物件
                    da.Fill(ds);
                    //dataGridView呈現的資料來源為ds內的第一個DataTable資料表(即Tables[0])
                    inExistDataGridView.DataSource = ds.Tables[0];
                }
                catch (Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                    SQL_Text = "SELECT * FROM " + inExistTable.Text;
                    //建立SqlConnection物件cn
                    SqlConnection cn = new SqlConnection();
                    //設定cn連接Northwind.mdf資料庫檔案
                    cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                        "AttachDbFilename=|DataDirectory|CourseDatabase.mdf;" +
                         "Integrated Security=True";
                    //建立DataAdapter物件da
                    //da帶入查詢的SQL語法為toolStripTextBox1文字方塊的內容
                    SqlDataAdapter da = new SqlDataAdapter(SQL_Text, cn);
                    //建立DataSet物件ds
                    DataSet ds = new DataSet();
                    //將da物件所取得的資料填入ds物件
                    da.Fill(ds);
                    //dataGridView呈現的資料來源為ds內的第一個DataTable資料表(即Tables[0])
                    inExistDataGridView.DataSource = ds.Tables[0];
                }

                

            }

        private void aggregateFunctionSelector_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void aggregateTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            aggregateAttribute.Text = null;
            aggregateAttribute.Items.Clear();
            switch (aggregateTable.Text)
            {
                case "Department":
                    aggregateAttribute.Items.Add("TeacherNum");
                    aggregateAttribute.Items.Add("StudentNum");
                    break;
                case "Teacher":
                    aggregateAttribute.Items.Add("Age");
                    aggregateAttribute.Items.Add("Salary");
                    break;
                case "Student":
                    aggregateAttribute.Items.Add("Age");
                    break;
            }
            SQL_Text = "SELECT * FROM " + aggregateTable.Text;
            //建立SqlConnection物件cn
            SqlConnection cn = new SqlConnection();
            //設定cn連接Northwind.mdf資料庫檔案
            cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                "AttachDbFilename=|DataDirectory|CourseDatabase.mdf;" +
                 "Integrated Security=True";
            //建立DataAdapter物件da
            //da帶入查詢的SQL語法為toolStripTextBox1文字方塊的內容
            SqlDataAdapter da = new SqlDataAdapter(SQL_Text, cn);
            //建立DataSet物件ds
            DataSet ds = new DataSet();
            //將da物件所取得的資料填入ds物件
            da.Fill(ds);
            //dataGridView呈現的資料來源為ds內的第一個DataTable資料表(即Tables[0])
            aggregateDataGridView.DataSource = ds.Tables[0];
        }

        private void aggregateButton_Click(object sender, EventArgs e)
        {
            if (aggregateTable.SelectedIndex == -1)
            {
                MessageBox.Show("資料表選項選項必填！", "錯誤");
            }
            else
            {
                String attribute = "", constraint = "", having = "";
                if (!string.IsNullOrWhiteSpace(aggregateConstraint.Text))
                    constraint = " WHERE " + aggregateConstraint.Text;

                if (!string.IsNullOrWhiteSpace(havingConstraint.Text))
                    having = " HAVING " + havingConstraint.Text;

                if (aggregateAttribute.SelectedIndex == -1)
                    attribute = "*";
                else
                    attribute = aggregateAttribute.Text;

                SQL_Text = "SELECT " + aggregateFunctionSelector.Text + "(" + attribute + ")" + " FROM " + aggregateTable.Text + constraint + having;
                Console.WriteLine(SQL_Text);
            }
            try
            {
                //建立SqlConnection物件cn
                SqlConnection cn = new SqlConnection();
                //設定cn連接Northwind.mdf資料庫檔案
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|CourseDatabase.mdf;" +
                     "Integrated Security=True;";
                //建立DataAdapter物件da
                //da帶入查詢的SQL語法為toolStripTextBox1文字方塊的內容
                SqlDataAdapter da = new SqlDataAdapter(SQL_Text, cn);
                //建立DataSet物件ds
                DataSet ds = new DataSet();
                //將da物件所取得的資料填入ds物件
                da.Fill(ds);
                //dataGridView呈現的資料來源為ds內的第一個DataTable資料表(即Tables[0])
                aggregateDataGridView.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                SQL_Text = "SELECT * FROM " + aggregateTable.Text;
                //建立SqlConnection物件cn
                SqlConnection cn = new SqlConnection();
                //設定cn連接Northwind.mdf資料庫檔案
                cn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;" +
                    "AttachDbFilename=|DataDirectory|CourseDatabase.mdf;" +
                     "Integrated Security=True";
                //建立DataAdapter物件da
                //da帶入查詢的SQL語法為toolStripTextBox1文字方塊的內容
                SqlDataAdapter da = new SqlDataAdapter(SQL_Text, cn);
                //建立DataSet物件ds
                DataSet ds = new DataSet();
                //將da物件所取得的資料填入ds物件
                da.Fill(ds);
                //dataGridView呈現的資料來源為ds內的第一個DataTable資料表(即Tables[0])
                aggregateDataGridView.DataSource = ds.Tables[0];
            }
        }
    }

}

