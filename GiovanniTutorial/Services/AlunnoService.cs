using GiovanniTutorial.Entity;

namespace GiovanniTutorial.Services
{
    public interface IAlunnoService
    {
        public List<AlunnoEntity> getAlunnos();

        public AlunnoEntity? getAlunno(string id);

    }
    public class AlunnoService : IAlunnoService
    {
        List<AlunnoEntity> people = new List<AlunnoEntity>()
            {
                new AlunnoEntity("Giovanni","Destratis"),
                new AlunnoEntity("Davide","Saiano"),
                new AlunnoEntity("Giovanni","Martinelli")
            };

        public List<AlunnoEntity> getAlunnos() => people;

        public AlunnoEntity? getAlunno(string id) => people.FirstOrDefault(p => p.Id == id);

    }
}
