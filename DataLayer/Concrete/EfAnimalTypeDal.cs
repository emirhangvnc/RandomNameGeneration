using CoreLayer.Datas.Concrete;
using DataLayer.Abstract;
using EntityLayer;

namespace DataLayer.Concrete
{
    public class EfAnimalTypeDal : EfEntityRepositoryBase<AnimalType, Context>, IAnimalTypeDal
    {
    }
}