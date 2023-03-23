using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ViewResume : Form
    {
        public ViewResume()
        {
            InitializeComponent();
            this.doneBtn.Click += new System.EventHandler(this.doneBtn_Click);
        }

        private void doneBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
