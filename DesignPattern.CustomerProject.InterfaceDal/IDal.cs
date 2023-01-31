namespace DesignPattern.CustomerProject.InterfaceDal
{
    public interface IDal<T>
    {
        void Add(T entity);
        void Update(T entity);
        List<T> GetAll();
        void Save();
    }
}
