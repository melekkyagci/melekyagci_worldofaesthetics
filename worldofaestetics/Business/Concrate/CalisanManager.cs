using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entites.Concrate;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrate
{
    public class CalisanManager : ICalisanService
    {   ICalisanDal _calisan; 
        public
        CalisanManager(ICalisanDal calisan)
        {
            _calisan = calisan;
        }
        public IResult Add(Calisan calisan)
        {
            _calisan.Add(calisan);
            return new SuccessResult ("başarıyla eklendi");
        }

        public IDataResult<List<Calisan>> GetAll()
        {
            return new
            SuccessDataResult<List<Calisan>>(_calisan.GetAll());
        }

        public IResult Delete(Calisan calisan)
        {
            _calisan.Delete(calisan);
            return new SuccessResult("başarıyla silindi");
        }

        public IResult Update(Calisan calisan)
        {
            _calisan.Update(calisan);
            return new SuccessResult("güncellendi");
        }
    }
}
 