using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public  interface IContentService
    {
        List<Content> List();
        List<Content> GetListByHeadingID(int id);
        void ContentInsert(Content content);   
        void ContentUpdate(Content content);   
        void ContentDelete(Content content);
        Content GetByID(int id);


    }
}
