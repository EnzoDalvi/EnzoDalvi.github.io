using System.IO;


namespace ED_EnzoDalvi
{
    using System.IO;
    public class Node
    {
        public Contato Contato;
        public Node next;
        public string ArquivoNome;
        
        public Node()
        {
            Contato = new Contato();
        } 
        public Node(string name,int tel ,string em)
        {
            Contato = new Contato(name,tel,em);
        }
    }
}