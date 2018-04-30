using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Neon
{
    class Calculo
    {
        public int calculoTotal(ListBox.SelectedObjectCollection listBox, List<Extra> listExtra) {
            int total=0;
            foreach (var item in listBox)
            {
                foreach (var extra in listExtra)
                {
                    if (item.Equals(extra.nombreExtra))
                    {
                        total += extra.precio; 
                    }
                }
            }
            return total;
        }
    }
}
