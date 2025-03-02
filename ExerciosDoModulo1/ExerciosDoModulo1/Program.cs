using System.Numerics;

class Program
{
    static void Main()
    {
        string nome;

        Console.WriteLine("Escolha uma opção (1 a 6):");
        Console.WriteLine("1 - Exibir boas-vindas.");
        Console.WriteLine("2 - Concatenar nome e sobrenome.");
        Console.WriteLine("3 - Calcular dois números.");
        Console.WriteLine("4 - Contar caracteres de uma frase.");
        Console.WriteLine("5 - Verificar a placa de um veículo.");
        Console.WriteLine("6 - Exibir a data e hora.");

        string opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                Console.Write("Digite seu nome para boas-vindas: ");
                nome = Console.ReadLine();
                ExibirBoasVindas(nome);
                break;

            case "2":
                Console.WriteLine("Qual é o seu nome?");
                nome = Console.ReadLine();

                Console.WriteLine("Qual é o seu sobrenome?");
                string Sobrenome = Console.ReadLine();

                ConcatenarNomeESobrenome(nome, Sobrenome);
                break;

            case "3":
                Console.WriteLine("Informe o número 1:");
                double N1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe o número 2:");
                double N2 = Convert.ToDouble(Console.ReadLine());

                CaluloDeDoisNumeros(N1, N2);
                break;

            case "4":
                Console.WriteLine("Escreva uma ou mais palavras:");
                string frase = Console.ReadLine();
                contadorDeCaracters(frase);
                break;

            case "5":
                Console.WriteLine("Digite a placa do veículo:");
                string placa = Console.ReadLine();
                Verificaplaca(placa);
                break;

            case "6":
                DateTime dataAtual = DateTime.Now;
                Console.WriteLine("Escolha uma opção para exibir a data e hora:");
                Console.WriteLine("1 - Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos).");
                Console.WriteLine("2 - Apenas a data no formato '01/03/2024'.");
                Console.WriteLine("3 - Apenas a hora no formato de 24 horas.");
                Console.WriteLine("4 - A data com o mês por extenso.");

                string opcaoData = Console.ReadLine();
                ExibirDataFormatada(dataAtual, opcaoData);
                break;

            default:
                Console.WriteLine("Opção inválida.");
                break;
        }

    }

    
    static void ExibirBoasVindas(string nome)
    {
        Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo!");
    }

    static void ConcatenarNomeESobrenome(string nome, string Sobrenome)
    {
        string nomeCompleto = nome + " " + Sobrenome;
        Console.WriteLine($"Olá, {nomeCompleto}! Seja muito bem-vindo!");

    }

    static void CaluloDeDoisNumeros(double N1,double N2)
    {
        double soma = N1 + N2;
        Console.WriteLine("A Soma: " + soma);

        double subtracao = N1 - N2;
        Console.WriteLine("A Subtraçao: " + subtracao);

        double multplicacao = N1 * N2;
        Console.WriteLine("A multpicaçao: " + multplicacao);

        if (N2!=0)
        {
            double Divi = N1 / N2;
            Console.WriteLine("A divisao: " + Divi);
        }
        else
        {
            Console.WriteLine("nao e possivel dividir por zero");
        }

        double Media = (N1 + N2) / 2;
        Console.WriteLine("A media: " + Media);
    }

    static void contadorDeCaracters(string Frase)
    {
        int contador = 0;
        foreach (char Caracteres in Frase)
        {
            if (Caracteres!=' ')
            {
                contador++;
            }
        }
        Console.WriteLine($"A quantidade de caracteres (sem os espaços) é: {contador}");
    }

    static void Verificaplaca(string Placa)
    {
        if (Placa.Length == 7)
        {
          
            string letras = Placa.Substring(0, 3); 
            string numeros = Placa.Substring(4);

            if (Vefificaletras(letras) && verificaNumeros(numeros))
            {
                Console.WriteLine("Verdadeiro");
            }
            else
            {
                Console.WriteLine("Falso");
            }
        }
        else
        {
            Console.WriteLine("Falso");
        }


    }

    static bool Vefificaletras(string letras)
    {
        foreach (char L in letras)
        {
            if (!Char.IsLetter(L)) return false;
        }
        return true;
    }
    static bool verificaNumeros(string Numeros)
    {
        foreach (char N in Numeros)
        {
            if (!Char.IsDigit(N)) return false;
        }
        return true;
    }


    static void ExibirDataFormatada(DateTime data, string opcao)
    {
       
        switch (opcao)
        {
            case "1":
                // Formato completo (dia da semana, dia do mês, mês, ano, hora, minutos, segundos)
                Console.WriteLine("Formato completo: " + data.ToString("dddd, dd MMMM yyyy HH:mm:ss"));
                break;

            case "2":
                // Apenas a data no formato "01/03/2024"
                Console.WriteLine("Apenas a data: " + data.ToString("dd/MM/yyyy"));
                break;

            case "3":
                // Apenas a hora no formato de 24 horas
                Console.WriteLine("Apenas a hora: " + data.ToString("HH:mm"));
                break;

            case "4":
                // Data com o mês por extenso
                Console.WriteLine("Data com o mês por extenso: " + data.ToString("dd 'de' MMMM 'de' yyyy"));
                break;

            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }










}
