using System.IO;

class Organizer
{

    public static void OrganizarDownloads()
    {

        var files = Directory.GetFiles(System.Environment.ExpandEnvironmentVariables("%userprofile%/Downloads/"));

        List<string> extencoes = new List<string>();


        //verificar os arquivos que estão na pasta Downloads
        foreach (var f in files)
        {
            // Console.WriteLine(Path.GetExtension(f));

            if (!extencoes.Contains(Path.GetExtension(f))) extencoes.Add(Path.GetExtension(f));

        }

        //Verifica todas as extensoes que existem na pasta Downloads
        foreach (var ext in extencoes)
        {
            //Extensao do arquivo
            // Console.WriteLine(ext.Split('.')[1]);

            //Caminho a ser criado
            var pasta = Path.Combine(System.Environment.ExpandEnvironmentVariables("%userprofile%"), "Downloads", ext.Split('.')[1]);
            // Console.WriteLine(pasta);

            try
            {
                if (!Directory.Exists(pasta))
                {
                    Console.WriteLine("A pasta {0} não existe em Downloads", ext.Split(".")[1]);

                    DirectoryInfo di = Directory.CreateDirectory(pasta);

                    Console.WriteLine("Pasta Criada com sucesso em: {0}", pasta);
                }

            }
            catch (System.Exception)
            {

                throw;
            }
        }


        //mover arquivos

        //verificar os arquivos que estão na pasta Downloads
        foreach (var f in new DirectoryInfo(System.Environment.ExpandEnvironmentVariables("%userprofile%/Downloads/")).GetFiles())
        {

            // Console.WriteLine(f);

            var pastaDestino = Path.Combine(System.Environment.ExpandEnvironmentVariables("%userprofile%"), "Downloads", Path.GetExtension(f.ToString()).Split(".")[1]);


            Console.WriteLine("Movendo o arquivo {0}", f);
            Console.WriteLine("Pasta   ->   {0}", pastaDestino);




            f.MoveTo(Path.Combine(pastaDestino, f.Name));


        }




    }

}