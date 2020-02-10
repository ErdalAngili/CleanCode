using FluentValidation;
using Okul.Business.Abstract;
using Okul.Business.Utilities;
using Okul.Business.ValidationRules.FluentValidation;
using Okul.DataAccess.Concrete.EntityFramework;
using Okul.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul.Business.Concrete
{
    public class OgrenciManager : OgrenciService
    {
        EfOgrenciDal _EfOgrenciDal;
        public OgrenciManager(EfOgrenciDal efOgrenciDal)
        {
            _EfOgrenciDal = efOgrenciDal;
        }

        public void ADD(Ogrenci ogrenci)
        {
            ValidationTool.Validate(new OgrenciValidator(), ogrenci);
            _EfOgrenciDal.add(ogrenci);
        }

        public List<Ogrenci> Getall()
        {
           return _EfOgrenciDal.GetAll();
        }
    }
}
