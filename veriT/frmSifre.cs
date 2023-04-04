using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace veriT
{
    public partial class frmSifre : Form
    {
        public frmSifre()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'odev1DataSet3.TableDoktor' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
           this.tableDoktorTableAdapter.Fill(this.odev1DataSet3.TableDoktor); 
           
        }
    }
}
