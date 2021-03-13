using GrudDIO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrudDIO.Class
{
    class RepositorySeries : IRepository<Series>
    {
        private List<Series> SeriesList = new List<Series>();
        public void Exclude(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Series entityes)
        {
            throw new NotImplementedException();
        }

        public List<Series> List()
        {
            throw new NotImplementedException();
        }

        public int NextId()
        {
            throw new NotImplementedException();
        }

        public Series ReturnById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Series entityes)
        {
            throw new NotImplementedException();
        }
    }
}
