using Entites.Concrate;
using Core.Utilities.Results;


namespace Business.Abstract
{
    public interface IRandevuService
    {
        IResult Add(Randevu randevu);
        IResult Delete(Randevu randevu);
        IResult Update(Randevu randevu);
        IDataResult<List<Randevu>> GetAll();
    }
}
