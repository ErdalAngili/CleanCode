using Okul.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Okul.Business.Abstract
{
    public interface OgrenciService
    {
        List<Ogrenci> Getall();
        void ADD(Ogrenci ogrenci);
    }
}
