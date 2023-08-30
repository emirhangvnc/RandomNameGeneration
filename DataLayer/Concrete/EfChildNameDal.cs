using CoreLayer.Datas.Concrete;
using DataLayer.Abstract;
using EntityLayer;

namespace DataLayer.Concrete
{
    public class EfChildNameDal : EfEntityRepositoryBase<ChildName, Context>, IChildNameDal
    {
    }
}