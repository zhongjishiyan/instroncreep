using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClsStaticStation
{
    public    struct demodata
    {
        public double pos;
        public double load;
        public double ext;
        public double poscmd;
        public double loadcmd;
        public double extcmd;
        public double time;
        public double count;
        public double pos1;//围压位移
        public double load1;//围压负荷
    }
    public  class ClsDemo :ClsBaseControl
    {
        public void Init(int handle)
        {


        }

        int OpenConnection()
        {

            return 0;
        }



    }
}
