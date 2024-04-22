using Entites.Concrate;
using Core.Utilities.Results;


namespace Business.Abstract
{
    public interface ICalisanService
    {
        IResult Add(Calisan calisan);
        IResult Delete(Calisan calisan);
        IResult Update(Calisan calisan);
        IDataResult<List<Calisan>> GetAll();
    }
}
