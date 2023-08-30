using CoreLayer.Datas.Concrete;
using DataLayer.Abstract;
using EntityLayer;

namespace DataLayer.Concrete
{
    public class EfAnimalNameDal : EfEntityRepositoryBase<AnimalName, Context>, IAnimalNameDal
    {
    }
}