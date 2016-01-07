using IET.Common.Data;

namespace IET.ESP.Data
{
    public abstract class DataRepositoryBase<T> : DataRepositoryBase<T, ESPContext> where T : class, new() { }
}
