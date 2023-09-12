namespace Example.Application.Servise.Interfaces
{
    public interface ICrudBase<T>
    {
        public void Create(T obj);
        public void GetAll();
        public T GetById(int id);
        public void Update(int id);
        public void Delete(int id);
    }
}
