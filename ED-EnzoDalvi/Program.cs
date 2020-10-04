using System;

namespace ED_EnzoDalvi
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 99,tipo=99;
            Agenda Lista = new Agenda();
            
            Lista.Add("ana",1,"Ana.ana@gmail.com");
            Lista.Add("beto",8,"Roberto@gmail.com");
            Lista.Add("carlos",5,"Carlos.Santana@gmail.com");
            Lista.Add("walter",67,"walter.walter@outlook.com");
            Lista.Add("daniel",12,"Dani.California@gmail.com");
            Lista.Add("erick",10,"ErickJones@gmail.com");
            Lista.Add("fabio",3,"fabio.bruh@outlook.com");
            Lista.Add("gabriel",7,"Gabriel@yahoo.com");
            Lista.Add("cassio",9,"Cassiano.joe@gmail.com");

        
            while (menu != 0)
            {
                System.Console.WriteLine("------------------ Bem-Vindo a Agenda ------------------");
                System.Console.WriteLine("Digite 1 -> Para Navegar Pela lista de Contatos.\nDigite 2 -> Para Buscar um Contato.\nDigite 3 -> Para Editar um Contato Existente.\nDigite 4 -> Para Adicionar um Novo Contato.\nDigite 5 -> Para Remover um Contato.\nDigite 6 -> Para Ordernar a Lista.\nDigite 7 -> Para Printar a Lista Completa.\nDigite 0 -> Para Fechar O Progama.\n------------------ -------------------- ----------------");
                menu=Convert.ToInt32(Console.ReadLine());
                

                if(menu == 1)
                {
                    Lista.Navegação(); 
                }
                if(menu == 2)
                {   
                    Lista.BuscarUI();
                }
                if(menu == 3)
                {
                    System.Console.WriteLine("------------------ -------------------- ----------------\nDigite 1 -> Para Buscar o Contato a ser Editado or Nome.\nDigite 2 -> Para Buscar o Contato a ser Editado or Numero.\nDigite 3 -> Para Buscar o Contato a ser Editado or E-mail.\n------------------ -------------------- ----------------");
                    tipo =Convert.ToInt32(Console.ReadLine());

                    Lista.Editar(tipo);

                }
                if(menu == 4)
                {
                   Lista.AddUI(); 
                }
                if(menu == 5)
                {
                    Lista.Remove();
                }
                if(menu == 6)
                {
                    System.Console.WriteLine("------------------ -------------------- ----------------\nDigite 1 -> Para Ordernar por Nomes.\nDigite 2 -> Para Ordenar por Numero.\nDigite 3 -> Para Ordenar por E-mail.\n------------------ -------------------- ----------------");
                    tipo =Convert.ToInt32(Console.ReadLine());
                   
                    if(tipo > 0 && tipo < 4)
                    {
                        Lista.Order(tipo);
                    }
                }
                if(menu == 7)
                {
                    Lista.Print();
                }
                if(menu == 0)
                {
                    System.Console.WriteLine("------------------ Progama Fechando ------------------");
                    return;
                }
                else if(menu < 0 || menu > 7)
                {
                    System.Console.WriteLine("\n----------------------Numero Digitado Invalido-------------------------\n");
                }
            }
        }
    }
}
