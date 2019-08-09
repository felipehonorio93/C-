
using ByteBankImportacaoExportacao.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ByteBankImportacaoExportacao
{
    partial class Program
    {
        static void Main()
        {
            File.WriteAllText("escrevendoComAClasseFile.txt", "Testando File.WriteAllText");

            Console.WriteLine("Arquivo escrevendoComAClasseFile criado!");

            var bytesArquivo = File.ReadAllBytes("contas.txt");
            Console.WriteLine($"Arquivo contas.txt possui{ bytesArquivo.Length} bytes");


            var linhas = File.ReadAllLines("contas.txt");
            Console.WriteLine(linhas.Length);


            Console.WriteLine("Digite o seu nome:");
            var nome = Console.ReadLine();

            foreach (var linha in linhas)
            {
                Console.WriteLine(linha);
            }

            Console.WriteLine("Aplicação finalizada. . .");


            Console.ReadLine();
        }

    }
}