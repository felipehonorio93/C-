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

        static void CriarArquivo()
        {
            var caminhoNovoArquivo = "contasExportadas.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                var contaComoString = "456,7878,457.90,Felipe Honorio";
                var encoding = Encoding.UTF8;

                var bytes = encoding.GetBytes(contaComoString);

                fluxoDeArquivo.Write(bytes, 0, bytes.Length);

            }

        }

        static void CriarArquivoComWrite()
        {

            var caminhoDoArquivo = "contasExportadas.cvs";

            using (var fluxoDoArquivo = new FileStream(caminhoDoArquivo, FileMode.Create))

            using (var escritor = new StreamWriter(fluxoDoArquivo, Encoding.UTF8))
            {

                escritor.Write("2323,787687,567.90,lipe honorio");

            }

        }
        static void Teste()
        {
            var caminhoArquivo = "teste.txt";

            using (var fluxoDeArquivo = new FileStream(caminhoArquivo, FileMode.Create))
            using (var escritor = new StreamWriter(fluxoDeArquivo))
            {
                for (int i = 0; i < 1000000000; i++)
                {
                    escritor.WriteLine($"Linha{i}");

                    escritor.Flush();//despeja o buffer para o Stream!

                    Console.WriteLine($"Linha:{i}, foi escrita no arquivo. Tecle enter p adicionar mais uma!");
                    Console.ReadLine();
                }
            }

        }

    }
}
        

    

