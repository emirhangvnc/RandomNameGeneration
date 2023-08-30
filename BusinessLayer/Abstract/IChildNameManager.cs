using CoreLayer.Utilities.Results;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IChildNameManager
    {
        IDataResult<ChildName> RandomChildName();
        IDataResult<ChildName> GetByIdChildName(int id);
        IDataResult<List<ChildName>> GelAllChildName();
    }
}