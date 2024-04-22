using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entites.Concrate;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrate.EntityFramework
{
    public class EfRandevuDal : EfEntityRepositoryBase<Randevu, NorthwindContext>, IRandevuDal
    {
    }
}
