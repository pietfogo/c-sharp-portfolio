bool sair = false;

do
{
    Console.WriteLine("Bem-vindo ao currículo de Pietro Rodrigues!\n");
    Console.WriteLine("-1 Verificar idiomas");
    Console.WriteLine("-2 Verificar linguagens e tecnologias de programação");
    Console.WriteLine("-3 Sobre mim\n");
    Console.Write("Escolha uma opção que deseja saber mais sobre (ou 0 para sair): ");
    int NumeroEscolhido = int.Parse(Console.ReadLine());
    Console.WriteLine(" ");

    string[] idiomas = { "Inglês, intermediário/avançado", "Espanhol, básico", "Francês, básico/intermediário" };

    string[] linguagens = { "Javascript, avançado", "Python, básico", "C#, intermediário",
        "HTML5, avançado", "CSS3, intermediário", "ReactJs, básico/intermediário", "ChartGraths, avançado",
        "SQL, básico", "JSON, avançado", "NodeJs e terminais, intermediário" };

    if (NumeroEscolhido != 3 && NumeroEscolhido != 0)
    {
        Console.WriteLine("Nivelamento de conhecimento: \n\n-1 Básico\n-2 Intermediário\n-3 Avançado \n");
    }

    switch (NumeroEscolhido)
    {
        case 0:
            sair = true;
            break;
        case 1:
            Console.WriteLine("Idiomas de conhecimentos + o nivelamento: ");
            for (int i = 0; i < idiomas.Length; i++)
                Console.WriteLine("- " + idiomas[i]);
            break;
        case 2:
            Console.WriteLine("Linguagens de programação e tecnologias de conhecimento + nivelamento: \n");
            for (int i = 0; i < linguagens.Length; i++)
                Console.WriteLine("- " + linguagens[i]);
            break;
        case 3:
            Console.WriteLine("Tenho 17 anos, moro no Rio de Janeiro (capital), descobri e " +
                "imergi no ramo de desenvolvimento de software's faz 2 anos e ando procurando" +
                " vaga de programador trainee em alguma empresa em qualquer período meio horário");
            break;
        default:
            Console.WriteLine("Opção inválida. Por favor, escolha uma opção válida.");
            break;
    }

    Console.WriteLine();

} while (!sair);
