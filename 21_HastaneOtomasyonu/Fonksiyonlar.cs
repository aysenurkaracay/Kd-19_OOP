using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_HastaneOtomasyonu
{
    public class Fonksiyonlar
    {
        public static void Temizle(Form form)
        {
            foreach (Control item in form.Controls)
            {
                if (item is TextBox) ((TextBox)item).Clear();
                else if (item is ComboBox) ((ComboBox)item).SelectedIndex = -1;
                else if(item is GroupBox)
                {
                    GroupBox g = item as GroupBox;
                    foreach (Control ctrl in g.Controls)
                    {
                        if (ctrl is RadioButton) ((RadioButton)ctrl).Checked = default;
                    }
                }
            }
        }
    }
}
