using CoreLayer.Utilities.Results;
using EntityLayer;

namespace BusinessLayer.Abstract
{
    public interface IAnimalNameManager
    {
        IDataResult<AnimalName> RandomAnimalName();
        IDataResult<AnimalName> GetByIdAnimalName(int id);
        IDataResult<List<AnimalName>> GelAllAnimalName();
    }
}