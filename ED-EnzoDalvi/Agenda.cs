using System;
using System.Collections.Generic;
using System.Text;


namespace ED_EnzoDalvi
{
    public class Agenda
    {
        public Node head;
        public Agenda()
        {
            head = null;
        }
        public void Add(string name, int tel, string em) // Add at the first position 
        {
            var newNode = new Node(name, tel, em);
            newNode.next = head;
            head = newNode;
        }
        public void AddUI()
        {
            string name,em;
            int tel;

            System.Console.WriteLine("Digite o Nome:");
            name =Console.ReadLine();

            System.Console.WriteLine("Digite o telefone:");
            tel =Convert.ToInt32(Console.ReadLine());

            System.Console.WriteLine("Digite o E-mail:");
            em =Console.ReadLine();

            var newNode = new Node(name, tel, em);
            newNode.next = head;
            head = newNode;                   
        }
        public void Print()
        {
            var aux = head;

            while (aux != null)
            {
                Console.WriteLine($" ->\n Nome:{aux.Contato.nome} \n Telefone:{aux.Contato.telefone}\n e-mail:{aux.Contato.email}");
                aux = aux.next;
            }
        }
        public void Order(int tipo) //probrema
        {
                Node aux = new Node();  
                Node aux3 =new Node();
                Node auxaux =new Node();
                int cont = Contador();
                int k = 0;
           
            if (tipo == 1) 
            {
               for(aux=head ; aux != null ; aux = aux.next) 
                {
                    for(aux3=head ; k < cont-1  && aux3.next != null ; aux3 = aux3.next) 
                    {
                       if(aux.Contato.nome.CompareTo(aux3.Contato.nome) > 0) 
                        { 
                            auxaux.Contato.nome = aux.Contato.nome;
                            auxaux.Contato.telefone = aux.Contato.telefone;
                            auxaux.Contato.email = aux.Contato.email;
                           
                            aux.Contato.nome = aux3.Contato.nome;
                            aux.Contato.telefone=aux3.Contato.telefone;
                            aux.Contato.email=aux3.Contato.email;
                           
                            aux3.Contato.nome=auxaux.Contato.nome;
                            aux3.Contato.telefone=auxaux.Contato.telefone;
                            aux3.Contato.email=auxaux.Contato.email;
                        }   
                    k++;
                    }
                k=0;
                }
            }
            else if (tipo == 2) // Ordernar por Numero
            {
               for(aux=head ; aux != null ; aux = aux.next) 
                {
                    for(aux3=head ; k < cont-1  && aux3.next != null ; aux3 = aux3.next) 
                    {
                       if( aux.Contato.telefone > aux3.Contato.telefone )
                        { 
                            auxaux.Contato.nome = aux.Contato.nome;
                            auxaux.Contato.telefone = aux.Contato.telefone;
                            auxaux.Contato.email = aux.Contato.email;
                           
                            aux.Contato.nome = aux3.Contato.nome;
                            aux.Contato.telefone=aux3.Contato.telefone;
                            aux.Contato.email=aux3.Contato.email;
                           
                            aux3.Contato.nome=auxaux.Contato.nome;
                            aux3.Contato.telefone=auxaux.Contato.telefone;
                            aux3.Contato.email=auxaux.Contato.email;
                        }   
                    k++;
                    }
                k=0;
                }
            }           
            if (tipo == 3) 
            {
               for(aux=head ; aux != null ; aux = aux.next) 
                {
                    for(aux3=head ; k < cont-1  && aux3.next != null ; aux3 = aux3.next) 
                    {
                       if(string.Compare(aux.Contato.email,aux3.Contato.email) > 0) 
                        { 
                            auxaux.Contato.nome = aux.Contato.nome;
                            auxaux.Contato.telefone = aux.Contato.telefone;
                            auxaux.Contato.email = aux.Contato.email;
                           
                            aux.Contato.nome = aux3.Contato.nome;
                            aux.Contato.telefone=aux3.Contato.telefone;
                            aux.Contato.email=aux3.Contato.email;
                           
                            aux3.Contato.nome=auxaux.Contato.nome;
                            aux3.Contato.telefone=auxaux.Contato.telefone;
                            aux3.Contato.email=auxaux.Contato.email;
                        }   
                    k++;
                    }
                k=0;
                }
            }
            else
            {
                return;
            }
        }
        public void Editar(int tipo)//mudança possivel
        {
           Node aux = new Node();
            if(tipo ==1)//Nome
            {
                System.Console.WriteLine("Digite o Nome do Usuario que deseja editar;");
                string nome = Console.ReadLine();
                aux = BuscarNome(nome);
                
                System.Console.WriteLine("\nDigite o novo Nome:");
                aux.Contato.nome=Console.ReadLine();

                System.Console.WriteLine("\nDigite o novo Telefone:");
                aux.Contato.telefone=Convert.ToInt32(Console.ReadLine());

                System.Console.WriteLine("\nDigite o novo e-mail:");
                aux.Contato.email=Console.ReadLine();  
            }
            if(tipo == 2)//telefone
            {
                System.Console.WriteLine("Digite o Telefone do Usuario que deseja editar;");
                int tel = Convert.ToInt32(Console.ReadLine());
                aux = BuscarTel(tel);
            
                System.Console.WriteLine("\nDigite o novo Nome:");
                aux.Contato.nome=Console.ReadLine();

                System.Console.WriteLine("\nDigite o novo Telefone:");
                aux.Contato.telefone=Convert.ToInt32(Console.ReadLine());

                System.Console.WriteLine("\nDigite o novo e-mail:");
                aux.Contato.email=Console.ReadLine();
            }
            if(tipo == 3)//email
            {
                {
                System.Console.WriteLine("Digite o E-Mail do Usuario que deseja editar;");
                string email = Console.ReadLine();
                aux = BuscarEmail(email);
                
                System.Console.WriteLine("\nDigite o novo Nome:");
                aux.Contato.nome=Console.ReadLine();

                System.Console.WriteLine("\nDigite o novo Telefone:");
                aux.Contato.telefone=Convert.ToInt32(Console.ReadLine());

                System.Console.WriteLine("\nDigite o novo e-mail:");
                aux.Contato.email=Console.ReadLine();  
                }
            }
            else
            {
                return;
            }
        }
        public Node BuscarTel(int numero)
        {
            Node aux = head;
            while ((aux != null) && (aux.Contato.telefone != numero))
            {
                aux = aux.next;
            }
            return aux;
        }
        public Node BuscarNome(string nome)
        {
            Node aux = head;
            while ((aux != null) && (aux.Contato.nome != nome))
            {
                aux = aux.next;
            }
            return aux;
        }
        public Node BuscarEmail(string email)
        {
            Node aux = head;
            while ((aux != null) && (aux.Contato.email != email))
            {
                aux = aux.next;
            }
            return aux;
        }
        public void BuscarUI()
        {
            int menu,compI;
            string comp;
            Node print;

            System.Console.WriteLine("Digite 1 -> para Buscar pelo Nome.\nDigite 2 -> Para Buscar pelo Numero.\nDigite 3 -> para Buscar pelo E-mail.\n------------------ -------------------- ----------------");
            menu=Convert.ToInt32(Console.ReadLine());

            if(menu == 1)
            {
                System.Console.WriteLine("------------------ -------------------- ----------------\nDigite o Nome que deseja Buscar.");
                comp = Console.ReadLine();
                print = BuscarNome(comp);
                System.Console.WriteLine($" Nome:{print.Contato.nome} \n Telefone:{print.Contato.telefone}\n e-mail:{print.Contato.email}");
            }
            if(menu == 2)
            {
                System.Console.WriteLine("------------------ -------------------- ----------------\nDigite o Numero que deseja Buscar.");
                compI = Convert.ToInt32(Console.ReadLine());
                print=BuscarTel(compI);
                System.Console.WriteLine($" Nome:{print.Contato.nome} \n Telefone:{print.Contato.telefone}\n e-mail:{print.Contato.email}");
            }
            if(menu == 3)
            {
                System.Console.WriteLine("------------------ -------------------- ----------------\nDigite o E-mail que deseja Buscar.");
                comp = Console.ReadLine();
                print=BuscarEmail(comp);
                System.Console.WriteLine($" Nome:{print.Contato.nome} \n Telefone:{print.Contato.telefone}\n e-mail:{print.Contato.email}");
            } 
            else
            {
                return;
            }
        }
        public int Contador()
        {
            Node aux = head;
            int cont = 0;
            while (aux != null)
            {
                aux = aux.next;
                cont++;
            }
            return cont;
        }  
        public bool IsEmpty()
        {
            return (head == null); 
        }
        public void Remove()

