using BusinessLayer.Abstract;
using BusinessLayer.Concrete.Base;
using CoreLayer.Utilities.Results;
using DataLayer.Abstract;
using DataLayer.Concrete;
using EntityLayer;

namespace BusinessLayer.Concrete
{
    public class ChildNameManager : ManagerBase, IChildNameManager
    {
        IChildNameDal _childNameDal;
        public ChildNameManager(Context context, IChildNameDal childNameDal) : base(context)
        {
            _childNameDal= childNameDal;
        }

        public IDataResult<List<ChildName>> GelAllChildName()
        {
            var result = _childNameDal.GetAll();
            if (result == null)
                return new ErrorDataResult<List<ChildName>>("Ekli Çocuk İsimi Bulunamadı");
            return new SuccessDataResult<List<ChildName>>(result);
        }

        public IDataResult<ChildName> GetByIdChildName(int id)
        {
            var result = _childNameDal.Get(c => c.Id == id);
            if (result == null)
                return new ErrorDataResult<ChildName>("Bu Id'de Çocuk İsimi bulunamadı");
            return new SuccessDataResult<ChildName>(result);
        }

        public IDataResult<ChildName> RandomChildName()
        {
            Random rnd = new Random();
            var result = GelAllChildName();

            if (result == null || result.Data.Count == 0)
                return new ErrorDataResult<ChildName>(result.Message);

            var randomChildName = rnd.Next(result.Data.Count);

            var selected = result.Data[randomChildName];

            return new SuccessDataResult<ChildName>(selected);
        }
    }
}
