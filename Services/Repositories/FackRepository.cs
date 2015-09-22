using NavTECH.Web;
using NavTECH.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repositories
{
    public class FackRepository<T> : IRepository<T>
        where T : IDbModel
    {
        private List<T> _list;
        public FackRepository(IEnumerable<T> enumerable)
        {
            _list = enumerable.ToList();
        }

        public IQueryable<T> Queryable
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int Create(T dbModel)
        {
            var lastId = _list.Max(l => l.Id) + 1;

            dbModel.Id = lastId;
            return lastId;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(T dbModel)
        {
            throw new NotImplementedException();
        }

        public void Edit(T dbModel)
        {
            throw new NotImplementedException();
        }

        public T Get(int id)
        {
            return _list.SingleOrDefault(l => l.Id == id);
        }

        public int GetNextSequenceValue()
        {
            throw new NotImplementedException();
        }

        public void ResetSequenceValue(int value)
        {
            throw new NotImplementedException();
        }
    }
}
