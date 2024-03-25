using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DAO
{
    public class ChucNangDAO
    {
        private static ChucNangDAO instance;
        public static ChucNangDAO Instance
        {
            get { if (instance == null) instance = new ChucNangDAO(); return instance; }
            private set { instance = value; }
        }

        private ChucNangDAO() { }
    }
}
