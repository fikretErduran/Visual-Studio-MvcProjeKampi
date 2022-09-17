using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContentManager : IContentService
    {

        IContentDal _contentDal;

        public ContentManager(IContentDal contentDal)
        {
            _contentDal = contentDal;
        }

        public void ContentDelete(Content content)
        {
            _contentDal.Delete(content);
        }

        public void ContentInsert(Content content)
        {
            _contentDal.Insert(content);
        }

        public void ContentUpdate(Content content)
        {
            throw new NotImplementedException();
        }

        public Content GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Content> GetListByHeadingID(int id)
        {
            return _contentDal.List(x => x.HeadingID == id);
        }

        //parametreye baglı olarak Listeleme yapmak için gerekli
        //şartı çagırmalıyız
        public List<Content> List()
        {
            throw new NotImplementedException();
        }
    }
}