        {
           System.Console.WriteLine("Digite o Nome do Contato que deseja Remover");
           string nome = Console.ReadLine();
           Node alvo = BuscarNome(nome);
           
            if(IsEmpty())
            {
                return;
            }

            Node aux = head;
            Node Ant = null;

            while ( (aux != null ) && (aux != alvo))
            {
                Ant =aux;
                aux= aux.next;
            }
            if(Ant== null) //remover primero no
            {
                head = aux.next;
            }
            else
            {
                Ant.next = aux.next;
            }
        }
        public void Navegação() //tentar usar o break pra ficar mais bonito

        {
            var aux = head;

            while (aux != null)
            {
                System.Console.WriteLine("Aperte '->' para Navegar entre os Contato.\nOU\nAperte '<-' para Sair da Navegação");
                
                ConsoleKeyInfo keyInfo = Console.ReadKey();

                if (keyInfo.Key == ConsoleKey.RightArrow) 
                {
                    Console.WriteLine($"-------------------------------------------------\n Nome:{aux.Contato.nome} \n Telefone:{aux.Contato.telefone}\n e-mail:{aux.Contato.email}\n-------------------------------------------------");
                    aux = aux.next;
                }
                if(keyInfo.Key == ConsoleKey.LeftArrow)
                {  
                    System.Console.WriteLine("---------------Saindo da Navegação---------------");
                    aux = null;
                }
            }
        }
    }
}
