namespace workshop.webapi.Repository
{
    public interface IRepository<T>
    {
        Task<IEnumerable<T>> Get();
    }
}
