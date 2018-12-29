using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInformation
{
    public partial class Form1 : Form
    {
        Class1 obj = new Class1();
        String Gender;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripSplitButton1_ButtonClick(object sender, EventArgs e)
        {

        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked=true)
            {
                Gender = "male";
            }
            else if(radioButton2.Checked = true)
            {
                Gender = "female";
            }

            System.DateTime dt = Convert.ToDateTime(dateTimePicker1.Text);
            obj.ins_up_dlt("insert into tblStudentMasterCool (Eno,Name,Branch,Gender,Contact,Mail,Address,Dob,Blood) values(,'" + txteno.Text + "','" + txtname.Text + "','"+txtbranch.Text +"','" + Gender + "','" + maskedTextBox1.Text + "','" + txtemail.Text + "','" + txtadd.Text + "','" + dt.ToShortDateString() + "','" + comboBox1.SelectedItem.ToString() + "','" + txthobby.Text + "')");
            
        }
    }
}
