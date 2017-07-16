using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace Business
{
   public partial class dangkiBusiness
    {
        public DataTable hienthidangki()
        {
            try
            {
                dangki dk = new dangki();
                return dk.getTable();
            }
            catch
            { throw; }

        }
       // dat etne ham trung ten lop
        public int themdangki(dangki dk)
        {
            return dk.themdangki(dk);
        }
    }
}
