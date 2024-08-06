using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace DershaneOtomasyon
{
    internal class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            
            SqlConnection baglan = new SqlConnection(@"Data Source=DESKTOP-PSBK5O1;Initial Catalog=dbo.DershaneOtomasyon;Integrated Security=True");
            baglan.Open();
            return baglan;
        }

    }
    
}
