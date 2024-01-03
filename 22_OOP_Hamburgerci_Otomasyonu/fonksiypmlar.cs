using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_OOP_Hamburgerci_Otomasyonu
{
    public class fonksiypmlar
    {
        public static void Temizle(Control.ControlCollection collection)
        {
            foreach(Control control in Collection)
            {
                if (control is ComboBox)
                {
                    ((ComboBox)control).SelectedIndex = 0;
                }
                else if (control is NumericUpDown) 
                { 
                    ((NumericUpDown)control).Value=((NumericUpDown)control).Minimum;
                }
                else if(control is CheckBox)
                {
                    ((CheckBox)control).Checked=false;
                }
                else if ((CheckBox)control is CheckBox)
                {
                    ((CheckBox)control).Checked=false;
                }
                else if (control is GroupBox)
                {
                    Temizle(((GroupBox)control).Controls);
                }
                else if ( control is FlowLayoutPanel ) 
                { 
                 Temizle(((FlowLayoutPanel)control).Controls);
                }
            }
        }
        

        }
    }
}
