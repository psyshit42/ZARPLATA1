using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class AddWorker : Form
    {
        Control SaveWorker = new Control();
        

        public AddWorker()
        {
            InitializeComponent();
            
        }

        public void Save_Click(object sender, EventArgs e)
        {
            try
            {
                string NameWorker = textBox1.Text;
                int AgeWorker = Convert.ToInt16(textBox2.Text);
                Positions PositionWorker = (Positions)PositionList.SelectedIndex;
                double WageWorker = double.Parse(textBox4.Text);
                int BranchIDWorker = Convert.ToInt32(textBox5.Text);

                Worker Vasyan = new Worker(NameWorker, AgeWorker, PositionWorker, WageWorker, BranchIDWorker);

                SaveWorker.Save(Vasyan);
                this.Close();
            }

            catch(Exception)
            {
                var Error = new Error();
                Error.Show();
            }


            

        }

        

        
        


        
    }
}
