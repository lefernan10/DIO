using Series.src.Enum;

namespace Series.src.Entities
{
    public class Serie : BaseEntity
    {
        private Genre Genre { get; set; }
        private string Title { get; set; }
        private string Description { get; set; }
        private int Year { get; set; }
        private bool Deleted { get; set;}

        public Serie(int id, Genre genre, string title, string description, int year)
        {
            this.Id = id;
            this.Genre = genre;
            this.Title = title;
            this.Description = description;
            this.Year = year;
            this.Deleted = false;
        }

        public override string ToString()
        {
            string retorno = "";
            retorno += "Genre: " + this.Genre + Environment.NewLine;
            retorno += "Title: " + this.Title + Environment.NewLine;
            retorno += "Description: " + this.Description + Environment.NewLine;
            retorno += "Year: " + this.Year + Environment.NewLine;
            return retorno;
        }

        public string titleReturn()
        {
            return this.Title;
        }

        public int idReturn()
        {
            return this.Id;
        }

        public bool deletedReturn()
        {
            return this.Deleted;
        }

        public void Delete()
        {
            this.Deleted = true;
        }
    }

}