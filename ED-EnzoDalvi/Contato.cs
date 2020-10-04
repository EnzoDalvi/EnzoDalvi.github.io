namespace ED_EnzoDalvi
{
        public class Contato
        {
        public string nome;
        public int telefone;
        public string email;

        public Contato()
        {
            nome = null;
            telefone = 0;
            email = null;
        }
        public Contato(string name, int tel, string em)
        {
            nome = name;
            telefone = tel;
            email = em;
        }
    }
}