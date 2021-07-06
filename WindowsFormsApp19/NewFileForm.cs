using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class NewFileForm : Form
    {
        public string fileName { private set; get; }

        public NewFileForm()
        {
            InitializeComponent();
        }
    }
}
