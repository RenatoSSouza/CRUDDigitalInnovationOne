using GrudDIO.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GrudDIO.Class
{
    class RepositorySeries : IRepository<Series>
    {
        private List<Series> seriesList = new List<Series>();

        public void Exclude(int id)
        {
            seriesList[id].Excludes();
        }

        public void Insert(Series entity)
        {
            seriesList.Add(entity);
        }

        public List<Series> List()
        {
            return seriesList;
        }

        public int NextId()
        {
            return seriesList.Count;
        }

        public Series ReturnById(int id)
        {
            return seriesList[id];
        }

        public void Update(int id, Series entity)
        {
            seriesList[id] = entity;
        }
    }
}
