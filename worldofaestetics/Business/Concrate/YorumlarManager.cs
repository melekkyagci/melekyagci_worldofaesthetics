using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entites.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class YorumlarManager : IYorumlarService
    {  IYorumlarDal _yorumlar;
        public
        YorumlarManager(IYorumlarDal yorumlar)
        {
            _yorumlar = yorumlar;
        }
        public IResult Add(Yorumlar yorumlar)
        {
            _yorumlar.Add(yorumlar);
            return new SuccessResult("başarıyla eklendi");
        }

        public IDataResult<List<Yorumlar>> GetAll()
        {
            return new
            SuccessDataResult<List<Yorumlar>>(_yorumlar.GetAll());
        }

        public IResult Remove(Yorumlar yorumlar)
        {
            _yorumlar.Delete(yorumlar);
            return new SuccessResult("başarıyla silindi");
        }

        public IResult Update(Yorumlar yorumlar)
        {
            _yorumlar.Update(yorumlar);
            return new SuccessResult("güncellendi");
        }
    }
}
