
using DesignPattern.CustomerProject.InterfaceDal;

namespace DesignPattern.CustomerProject.CommonDAL
{
    public abstract class AbstractDal<T> : IDal<T>
    {
        protected string connectionString = "";
        protected List<T> listTypes = new List<T>();
        public AbstractDal(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public virtual void Add(T entity)
        {
            listTypes.Add(entity);
        }

        public virtual List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public virtual void Save()
        {
            throw new NotImplementedException();
        }

        public virtual void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}