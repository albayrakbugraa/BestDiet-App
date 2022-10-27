using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestDiet
{
    public class Helper
    {
        public static void ClearControls(Control.ControlCollection controlCollection)
        {
            foreach (Control control in controlCollection)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Clear();
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedItem = null;
                }
                else if (control is NumericUpDown)
                {
                    ((NumericUpDown)control).Value = 1;
                }
                else if (control is GroupBox)
                {
                    ClearControls(((GroupBox)control).Controls);
                }
            }
        }
    }
}
