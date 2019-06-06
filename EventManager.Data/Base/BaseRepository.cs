using Data.Base;

namespace Data
{
    public abstract class BaseRepository<T> : SuperBaseRepository<AssesmentContext, T>
        where T : class, new()
    {
      
    }
}
