using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lista3PR2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.WriteLine("=====MENU=====");
            Console.WriteLine("1 - exercício 1");
            Console.WriteLine("2 - exercício 2");
            Console.WriteLine("3 - exercício 3");
            Console.WriteLine("4 - exercício 4");
            Console.WriteLine("5 - exercício 5");
            Console.WriteLine("6 - exercício 6");
            Console.WriteLine("Digite a opção desejada");

            n = int.Parse(Console.ReadLine());
            switch (n)
            {
                case 1:
                    int diaDaSemana;
                    Console.WriteLine("Digite o dia da semana");


                    diaDaSemana = int.Parse(Console.ReadLine());

                    switch (diaDaSemana)
                    {

                        case 1:
                            Console.WriteLine("Domingo");
                            break;

                        case 2:
                            Console.WriteLine("Segunda-feira");
                            break;

                        case 3:
                            Console.WriteLine("Terça-feira");
                            break;

                        case 4:
                            Console.WriteLine("Quarta-feira");
                            break;

                        case 5:
                            Console.WriteLine("Quinta-feira");
                            break;

                        case 6:
                            Console.WriteLine("Sexta-feira");
                            break;

                        case 7:
                            Console.WriteLine("Sabado");
                            break;

                        default:
                            Console.WriteLine("Opção inválida");
                            break;



                    }

                    Console.ReadKey();
                    break;

                case 2:

                    float TotalCompra, PreçoFinal;
                    int formaDePagamento;

                    Console.WriteLine("Digite a forma de pagamento de sua preferência");

                    Console.WriteLine("=====MENU=====");
                    Console.WriteLine("1- Á vista");
                    Console.WriteLine("2- No pix");
                    Console.WriteLine("3- Débito");
                    Console.WriteLine("4- Cartão de crédito");


                    formaDePagamento = int.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o total de sua compra");
                    TotalCompra = int.Parse(Console.ReadLine());


                    switch (formaDePagamento)
                    {
                        case 1:
                            Console.WriteLine("1-á vista");
                            PreçoFinal = TotalCompra * 0.15f;
                            break;

                        case 2:
                            Console.WriteLine("No pix");
                            PreçoFinal = TotalCompra * 0.10f;
                            break;

                        case 3:
                            Console.WriteLine("Débito");
                            PreçoFinal = (TotalCompra * 0.15f) + TotalCompra;

                            break;

                        case 4:
                            Console.WriteLine("Cartão de crédito");
                            PreçoFinal = (TotalCompra * 0.15f) + TotalCompra;

                            break;

                           


                    }
                    Console.ReadKey();
                    break;

                case 3:
                    int mês, ano;
                    Console.WriteLine("Digite o ano");
                    Console.WriteLine("=====MENU=====");
                    Console.WriteLine("1- Janeiro");
                    Console.WriteLine("2- fevereiro");
                    Console.WriteLine("3- março");
                    Console.WriteLine("4- abriu");
                    Console.WriteLine("5 - maio");
                    Console.WriteLine("6 - junho");
                    Console.WriteLine("7 - julho");
                    Console.WriteLine("8 - agosto");
                    Console.WriteLine("9 - setembro");
                    Console.WriteLine("10 - outubro");
                    Console.WriteLine("11 - novembro");
                    Console.WriteLine("12 - desembro");


                    mês = int.Parse(Console.ReadLine());
                    switch (mês)
                    {

                        case 1:
                            Console.WriteLine("Janeiro possui 31 dias");
                            break;
                        case 2:
                            Console.WriteLine("Fevereiro possui 28 dias");
                            break;
                        case 3:
                            Console.WriteLine("Março possui 31 dias");
                            break;
                        case 4:
                            Console.WriteLine("Abriu possui 30 dias");
                            break;
                        case 5:
                            Console.WriteLine("Maio possui 31 dias");
                            break;
                        case 6:
                            Console.WriteLine("Junho possui 30 dias");
                            break;
                        case 7:
                            Console.WriteLine("Julho possui 31 dias");
                            break;
                        case 8:
                            Console.WriteLine("Agosto possui 31 dias");
                            break;
                        case 9:
                            Console.WriteLine("Setembro possui 30 dias");
                            break;
                        case 10:
                            Console.WriteLine("Outubro possui 31 dias");
                            break;
                        case 11:
                            Console.WriteLine("Novembro possui 30 dias");
                            break;
                        case 12:
                            Console.WriteLine("Desembro possui 31 dias");
                            break;

                           


                    }
                    Console.ReadKey();
                    break;


                case 4:
                    float v1, v2, op, result;
                    double Potencia;

                    Console.WriteLine("Digite uma operação");

                    Console.WriteLine("======Menu=====");
                    Console.WriteLine("1- + ");
                    Console.WriteLine("2- - ");
                    Console.WriteLine("3- * ");
                    Console.WriteLine("4- / ");
                    Console.WriteLine("5- ^ ");
                    op = float.Parse(Console.ReadLine());

                    Console.WriteLine("Digite a 1° valor");
                    v1 = float.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a 2° valor");
                    v2 = float.Parse(Console.ReadLine());


                    switch (op)
                    {
                        case 1:
                            result = v1 + v2;
                            Console.WriteLine(result);
                            break;


                        case 2:
                            result = v1 - v2;
                            Console.WriteLine(result);
                            break;


                        case 3:
                            result = v1 * v2;
                            Console.WriteLine(result);
                            break;



                        case 4:
                            result = v1 / v2;
                            Console.WriteLine(result);
                            break;



                        case 5:
                            Potencia = Math.Pow(v1, v2);
                            Console.WriteLine(Potencia);

                            break;

                        default:

                            Console.WriteLine("É incompatível");



                            break;
                    }

                    Console.ReadKey();

                    break;


                case 5:
                    float cargo, salario, aumento, diferenca;
                    Console.WriteLine("======Menu=====");
                    Console.WriteLine("1- Professor");
                    Console.WriteLine("2- secretário");
                    Console.WriteLine("3- Publicitario");
                    Console.WriteLine("4- Jornalista");
                    Console.WriteLine("5- Mecânico");
                    Console.WriteLine("6- Estagiario");
                    Console.WriteLine("7- Tecnico em TI");

                    cargo = float.Parse(Console.ReadLine());

                    switch (cargo)
                    {





                        case 1:
                            Console.WriteLine("Digite o seu salario atual:");

                            salario = float.Parse(Console.ReadLine());
                            aumento = salario + (salario * 0.075f);
                            diferenca = aumento - salario;
                            Console.WriteLine("O seu salario sera:" + aumento + "A diferença entre um salário e outro é de:" + diferenca);
                            break;

                        case 2:
                            Console.WriteLine("Digite o seu salario atual:");

                            salario = float.Parse(Console.ReadLine());
                            aumento = salario + (salario * 0.097f);
                            diferenca = aumento - salario;
                            Console.WriteLine("O seu salario sera:" + aumento + "A diferença entre um salário e outro é de:" + diferenca);
                            break;

                        case 3:
                            Console.WriteLine("Digite o seu salario atual:");

                            salario = float.Parse(Console.ReadLine());
                            aumento = salario + (salario * 0.117f);
                            diferenca = aumento - salario;
                            Console.WriteLine("O seu salario sera:" + aumento + "A diferença entre um salário e outro é de:" + diferenca);
                            break;

                        case 4:
                            Console.WriteLine("Digite o seu salario atual:");

                            salario = float.Parse(Console.ReadLine());
                            aumento = salario + (salario * 0.089f);
                            diferenca = aumento - salario;
                            Console.WriteLine("O seu salario sera:" + aumento + "A diferença entre um salário e outro é de:" + diferenca);
                            break;

                        case 5:
                            Console.WriteLine("Digite o seu salario atual:");

                            salario = float.Parse(Console.ReadLine());
                            aumento = salario + (salario * 0.1324f);
                            diferenca = aumento - salario;
                            Console.WriteLine("O seu salario sera:" + aumento + "A diferença entre um salário e outro é de:" + diferenca);
                            break;

                        case 6:
                            Console.WriteLine("Digite o seu salario atual:");

                            salario = float.Parse(Console.ReadLine());
                            aumento = salario + (salario * 0.104f);
                            diferenca = aumento - salario;
                            Console.WriteLine("O seu salario sera:" + aumento + "A diferença entre um salário e outro é de:" + diferenca);
                            break;

                        case 7:
                            Console.WriteLine("Digite o seu salario atual:");

                            salario = float.Parse(Console.ReadLine());
                            aumento = salario + (salario * 0.146f);
                            diferenca = aumento - salario;
                            Console.WriteLine("O seu salario sera:" + aumento + "A diferença entre um salário e outro é de:" + diferenca);
                            break;

                        default:
                            Console.WriteLine("Digite o seu salário atual");
                            salario = float.Parse(Console.ReadLine());
                            aumento = salario + (salario * 0.435f);
                            diferenca = aumento - salario;
                            Console.WriteLine("O seu salario sera:" + aumento + "A diferença entre um salário e outro é de:" + diferenca);
                            break;
                    }


                    Console.ReadKey();


                    break;


                case 6:
                    double SB, SL, desconto;
                    Console.WriteLine("Digite o seu salário bruto");
                    SB = double.Parse(Console.ReadLine());

                    if (SB <= 1903.98)

                    {
                        Console.WriteLine("O seu salário bruto é isento de imposto de renda");
                    }

                    else if (SB >= 1903.99 && SB <= 2826.65)

                    {

                        desconto = SB * 0.075;
                        SL = SB - desconto;


                        Console.WriteLine("O seu salário líquido será de:" + SL +
                          " O valor do desconto foi de:" + desconto);
                    }


                    else if (SB >= 2826.66 && SB <= 3751.05)

                    {

                        desconto = SB * 0.15;
                        SL = SB - desconto;


                        Console.WriteLine("O seu salário líquido será de:" + SL + "O valor do desconto foi de:" + desconto);
                    }




                    else if (SB >= 3751.06 && SB <= 4664.68)

                    {

                        desconto = SB * 0.225;
                        SL = SB - desconto;


                        Console.WriteLine("O seu salário líquido será de:" + SL + "O valor do desconto foi de:" + desconto);
                    }


                    else if (SB >= 4664.68)

                    {

                        desconto = SB * 0.275;
                        SL = SB - desconto;


                        Console.WriteLine("O seu salário líquido será de:" + SL + "O valor do desconto foi de:" + desconto);
                    }

                    Console.ReadKey();



                    break;

            }
            









        }
    }
}
