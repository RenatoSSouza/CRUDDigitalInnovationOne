using System;
using System.Collections.Generic;
using System.Text;

namespace GrudDIO.Interfaces
{
    public interface IRepository
    {
        List<T> list();
        T ReturnById(int id);
        void Insert(T entityes);
        void Exclude(int id);
        void Update(int id, T entityes);
        int NextId();
    }
}
