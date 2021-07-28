using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaracion de datos. 
            int produc;


            // Captura de datos. 

            Console.WriteLine("SELECCIONE EL TIPO DE PRODUCTO QUE DESEA LLEVAR: ");
            Console.WriteLine(" ");
            Console.WriteLine("-------------------------");
            Console.WriteLine("|       PRODUCTOS       |");
            Console.WriteLine("|-----------------------|");
            Console.WriteLine("|                       |");
            Console.WriteLine("|1- LACTEO              |");
            Console.WriteLine("|2- BELLEZA             |");
            Console.WriteLine("|3- SALUD               |");
            Console.WriteLine("|4- FRUTAS              |"); 
            Console.WriteLine("-------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("INGRESE QUE PRODUCTO DESEA LLEVAR: ");
            produc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");

            switch (produc)
            {
                case 1: Console.WriteLine("HAZ ELEGIDO PRODUCTOS LACTEO: ");
                    Console.WriteLine(" ");
                    Console.WriteLine("-----------------------");
                    Console.WriteLine("|PRODUCTOS DISPONIBLES|");
                    Console.WriteLine("|---------------------|");
                    Console.WriteLine("|1- Queso $3.50       |");
                    Console.WriteLine("|2- Cuajada $2.50     |");
                    Console.WriteLine("|3- Crema  $1.00      |");
                    Console.WriteLine("-----------------------");
                    Console.WriteLine(" ");
                    Console.WriteLine("QUE PRODUCTO DESEA LLEVAR: ");

                    // Declaracion de variables. 

                    int produc1;
                    double queso, cuajada, crema, impuesto, total;


                    queso = 3.50;
                    cuajada = 2.50;
                    crema = 1.00;
                    impuesto = 0.05;



                    produc1 = Convert.ToInt32(Console.ReadLine());

                    switch (produc1)
                    {
                        case 1: Console.WriteLine("HAZ ELEGIDO EL PRODUCTO QUESO $3.50 + IMPUESTO: ");

                            total = queso + impuesto;
                            Console.WriteLine(" ");
                            Console.WriteLine("TOTAL DE COMPRA ES: {0}", total);
                            break;

                        case 2: Console.WriteLine("HAZ ELEGIDO EL PRODUCTO CUAJADA $2.50 + IMPUESTO: ");
                            total = cuajada + impuesto;
                            Console.WriteLine(" ");
                            Console.WriteLine("TOTAL DE COMPRA ES: {0}", total);
                            break;

                        case 3: Console.WriteLine("HAZ ELEGIDO EL PRODUCTO CREMA $1.00 + IMPUESTO: ");
                            total = crema + impuesto;
                            Console.WriteLine(" ");
                            Console.WriteLine("TOTAL DE COMPRA ES {0}", total);
                            break;
                        default: Console.WriteLine("POR FAVOR INGRESAR UNA OPCION VALIDAD ");
                            break;
                    } break;

                case 2: Console.WriteLine("HAZ ELEGIDO PRODUCTOS BELLEZA: ");
                    Console.WriteLine(" ");
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("|PRODUCTOS DISPONIBLES    |");
                    Console.WriteLine("|-------------------------|");
                    Console.WriteLine("|1- Tinte de cabello $4.00|");
                    Console.WriteLine("|2- Maquillaje $3.00      |");
                    Console.WriteLine("|3- Ruby pinta labio $2.00|");
                    Console.WriteLine("---------------------------");
                    Console.WriteLine(" ");
                    Console.WriteLine("QUE PRODUCTO DESEA LLEVAR: ");

                    int produc2 = Convert.ToInt32(Console.ReadLine());

                    // Declaracion de variable. 

                    double tinte, maquillaje, ruby, impuesto2, total1;

                    tinte = 4.00;
                    maquillaje = 3.00;
                    ruby = 2.00;
                    impuesto2 = 0.15;

                    switch (produc2)
                    {
                        case 1:
                            Console.WriteLine("HAZ ELEGIDO EL PRODUCTO TINTE DE CABELLOS $4.00 + IMPUESTO");
                            total1 = tinte + impuesto2;
                            Console.WriteLine(" ");
                            Console.WriteLine("SU TOTAL ES: {0}", total1);
                            break;

                        case 2:
                            Console.WriteLine("HAZ ELEGIDO EL PRODUCTO MAQUILAJE + IMPUESTO");
                            total1 = maquillaje + impuesto2;
                            Console.WriteLine(" ");
                            Console.WriteLine("SU TOTAL ES: {0}", total1);
                            break;

                        case 3:
                            Console.WriteLine("HAZ ELEGIDO EL PRODUCTO RUBY PINTA LABIOS $4.00 + IMPUESTO");
                            total1 = ruby + impuesto2;
                            Console.WriteLine(" ");
                            Console.WriteLine("SU TOTAL ES: {0}", total1);
                            break;
                        default:
                            Console.WriteLine("POR FAVOR INGRESAR UNA OPCION VALIDAD ");
                            break;
                    }
                    break;

                case 3: Console.WriteLine("HAZ ELEGIDO PRODUCTOS SALUD: ");
                    Console.WriteLine(" ");
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("|PRODUCTOS DISPONIBLES    |");
                    Console.WriteLine("|-------------------------|");
                    Console.WriteLine("|1- ACETAMINOFE $2.00     |");
                    Console.WriteLine("|2- CONDONES VIVE $3.00   |");
                    Console.WriteLine("|3- CLOROPIRAMINA $2.00   |");
                    Console.WriteLine("---------------------------");
                    Console.WriteLine(" ");
                    Console.WriteLine("QUE PRODUCTO DESEA LLEVAR: ");



                    int produc3 = Convert.ToInt32(Console.ReadLine());

                    // Declaracion de variable. 

                    double impuesto3, ace, con, clo, total3;

                    impuesto3 = 0;
                    ace = 2.00;
                    con = 3.00;
                    clo = 2.00;



                    switch (produc3)
                    {
                        case 1: Console.WriteLine("HAZ ELEGIDO EL PRODUCTO ACETAMINOFE + IMPUESTO ");
                            total3 = ace + impuesto3;
                            Console.WriteLine(" ");
                            Console.WriteLine("SU TOTAL ES: {0}", total3);
                            break;
                        case 2:
                            Console.WriteLine("HAZ ELEGIDO EL PRODUCTO CONDONES VIVE + IMPUESTO ");
                            total3 = con + impuesto3;
                            Console.WriteLine(" ");
                            Console.WriteLine("SU TOTAL ES: {0}", total3);
                            break;
                        case 3:
                            Console.WriteLine("HAZ ELEGIDO EL PRODUCTO CLOROPIRAMINA + IMPUESTO ");
                            total3 = clo + impuesto3;
                            Console.WriteLine(" ");
                            Console.WriteLine("SU TOTAL ES: {0}", total3);
                            break;

                        default:
                            Console.WriteLine("POR FAVOR INGRESAR UNA OPCION VALIDAD");
                            break;
                    }
                    break;


                case 4: Console.WriteLine("HAZ ELEGIDO PRODUCTOS FRUTAS: ");
                    Console.WriteLine(" ");
                    Console.WriteLine("---------------------------");
                    Console.WriteLine("|PRODUCTOS DISPONIBLES    |");
                    Console.WriteLine("|-------------------------|");
                    Console.WriteLine("|1- MANZANA  $2.00        |");
                    Console.WriteLine("|2- UVAS          $3.00   |");
                    Console.WriteLine("|3- SANDIA         $2.00  |");
                    Console.WriteLine("---------------------------");
                    Console.WriteLine(" ");
                    Console.WriteLine("QUE PRODUCTO DESEA LLEVAR: ");

                    int produc4 = Convert.ToInt32(Console.ReadLine());

                    // Declaracion de variable. 

                    double maza, uva, san, impues4, total4;

                    maza = 2.00;
                    uva = 3.00;
                    san = 2.00;
                    impues4 = 0.05; 


                    switch (produc4)
                    {
                        case 1: Console.WriteLine("HAZ ELEGIDO EL PRODUCTO MANZANA $2.00 + IMPUESTO ");
                            total4 = maza + impues4;
                            Console.WriteLine(" ");
                            Console.WriteLine("SU TOTAL A PAGAR ES ${0}", total4); 
                            break;

                        case 2:
                            Console.WriteLine("HAZ ELEGIDO EL PRODUCTO MANZANA $2.00 + IMPUESTO ");
                            total4 = uva + impues4;
                            Console.WriteLine(" ");
                            Console.WriteLine("SU TOTAL A PAGAR ES ${0}", total4);
                            break;

                        case 3:
                            Console.WriteLine("HAZ ELEGIDO EL PRODUCTO MANZANA $2.00 + IMPUESTO ");
                            total4 = san + impues4;
                            Console.WriteLine(" ");
                            Console.WriteLine("SU TOTAL A PAGAR ES ${0}", total4);
                            break;
                        default:
                            Console.WriteLine("POR FAVOR INGRESAR UNA OPCION VALIDAD");
                            break; 
                    }
                    break;
                default: Console.WriteLine("POR FAVOR INGRESAR UNA OPCION VALIDAD "); break; 

            }


            Console.ReadKey(); 
        }
    }
}
