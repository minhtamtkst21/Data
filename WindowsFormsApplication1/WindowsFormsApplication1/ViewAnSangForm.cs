using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ViewAnSangForm : Form
    {
       public ViewAnSangForm()
        {
            InitializeComponent();
            this.Load += ViewAnSangForm_Load;
            this.btnAddAnSang.Click += btnAddAnSang_Click;
        }

        void btnAddAnSang_Click(object sender, EventArgs e)
        {
            var form = new AddAnSangForm();
            form.ShowDialog();
            this.showAnSangList();
        }

        void ViewAnSangForm_Load(object sender, EventArgs e)
        {
            this.showAnSangList();
        }

        private void showAnSangList()
        {
            var db = new QuanAnEntities();
            var list = db.AnSangs.ToArray();
            this.GrdAnSang.DataSource = list;

        }
    }
}
