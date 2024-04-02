using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.DTO
{
    public class Ca
    {
        public Ca(int maCa, string thu, string buoi)
        {
            this.MaCa = maCa;
            this.Thu = thu;
            this.Buoi = buoi;

        }

        public Ca(DataRow row)
        {
            this.MaCa = (int)row["MaCa"];
            this.Thu = row["Thu"].ToString();
            this.Buoi = row["Buoi"].ToString();

        }

        private int maCa;
        public int MaCa
        {
            get { return maCa; }
            set { maCa = value; }
        }

        private string thu;
        public string Thu
        {
            get { return thu; }
            set { thu = value; }
        }

        private string buoi;
        public string Buoi
        {
            get { return buoi; }
            set { buoi = value; }
        }
    }
}
