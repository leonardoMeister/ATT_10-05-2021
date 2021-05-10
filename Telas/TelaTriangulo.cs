using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATT_10_05_2021.Telas
{
    public class TelaTriangulo : TelaBase 
    {
        public TelaTriangulo() : base("Tela Triangulos")
        {
            
        }
        public override string CriarFormaGeometrica()
        {
            Triangulo triangulo = new Triangulo();
            Console.Clear();
            Console.WriteLine("Informe o lado X");
            triangulo.LadoX = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o lado Y");
            triangulo.LadoY = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Informe o lado Z");
            triangulo.LadoZ = Convert.ToDouble(Console.ReadLine());

            string validacao = triangulo.ValidarTriangulo();

            if (validacao == "TRIANGULO_VALIDO")
            {
                Console.WriteLine("Valores Válidos");
                Console.WriteLine($"Tipo Do Triângulo: \n{triangulo.TipoTriangulo()}");
                Console.ReadLine();


            }else
            {
                Console.WriteLine(validacao);
                Console.ReadLine();
                Console.Clear();
                CriarFormaGeometrica();
            }

            return "";
        }

    }
}
