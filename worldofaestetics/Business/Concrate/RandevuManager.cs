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
    public class RandevuManager : IRandevuService
    {  IRandevuDal _randevu;
        public
        RandevuManager(IRandevuDal randevu)
        {
            _randevu = randevu;
        }
        public IResult Add(Randevu randevu)
        {
            _randevu.Add(randevu);
            return new SuccessResult("başarıyla eklendi");
        }

        public IDataResult<List<Randevu>> GetAll()
        {
            return new
            SuccessDataResult<List<Randevu>>(_randevu.GetAll());
        }

        public IResult Remove(Randevu randevu)
        {
            _randevu.Delete(randevu);
            return new SuccessResult("başarıyla silindi");
        }

        public IResult Update(Randevu randevu)
        {
            _randevu.Update(randevu);
            return new SuccessResult("güncellendi");
        }
    }
}

