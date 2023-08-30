using BusinessLayer.Abstract;
using BusinessLayer.Concrete.Base;
using CoreLayer.Utilities.Results;
using DataLayer.Abstract;
using DataLayer.Concrete;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class AnimalNameManager : ManagerBase, IAnimalNameManager
    {
        IAnimalNameDal _animalNameDal;
        public AnimalNameManager(Context context, IAnimalNameDal animalNameDal) : base(context)
        {
            _animalNameDal = animalNameDal;
        }

        public IDataResult<List<AnimalName>> GelAllAnimalName()
        {
            var result = _animalNameDal.GetAll();
            if (result == null)
                return new ErrorDataResult<List<AnimalName>>("Ekli Çocuk İsimi Bulunamadı");
            return new SuccessDataResult<List<AnimalName>>(result);
        }

        public IDataResult<AnimalName> GetByIdAnimalName(int id)
        {
            var result = _animalNameDal.Get(c => c.Id == id);
            if (result == null)
                return new ErrorDataResult<AnimalName>("Bu Id'de Çocuk İsimi bulunamadı");
            return new SuccessDataResult<AnimalName>(result);
        }

        public IDataResult<AnimalName> RandomAnimalName()
        {
            Random rnd = new Random();
            var result = GelAllAnimalName();

            if (result == null || result.Data.Count == 0)
                return new ErrorDataResult<AnimalName>(result.Message);

            var randomAnimalName = rnd.Next(result.Data.Count);

            var selected = result.Data[randomAnimalName];

            return new SuccessDataResult<AnimalName>(selected);
        }
    }
}
