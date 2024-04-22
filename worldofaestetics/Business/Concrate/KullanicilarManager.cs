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
    public class KullanicilarManager : IKullanicilarService
    {
        IKullanicilarDal _kullanicilar;
        public
        KullanicilarManager(IKullanicilarDal kullanicilar)
        {
            _kullanicilar = kullanicilar;
        }
        public IResult Add(Kullanicilar kullanicilar)
        {
            _kullanicilar.Add(kullanicilar);
            return new SuccessResult("başarıyla eklendi");
        }

        public IDataResult<List<Kullanicilar>> GetAll()
        {
            return new
            SuccessDataResult<List<Kullanicilar>>(_kullanicilar.GetAll());
        }

        public IResult Remove(Kullanicilar kullanicilar)
        {
            _kullanicilar.Delete(kullanicilar);
            return new SuccessResult("başarıyla silindi");
        }

        public IResult Update(Kullanicilar kullanicilar)
        {
            _kullanicilar.Update(kullanicilar);
            return new SuccessResult("güncellendi");
        }
    }
}
