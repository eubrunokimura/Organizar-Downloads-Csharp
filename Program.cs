class Program
{

    public enum Menu
    {
        sair = 0,
        organizarDownloads = 1
    }


    static void Main(String[] args)
    {

        int op = 1;


        do
        {

            //Limpar o Console
            Console.Clear();

            Console.WriteLine("Jarvis - Menu");

            Console.WriteLine("{0} - {1}", (int)Menu.organizarDownloads, Menu.organizarDownloads);


            Console.Write("Selecione a opção:");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case (int)Menu.organizarDownloads:
                    {
                        Console.WriteLine("Você selecionou a opção {0}", op);

                        Organizer.OrganizarDownloads();
                        break;
                    }

                case (int)Menu.sair:
                    {
                        Console.WriteLine("Você Escolheu sair...");
                        break;
                    }


                default:
                    {
                        Console.WriteLine("Opção Inválida!");
                        break;
                    }

            }


            Console.ReadKey();

        } while (op != 0);



    }
}