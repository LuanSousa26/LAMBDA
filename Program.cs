using System;

namespace LAMBDA
{
    class Program
    {

        /*
         Author: Luan Sousa
         */
        static void Main(string[] args)
        {

            /* 
                Expressões Lambda para realizar os métodos de multiplicação
                soma,subtração e divisão.
            */
            //Multiplicação
            Calculo Multiplicacao = (x, y) => x * y;
            //Soma
            Calculo Soma = (x, y) => x + y;
            //Subtração
            Calculo Subtracao = (x, y) => x - y;
            //Divisão
            Calculo Divisao = (x, y) => x / y;


            // o Evento Chama é instânciado com o Delegate Calculo e puxa o método Multiplicação
            Chama = new Calculo(Multiplicacao);
            //Faz a multiplicação e mostra no console
            Console.WriteLine(Chama(10, 9));

            // o Evento Chama é instânciado com o Delegate Calculo e puxa o método Soma
            Chama = new Calculo(Soma);
            //Faz a Soma e mostra no console
            Console.WriteLine(Chama(10, 9));

            // o Evento Chama é instânciado com o Delegate Calculo e puxa o método Subtração
            Chama = new Calculo(Subtracao);
            //Faz a Subtracao e mostra no console
            Console.WriteLine(Chama(10, 9));


            // o Evento Chama é instânciado com o Delegate Calculo e puxa o método Divisão
            Chama = new Calculo(Divisao);
            //Faz a Divisão e mostra no console
            Console.WriteLine(Chama(10, 9));





        }


        //Cria o delegate Calculo
        public delegate int Calculo(int Primeiro, int Segundo);
        //cria o evento do tipo Calculo Chama.   
        static event Calculo Chama;


    }
}
