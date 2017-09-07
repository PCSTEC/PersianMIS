using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PersianMIS.StationControl
{
    public partial class CreateParameterFormulaUserControl : UserControl
    {
        public CreateParameterFormulaUserControl()
        {
            InitializeComponent();
        }

        private void Btn_ShowStation_Click(object sender, EventArgs e)
        {
            MainPnl.Controls.Clear();

            for (int i = 1; i <= Txt_ParameterCount.Value; i++)
            {
                CreateNewParameterFromulaWithReturnTSQLUserControl NewPulsParameterUC = new CreateNewParameterFromulaWithReturnTSQLUserControl();

                NewPulsParameterUC.Tag = i;
                NewPulsParameterUC.Name = i.ToString();
                NewPulsParameterUC.Visible = false;
                 MainPnl.Controls.Add(NewPulsParameterUC);

            }
        }
    }
}
