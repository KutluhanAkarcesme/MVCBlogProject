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

        public void Add(Content content)
        {
            _contentDal.Add(content);
        }

        public void Delete(Content content)
        {
            _contentDal.Delete(content);
        }

        public Content GetById(int id)
        {
            return _contentDal.GetById(x => x.ContentId == id);
        }

        public List<Content> GetList()
        {
            return _contentDal.GetList();
        }

        public List<Content> GetListById(int id)
        {
            return _contentDal.GetListByFilter(x => x.HeadingId == id);
        }

        public void Update(Content content)
        {
             _contentDal.Update(content);
        }
    }
}
