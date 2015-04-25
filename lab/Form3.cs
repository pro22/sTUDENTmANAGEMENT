using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            StreamReader sr = new StreamReader("D://visual/test.txt");
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Name";
            dataGridView1.Columns[1].Name = "Roll";
            dataGridView1.Columns[2].Name = "CGPA";
            dataGridView1.Columns[3].Name = "Year";
            dataGridView1.Columns[4].Name = "session";
            string t;

            while((t=sr.ReadLine())!=null)
            {
                dataGridView1.Rows.Add(t, sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine(), sr.ReadLine());
            }

            /*string txt;
            while((txt=sr.ReadLine())!=null)
            {
                listBox1.Items.Add(txt);
               
            }*/
            sr.Close();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
       
    }
}
