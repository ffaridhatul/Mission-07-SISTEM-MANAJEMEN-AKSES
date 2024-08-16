using System.Collections.Generic;

namespace Mission2.Model
{
    public interface IDataSource<T>
    {
        void Save(List<T> list);
        List<T> Load();
    }
}
