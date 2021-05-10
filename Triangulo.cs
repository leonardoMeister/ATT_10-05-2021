using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATT_10_05_2021
{
    public class Triangulo
    {
        private int id;
        private double ladoX;
        private double ladoY;
        private double ladoZ;
        private static int idClass = 0;

        public double LadoX { get => ladoX; set => ladoX = value; }
        public double LadoY { get => ladoY; set => ladoY = value; }
        public double LadoZ { get => ladoZ; set => ladoZ = value; }
        public int Id { get => id; set => id = value; }

        public Triangulo(int id)
        {
            this.Id = id;
        }

        public Triangulo()
        {
            LadoX = 0;
            LadoY = 0;
            LadoZ = 0;
            Id = idClass;
            idClass++;
        }
        private String RegraExistencia()
        {
            /*
             10 – 9| < 5 < 10 + 9
            1 < 5 <19 (VERDADEIRO)

            |9 – 5| < 10 < 9 + 5
            4 < 10 < 14 (VERDADEIRO)

            |5 – 10| < 9 < 10 + 5
            5 < 9 < 15 (VERDADEIRO)

            | X - Z | < Y < X + Z
            | Y - Z | < X < Y + Z
            | Y - X | < Z < Y + X
             */
            // b = x
            // a = y
            // c = z

            if (!((ladoX - ladoZ) < LadoY && ladoY < (ladoX + ladoZ)))
            {
                return "Regra Existencia Invalida";
            }
            else if (!((LadoY - ladoZ) < LadoX && ladoX < (ladoY + ladoZ)))
            {
                return "Regra Existencia Invalida";
            }
            else if (!((LadoY - ladoX) < LadoZ && ladoZ < (ladoY + ladoX)))
            {
                return "Regra Existencia Invalida";
            }
            return "";
        }

        public String ValidarTriangulo()
        {
            string aux = "";

            if (ladoX == 0)
            {
                aux += "Valor X inválido\n";
            }
            if (ladoY == 0)
            {
                aux += "Valor y inválido\n";

            }
            if (ladoZ == 0)
            {
                aux += "Valor Z inválido\n";

            }

            aux += RegraExistencia();

            if (aux == "")
            {
                aux = "TRIANGULO_VALIDO";
            }

            return aux;
        }

        public String TipoTriangulo()
        {
            string aux = "";
            if (ladoZ != ladoY && ladoZ != ladoX && ladoX != ladoY)
            {
                aux = "Triângulo Escaleno";
            }
            else if (ladoZ == ladoY && ladoZ == ladoX && ladoY == ladoX)
            {
                aux = "Triângulo Equilátero";
            }
            else if ((ladoX == ladoY) || (ladoX == ladoZ) || (ladoZ == ladoY))
            {
                aux = "Triângulo Isósceles";
            }
            else
            {
                aux = "Triangulo Indefinido ou Inválido";
            }
            {/*
             Triângulo escaleno: Todos os lados e ângulos são diferentes.   

             Triângulo isósceles: dois lados iguais e os ângulos opostos a esses lados iguais.    

             Triângulo equilátero: Todos os lados e ângulos iguais. Concluímos que seus ângulos serão de 60°.
             */
            }//Regra negócio Triangulos
            return aux;
        }

    }
}
