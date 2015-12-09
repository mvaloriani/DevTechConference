namespace Hello
{
    public interface IPersona
    {
        string Cognome { get; set; }
        string Nome { get; }

        string ChiSei();
    }
}