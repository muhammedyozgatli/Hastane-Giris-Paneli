using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Hastane_Proje
{
    public partial class FrmDuyurular : Form
    {
        public FrmDuyurular()
        {
            InitializeComponent();
        }
      SqlBaglantisi bgl=new SqlBaglantisi();    
        private void FrmDuyurular_Load(object sender, EventArgs e)
        {
            DataTable da = new DataTable();
            SqlDataAdapter dt=new SqlDataAdapter("select *from Tbl_Duyurular",bgl.baglanti());
            dt.Fill(da);
            dataGridView1.DataSource = da;
        }
    }
}
