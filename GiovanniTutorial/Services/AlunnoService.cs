

using GiovanniTutorial.Entity;

namespace GiovanniTutorial.Services
{
    public interface IAlunnoService
    {
        public List<Alunno> getAlunnos();

        public Alunno? getAlunno(string id);

    }
    public class AlunnoService : IAlunnoService
    {
        List<Alunno> people = new List<Alunno>()
            {
                new Alunno("Giovanni","Destratis"),
                new Alunno("Davide","Saiano"),
                new Alunno("Giovanni","Martinelli")
            };

        public List<Alunno> getAlunnos() => people;

        public Alunno? getAlunno(string id) => people.FirstOrDefault(p => p.Id == id);

    }
}
