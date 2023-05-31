using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ex;
            Console.WriteLine("=======Menu=======");
            Console.WriteLine("\nExercicio 1");
            Console.WriteLine("Exercicio 2");
            Console.WriteLine("Exercicio 3");
            Console.WriteLine("Exercicio 4");
            Console.WriteLine("Exercicio 5");
            Console.WriteLine("Exercicio 6");
            Console.WriteLine("Exercicio 7");
            ex = int.Parse(Console.ReadLine());

            switch (ex)
            {


                case 1:

                    int quantidade, para = 4;
                    double preço, total1, total2 = 0;

                    for (int i = 0; ; i++)
                    {
                        Console.WriteLine("Qual a quantidade dos produtos");
                        quantidade = int.Parse(Console.ReadLine());
                        if (quantidade == 0)
                        {
                            break;
                        }
                        Console.WriteLine("Qual o preço do produto");
                        preço = double.Parse(Console.ReadLine());

                        Console.WriteLine("Digite 0 para SAIR e 3 para continuar");
                        para = int.Parse(Console.ReadLine());

                        total1 = quantidade * preço;
                        total2 = total1 + total2;
                    }

                    Console.WriteLine("Suas compra custou {0} reais ", total2);
                    break;

                case 2:

                    string nome, nomeMenor = "", nomeMaior = "";
                    int numItens, parada = 2;
                    float valor, maiorValor, menorValor;

                    maiorValor = float.MinValue;
                    menorValor = float.MaxValue;

                    for (; parada != 1;)
                    {
                        Console.WriteLine("Qual o nome do pruduto");
                        nome = Console.ReadLine();

                        Console.WriteLine("Qual a quantidade de produtos");
                        numItens = int.Parse(Console.ReadLine());

                        Console.WriteLine("Qual o preço do produto");
                        valor = float.Parse(Console.ReadLine());

                        float total = numItens * valor;
                        if (total > maiorValor)
                        {
                            maiorValor = total;
                            nomeMaior = nome;
                        }

                        if (total < menorValor)
                        {
                            menorValor = total;
                            nomeMenor = nome;
                        }
                        Console.WriteLine("Digite 1 para SAIR ou 2 para continuar");
                        parada = int.Parse(Console.ReadLine());


                    }
                    Console.WriteLine("Maior quantia investida {0} no produto {1} ", maiorValor, nomeMaior);
                    Console.WriteLine("Menor quantia investida {0} no produto {1} ", menorValor, nomeMenor);
                    break;

                case 3:
                    int somaPesoAvaliacoes = 0, totalAvaliacoes, pesoAvaliacao;

                    Console.WriteLine("Informe o total de avaliações do bimestre:");
                    totalAvaliacoes = int.Parse(Console.ReadLine());

                    if (totalAvaliacoes <= 0)
                        Console.WriteLine("Número de avaliações inválido!");

                    for (int i = 0; i < totalAvaliacoes; i++)
                    {
                        Console.WriteLine("Infome o peso da avalição {0}", i + 1);
                        pesoAvaliacao = int.Parse(Console.ReadLine());

                        somaPesoAvaliacoes += pesoAvaliacao;
                    }

                    if (somaPesoAvaliacoes < 100)
                        Console.WriteLine("O peso das avalições é Insuficiente!");
                    else if (somaPesoAvaliacoes > 100)
                        Console.WriteLine("O peso das avaliações é Excedente!");
                    else
                        Console.WriteLine("O peso das avaliações é Adequado.");
                    break;

                case 4:

                    string sigla;
                    Console.WriteLine("\nAM");
                    Console.WriteLine("AC");
                    Console.WriteLine("AL");
                    Console.WriteLine("AP");
                    Console.WriteLine("BA");
                    Console.WriteLine("CE");
                    Console.WriteLine("ES");
                    Console.WriteLine("GO");
                    Console.WriteLine("MA");
                    Console.WriteLine("MT");
                    Console.WriteLine("MS");
                    Console.WriteLine("MG");
                    Console.WriteLine("PA");
                    Console.WriteLine("PB");
                    Console.WriteLine("PR");
                    Console.WriteLine("PE");
                    Console.WriteLine("PI");
                    Console.WriteLine("RJ");
                    Console.WriteLine("RN");
                    Console.WriteLine("RS");
                    Console.WriteLine("RO");
                    Console.WriteLine("RR");
                    Console.WriteLine("SC");
                    Console.WriteLine("SE");
                    Console.WriteLine("TO");
                    Console.WriteLine("DF");

                    Console.WriteLine("\nQual a sigla você deseja usar");
                    sigla = Console.ReadLine();

                    switch (sigla)
                    {
                        case "AM":
                            Console.WriteLine("Amazonas");
                            break;
                        case "AC":
                            Console.WriteLine("Acre");
                            break;
                        case "AL":
                            Console.WriteLine("Alagoas");
                            break;
                        case "AP":
                            Console.WriteLine("Amapa");
                            break;
                        case "BA":
                            Console.WriteLine("Bahia");
                            break;
                        case "CE":
                            Console.WriteLine("Ceara");
                            break;
                        case "ES":
                            Console.WriteLine("Espirito Santo ");
                            break;
                        case "GO":
                            Console.WriteLine("Goias");
                            break;
                        case "MA":
                            Console.WriteLine("Maranhao");
                            break;
                        case "MT":
                            Console.WriteLine("Mato Grosso");
                            break;
                        case "MS":
                            Console.WriteLine("Mato Grosso do sul");
                            break;
                        case "MG":
                            Console.WriteLine("Minas Gerais");
                            break;
                        case "PA":
                            Console.WriteLine("Paraiba");
                            break;
                        case "PR":
                            Console.WriteLine("Parana");
                            break;
                        case "PE":
                            Console.WriteLine("Pernambuco");
                            break;
                        case "PI":
                            Console.WriteLine("Piaui");
                            break;
                        case "RJ":
                            Console.WriteLine("Rio de Janeiro");
                            break;
                        case "RN":
                            Console.WriteLine("Rio Grande do Norte");
                            break;
                        case "RS":
                            Console.WriteLine("Rio Grande do Sul");
                            break;
                        case "RO":
                            Console.WriteLine("Rondonia");
                            break;
                        case "RR":
                            Console.WriteLine("Roraima");
                            break;
                        case "SC":
                            Console.WriteLine("Santa Catrina");
                            break;
                        case "SE":
                            Console.WriteLine("Sergipe");
                            break;
                        case "TO":
                            Console.WriteLine("Tocantins");
                            break;
                        case "DF":
                            Console.WriteLine("Distrito Federal");
                            break;

                    }
                    break;

                case 5:

                    int mes, dia;
                    string estacao = "";
                    Console.WriteLine("1 - Janeiro");
                    Console.WriteLine("2 - Fevereiro");
                    Console.WriteLine("3 - Marco");
                    Console.WriteLine("4 - Abril");
                    Console.WriteLine("5 - Maio");
                    Console.WriteLine("6 - Junho");
                    Console.WriteLine("7 - Julho");
                    Console.WriteLine("8 - Agosto");
                    Console.WriteLine("9 - Setembro");
                    Console.WriteLine("10 - Outubro");
                    Console.WriteLine("11 - Novembro");
                    Console.WriteLine("12 - Dezembro");

                    Console.WriteLine("Qual o mes ? ");
                    mes = int.Parse(Console.ReadLine());

                    switch (mes)
                    {
                        case 1:
                        case 2:
                            estacao = "Verao";
                            break;
                        case 3:
                            Console.WriteLine("Informe o dia do mês:");
                            dia = int.Parse(Console.ReadLine());

                            if (dia < 21) estacao = "Verao";
                            else estacao = "Outono";
                            break;

                        case 4:
                        case 5:
                            estacao = "Outono";
                            break;
                        case 6:
                            Console.WriteLine("Informe o dia do mês:");
                            dia = int.Parse(Console.ReadLine());

                            if (dia >= 21) estacao = "Inverno";
                            else estacao = "Outono";
                            break;
                        case 7:
                        case 8:
                            estacao = "Inverno";
                            break;
                        case 9:
                            Console.WriteLine("Informe o dia do mês:");
                            dia = int.Parse(Console.ReadLine());

                            if (dia >= 23) estacao = "Primavera";
                            else estacao = "Inverno";
                            break;
                        case 10:
                        case 11:
                            estacao = "Primavera";
                            break;
                        case 12:
                            Console.WriteLine("Informe o dia do mês:");
                            dia = int.Parse(Console.ReadLine());

                            if (dia >= 22) estacao = "Verao";
                            else estacao = "Primavera";
                            break;
                    }
                    Console.WriteLine("A estacao do ano é {0}", estacao);
                    Console.ReadKey();
                    break;

                case 6:

                    float peso, altura, imc;
                    Console.WriteLine("Qual o seu peso ?");
                    peso = float.Parse(Console.ReadLine());
                    Console.WriteLine("Qual a sua altura ?");
                    altura = float.Parse(Console.ReadLine());

                    imc = peso / altura * altura;

                    if (imc <= 18.5)
                        Console.WriteLine("Abaixo do peso");
                    else if (imc <= 24.9 && imc >= 18.5)
                        Console.WriteLine("Peso normal");
                    else if (imc >= 25 && imc <= 29.5)
                        Console.WriteLine("Sobrepeso");
                    else if (imc >= 30 && imc <= 34.9)
                        Console.WriteLine("obesidade grau 1");
                    else if (imc >= 35 && imc <= 39.9)
                        Console.WriteLine("obsedidade grau 2");
                    else
                        Console.WriteLine("obsediade grau 3 (morbida)");
                    break;

                case 7:
                    int numero;
                    Console.WriteLine("Informe um número:");
                    numero = int.Parse(Console.ReadLine());

                    if (numero <= 0)
                        Console.WriteLine("O número informado deve ser maior que 0!");

                    string divisores = "";

                    for (int i = 1; i < numero + 1; i++)
                    {
                        if (numero % i == 0) divisores += i + " ";
                    }
                    break;

                default:
                    Console.WriteLine("Exercicio invalido");
                    break;

            }
        }

