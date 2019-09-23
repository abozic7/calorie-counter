using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalorieCounter
{
    public class ApplicationManager : ApplicationContext
    {
        private int noOfOpenedForms = 0;

        public void Run(Form form)
        {
            Application.Run(form);
            noOfOpenedForms++;
        }

        public void Close(Form form)
        {
            noOfOpenedForms--;

        }
    }
}
