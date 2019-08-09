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


        static void TestaFile()
        {

            using (var fluxodoArquivo = new FileStream("contas.txt", FileMode.Open))
            {

                var buffer = new byte[1024];// 1kb
                var numerodebytelidos = -1;

                while (numerodebytelidos != 0)
                {
                    numerodebytelidos = fluxodoArquivo.Read(buffer, 0, 1024);
                    Console.WriteLine($"Bytes lidos: {numerodebytelidos}");
                    EscreverBuffer(buffer, numerodebytelidos);


                }
            }
        }
                    static void EscreverBuffer(byte[] buffer, int byteslidos)
                    {

                    var utf8 = new UTF8Encoding();

                    var texto = utf8.GetString(buffer, 0, byteslidos);
                    Console.WriteLine(texto);

                    //foreach (var meubyte in buffer)
                    //{
                    //    Console.WriteLine(meubyte);
                    //    Console.WriteLine(" ");
                    //}

                    }


                   static void Testafluxo()
                   {
                    using (var fluxoDeArquivo = new FileStream("contas.txt", FileMode.Open))

                    using (var leitor = new StreamReader(fluxoDeArquivo))
                        while (!leitor.EndOfStream)
                        {
                            var linha = leitor.ReadLine();

                            Console.WriteLine(linha);
                        }
                    Console.ReadLine();
                   }



            
    }
}
