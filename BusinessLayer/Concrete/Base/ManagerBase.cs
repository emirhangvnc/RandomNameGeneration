using DataLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete.Base
{
    public class ManagerBase
    {
        public Context DbContext { get; }

        public ManagerBase(Context context)
        {
            DbContext = context;
        }
    }
}
