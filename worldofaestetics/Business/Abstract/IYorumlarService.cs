using Entites.Concrate;
using Core.Utilities.Results;


namespace Business.Abstract
{
    public interface IYorumlarService
    {
        IResult Add(Yorumlar yorumlar);
        IResult Delete(Yorumlar yorumlar);
        IResult Update(Yorumlar yorumlar);
        IDataResult<List<Yorumlar>> GetAll();
    }
}
