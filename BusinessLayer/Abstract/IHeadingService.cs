using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IHeadingService
    {
        List<Heading> List();
        void AddHeading(Heading heading);
        void UpdateHeading(Heading heading);
        void DeleteHeading(Heading heading);
        Heading GetByID(int id);


    }
}
