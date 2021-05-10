using System;

namespace ATT_10_05_2021
{
    public class TelaBase
    {
        private string titulo;

        public string Titulo { get { return titulo; } }

        public TelaBase(string tit)
        {
            titulo = tit;
        }
        public virtual string CriarFormaGeometrica()
        {
            return "";
        }
        
        public virtual string ObterOpcao()
        {
            Console.WriteLine("Digite 1 para Criar Triangulo");
           

            Console.WriteLine("Digite S para sair");

            string opcao = Console.ReadLine();

            return opcao;
        }

    }
}
