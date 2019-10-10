using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TryMvvmGlukoze.Models
{
    static class SendMessage
    {
        public static void SendMsg()
        {
            string message = "Результат получился меньше нуля, измените входные параметры!";
            string caption = "Ошибка!";
            MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
