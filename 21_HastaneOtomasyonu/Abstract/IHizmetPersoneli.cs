using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_HastaneOtomasyonu.Abstract
{
    public interface IHizmetPersoneli:IInsan,ICalisan
    {
        void GoreviniYerineGetir();//Aşçı,Güvenlik
    }
}
