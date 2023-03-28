using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hastane_Proje
{
    internal class SqlBaglantisi
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source = ASUSTUFGAMING\\ SQLEXPRESS; Initial Catalog = HastaneProje; Integrated Security = True");
            baglan.Open();
            return baglan;  
        }
    }
}
