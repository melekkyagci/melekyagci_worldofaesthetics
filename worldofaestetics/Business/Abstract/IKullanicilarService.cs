using Entites.Concrate;
using Core.Utilities.Results;

namespace Business.Abstract
{
    public interface IKullanicilarService
    {
        IResult Add(Kullanicilar kullanicilar);
        IResult Delete(Kullanicilar kullanicilar);
        IResult Update(Kullanicilar kullanicilar);
        IDataResult<List<Kullanicilar>> GetAll();
    }
}
