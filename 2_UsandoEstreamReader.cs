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
        static void EstreamReader()
        {

            using (var fluxoDeArquivo = new FileStream("contas.txt", FileMode.Open))

            using (var leitor = new StreamReader(fluxoDeArquivo))
            {
                while (!leitor.EndOfStream)
                {
                    var linha = leitor.ReadLine();
                    var contaCorrente = ConverterStringParaContaCorrente(linha);

                    var msg = $"{contaCorrente.Titular.Nome}: Conta número {contaCorrente.Numero}, ag. {contaCorrente.Agencia}, Saldo {contaCorrente.Saldo} ";
                    Console.WriteLine(msg);

                }
                Console.ReadLine();

            }
        }
        static ContaCorrente ConverterStringParaContaCorrente(string linha)
        {
            string[] campos = linha.Split(' ');

            var agencia = campos[0];
            var numero = campos[1];
            var saldo = campos[2].Replace(".", ","); ;
            var nomeTitular = campos[3];

            var agenciaComInt = int.Parse(agencia);
            var numeroComInt = int.Parse(numero);
            var saldoComInt = double.Parse(saldo);

            var titular = new Cliente();
            titular.Nome = nomeTitular;

            var resultado = new ContaCorrente(agenciaComInt, numeroComInt);
            resultado.Depositar(saldoComInt);
            resultado.Titular = titular;

            return resultado;
        }

    }
}

