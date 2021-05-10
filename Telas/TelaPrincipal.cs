using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATT_10_05_2021.Telas
{
    class TelaPrincipal
    {
        public TelaPrincipal()
        {         
        }

        public TelaBase ObterOpcao()
        {
            TelaBase telaSelecionada = null;
            string opcao;
            do
            {
                Console.Clear();

                Console.WriteLine("Digite 1 para Triangulos");
               
                Console.WriteLine("Digite S para Sair");

                opcao = Console.ReadLine();

                if (opcao == "1")
                    telaSelecionada = new TelaTriangulo();

                else if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                    telaSelecionada = null;

            } while (OpcaoInvalida(opcao));

            return telaSelecionada;
        }

        private bool OpcaoInvalida(string opcao)
        {
            if (opcao != "1" && opcao != "S" && opcao != "s")
            {
                Console.WriteLine("Opção inválida");
                Console.ReadLine();
                return true;
            }
            else
                return false;
        }
    }
}
