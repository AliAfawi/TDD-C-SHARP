using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace TDD
{

    public partial class Student : Form
{
    private string id;
    private string firstname;
    private string lastName;
    private string email;
    private string phone;
    private string[] grades;


    public string Id { get { return id; } set { id = value; } }
    public string Firstname { get { return firstname; } set { firstname = value; } }
    public string LastName { get { return lastName; } set { lastName = value; } }
    public string EmailL { get { return email; } set { email = value; } }

    public string Phone { get { return phone; } set { phone = value; } }
    public string[] Grades { get { return grades; } }



        public double AverageGrade()
        {
            if (grades == null || grades.Length == 0) return 0;
            double sum = 0;
            for (int i = 0; i < grades.Length; i++)
            {
                if (grades[i] == "777")
                    sum += 0;
                else
                   sum += int.Parse(grades[i]);
            }
            return sum / grades.Length;
        }

        public override string ToString()
        {
            return "ID: " + Id + "\n" + "Name: " + firstname + " " + lastName + "\n" + "Email: " + email + "\n" + "Phone: " + phone + "\n" + "Grades: " + string.Join(", ", Grades) + "\n" + "Average: " + AverageGrade();
        }

        public Student()
    {
        InitializeComponent();
    }
    public Student(string id, string firstname, string lastName, string email, string phone, string[] grades)
    {
        this.id = id;
        this.firstname = firstname;
        this.lastName = lastName;
        this.email = email;
        this.phone = phone;
        this.grades = grades;
    }

       static StudentManger studentManger = new StudentManger();
        int length = 10000;
        private void txtid_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled=!char.IsNumber(e.KeyChar);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);

        }

        private void clear_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsNumber(e.KeyChar);

        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            string text = txtid.Text;

            if(text.Length>9)
            {
                MessageBox.Show("ID have to be 9 numbers");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            }

        private void button1_Click(object sender, EventArgs e)
        {
            bool flag = false;

            for (int i = 0; i < txtEmail.Text.Length; i++)
            {
                if (txtEmail.Text[i] == '@')
                    flag = true;
            }
            
            if (txtid.Text.Length != 9)
            {
                MessageBox.Show("id have to be 9 numbers");
                txtid.Text = "";

            }

            else if (!flag)
            {
                MessageBox.Show("email have to be @ ");
                txtEmail.Text = "";
            }

            else if (txtPhone.Text.Length != 10)
            {
                MessageBox.Show("phone have to be 10 numbers");
                txtPhone.Text = "";
            }

            else if (((grade1.Text.Length > 2 || grade1.Text.Length <= 0) && (grade1.Text != "777" && grade1.Text != "100")) || grade1.Text == "0")
            {
                MessageBox.Show("grade 1 have to be 1-100 or 777");
                grade1.Text = "";
            }
            else if (((grade2.Text.Length > 2 || grade2.Text.Length <= 0) && (grade2.Text != "777" && grade2.Text != "100")) || grade2.Text == "0")
            {
                MessageBox.Show("grade 2 have to be 1-100 or 777");
                grade2.Text = "";
            }
            else if (((grade3.Text.Length > 2 || grade3.Text.Length <= 0) && (grade3.Text != "777" && grade3.Text != "100")) || grade3.Text == "0")
            {
                MessageBox.Show("grade 3 have to be 1-100 or 777");
                grade3.Text = "";
            }
            else if (((grade4.Text.Length > 2 || grade4.Text.Length <= 0) && (grade4.Text != "777" && grade4.Text != "100")) || grade4.Text == "0")
            {
                MessageBox.Show("grade 4 have to be 1-100 or 777");
                grade4.Text = "";
            }

            else if (((grade5.Text.Length > 2 || grade5.Text.Length <= 0) && (grade5.Text != "777" && grade5.Text != "100")) || grade5.Text == "0")
            {
                MessageBox.Show("grade 5 have to be 1-100 or 777");
                grade5.Text = "";
            }
        

            else
            {
                string[] grades = new string[5];
                grades[0] = grade1.Text;
                grades[1] = grade2.Text;
                grades[2] = grade3.Text;
                grades[3] = grade4.Text;
                grades[4] = grade5.Text;


                if (studentManger.isStudentByphone(txtPhone.Text) == false && studentManger.isStudentByid(txtid.Text) == false)
                {
                    Student student2 = new Student(txtid.Text, txtfirstName.Text, txtLastName.Text, txtEmail.Text, txtPhone.Text, grades);
                    studentManger.addStudent(student2);
                    double grade = student2.AverageGrade();
                    dataGridView2.Rows.Add(txtid.Text, txtfirstName.Text, txtLastName.Text, txtEmail.Text, txtPhone.Text, grade1.Text, grade2.Text, grade3.Text, grade4.Text, grade5.Text, grade);
                }
                else 
                    MessageBox.Show("student already exists");

                txtEmail.Text = "";
                txtfirstName.Text = "";
                txtLastName.Text = "";
                txtid.Text = "";
                txtPhone.Text = "";
                grade1.Text = "";
                grade2.Text = "";
                grade3.Text = "";
                grade4.Text = "";
                grade5.Text = "";
            }
        }

        private void txtfirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void addRandom_Click(object sender, EventArgs e)
        {

 
            for (int i = 0; i < length; i++)
            {
                int id = 0, phone = 0;

                //ID
                Random rndid = new Random();
                int randomid = rndid.Next(111111111, 999999999);
                txtid.Text = randomid.ToString();


                //Grades
                Random rndgrade = new Random();
                string[] arrgrade = new string[5];
                for (int i3  = 0; i3 < 5; i3++)
                {
                    arrgrade[i3] = (rndgrade.Next(1, 101)).ToString();
                }
             


                //Phone
                Random rndphone = new Random();
                txtPhone.Text = "05" + (rndphone.Next(11111111, 99999999)).ToString();


                //Name
                Random randfirstname = new Random();
                Random randlastname = new Random();
                string[] firstNames = { "Emma", "Liam", "Olivia", "Noah", "Ava", "William", "Sophia", "James", "Isabella", "Benjamin" };
                string[] lastNames = { "Smith", "Johnson", "Williams", "Jones", "Brown", "Garcia", "Miller", "Davis", "Rodriguez", "Martinez" };
                int firstNameIndex = randfirstname.Next(0, firstNames.Length);
                int lastNameIndex = randlastname.Next(0, lastNames.Length);
                txtfirstName.Text  = firstNames[firstNameIndex];
                txtLastName.Text  = lastNames[lastNameIndex];


                //Email
                Random random = new Random();
                const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                txtEmail.Text = new string(Enumerable.Repeat(chars, 7).Select(s => s[random.Next(s.Length)]).ToArray()) + "@gmail.com";

                //add student

                if (studentManger.isStudentByphone(txtPhone.Text) == false && studentManger.isStudentByid(txtid.Text) == false)
                {
                    Student student2 = new Student(txtid.Text, txtfirstName.Text, txtLastName.Text, txtEmail.Text, txtPhone.Text, arrgrade);
                    studentManger.addStudent(student2);
                    double grade = student2.AverageGrade();
                    dataGridView2.Rows.Add(txtid.Text, txtfirstName.Text, txtLastName.Text, txtEmail.Text, txtPhone.Text, arrgrade[0], arrgrade[1], arrgrade[2], arrgrade[3], arrgrade[4], grade);
                }
/*                else
                    MessageBox.Show("student already exists");*/


                txtid.Text = "";
                    txtPhone.Text = "";
                    grade1.Text = "";
                    grade2.Text = "";
                    grade3.Text = "";
                    grade4.Text = "";
                    grade5.Text = "";
                    txtEmail.Text = "";
                    txtfirstName.Text = "";
                    txtLastName.Text = "";

                

            }
        }

        private void grade4_TextChanged(object sender, EventArgs e)
        {

        }

        private void grade5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            List<Student> studs =  studentManger.GetSortedStudentByAverage();


            if (studs == null)
                MessageBox.Show("sadf");
            foreach (Student stud in studs)
                dataGridView2.Rows.Add(stud.id, stud.firstname, stud.lastName,  stud.email, stud.phone, stud.grades[0], stud.grades[1], stud.grades[2], stud.grades[3], stud.grades[4], stud.AverageGrade());

        }

        private void dataGridView2_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

     
}
