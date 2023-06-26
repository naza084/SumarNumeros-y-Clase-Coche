namespace SumarNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
             Primera parte:

             Crear una función con tres parámetros que sean números que se suman entre sí.
             Llamar a la función en el main y darle valores.
            */


            //variables
            int a = 5, b = 3, c = 9;


            //sumamos
            Console.WriteLine($"{a} + {b} + {c} = " + SumarNums(a, b, c));



            /*
             Segunda parte:

             Crear una clase coche.
             Dentro de la clase coche, una variable numérica que almacene el número de puertas que tiene.
             Una función que incremente el número de puertas que tiene el coche.

             Crear un objeto miCoche en el main y añadirle una puerta.
             Mostrar el número de puertas que tiene el objeto.
             */



            //creamos la clase coche
            Coche coche1 = new(4);



            //incrementamos el numero de puertas
            coche1.IncrementarPuertas(2);


            //mostramos el numero de puertas
            Console.WriteLine(coche1.GetPuertas());



        }


        static int SumarNums(int a, int b, int c)
        {
            return a + b + c;
        }
    }


    class Coche
    {

        //atributo
        private int NumPuertas;


        //constructor
        public Coche(int numPuertas)
        {

            this.NumPuertas = numPuertas;
        }


        //metodos
        public void IncrementarPuertas(int incremento)
        {

            this.NumPuertas += incremento;
        }


        public string GetPuertas()
        {

            return $"Numero de puertas: {NumPuertas}";
        }
    }

}