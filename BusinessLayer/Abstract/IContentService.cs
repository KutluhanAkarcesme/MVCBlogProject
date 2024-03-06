using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContentService
    {
        List<Content> GetList();
        Content GetById(int id);
        List<Content> GetListById(int id);
        void Add(Content content);
        void Delete(Content content);
        void Update(Content content);
    }
}
