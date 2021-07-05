using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Entityframework
{
    public class EfPersonDal : EfEntityRepositoryBase<Person, PersonDbContext>, IPersonDal
    {
    }
}
