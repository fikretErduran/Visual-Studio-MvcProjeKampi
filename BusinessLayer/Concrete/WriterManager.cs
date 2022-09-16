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
    public class WriterManager : IWriterService
    {
        IWriterDal _writerdal;

        public WriterManager(IWriterDal writerdal)
        {
            _writerdal = writerdal;
        }

        public Writer GetByID(int id)
        {
            return _writerdal.Get(x => x.WriterID == id);
        }

        public List<Writer> GetList()
        {
            return _writerdal.List();
        }

        public void WriterAdd(Writer p)
        {
            _writerdal.Insert(p);
        }

        public void WriterDelete(Writer p)
        {
            _writerdal.Delete(p);
        }

        public void WriterUpdate(Writer p)
        {
            _writerdal.Update(p);
        }
    }
}
