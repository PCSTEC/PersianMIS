using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calendar
{
    public partial class Frm_MainCalendar  : Telerik.WinControls.UI.RadForm
    {
        public Frm_MainCalendar()
        {
            InitializeComponent();
        }

        private void Mnu_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_DeclareCalendares_Click(object sender, EventArgs e)
        {
            Form frm = new Frm_DefineCalendar();
            frm.ShowDialog();
        }
    }
}
