using Series.src.Interfaces;

namespace Series.src.Entities
{
    public class SerieRepository : IRepository<Serie>
    {
        private List<Serie> seriesList = new List<Serie>();

        public void Delete(int id)
        {
            seriesList[id].Delete();
        }

        public void Insert(Serie entity)
        {
            seriesList.Add(entity);
        }

        public int NextId()
        {
            return seriesList.Count;
        }

        public Serie ReturnId(int id)
        {
            return seriesList[id];
        }

        public List<Serie> SeriesList()
        {
            return seriesList;
        }

        public void Update(int id, Serie entity)
        {
            seriesList[id] = entity;
        }
    }
}