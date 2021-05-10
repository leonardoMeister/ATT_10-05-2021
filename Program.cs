using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ATT_10_05_2021.Telas;

namespace ATT_10_05_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            TelaPrincipal telaPrincipal = new TelaPrincipal();
            TelaTriangulo tela = new TelaTriangulo();
            while (true)
            {
                TelaBase telaSelecionada = telaPrincipal.ObterOpcao();

                if (telaSelecionada == null)
                    break;

                Console.Clear();

                Console.WriteLine(telaSelecionada.Titulo); Console.WriteLine();

                string opcao = tela.ObterOpcao();
                    

                if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                    continue;

                if (opcao == "1")

                    telaSelecionada.CriarFormaGeometrica();

               

                Console.Clear();
            }
        }
    }
}
