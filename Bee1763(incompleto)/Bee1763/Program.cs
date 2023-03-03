//Solução dando TimeLimiteExceded. Já foi tentando percorrer o array um a um e introduzir uma consulta que não existe no array para gerar a mensagem "--- NOT FOUND ---"
//obtendo como resultado WrongAswer no Online Judge.

string[,] valuePairs = new string[24, 2]
{
    {"brasil", "Feliz Natal!"},
    {"alemanha", "Frohliche Weihnachten!"},
    {"austria",  "Frohe Weihnacht!"},
    {"coreia", "Chuk Sung Tan!" },
    {"espanha", "Feliz Navidad!"},
    {"grecia", "Kala Christougena!" },
    {"estados-unidos", "Merry Christmas!" },
    {"inglaterra", "Merry Christmas!" },
    {"australia", "Merry Christmas!" },
    {"portugal", "Feliz Natal!" },
    {"suecia", "God Jul!" },
    {"turquia", "Mutlu Noeller" },
    {"argentina", "Feliz Navidad!" },
    {"chile", "Feliz Navidad!" },
    {"mexico", "Feliz Navidad!" },
    {"antardida", "Merry Christmas!" },
    {"canada", "Merry Christmas!" },
    {"irlanda", "Nollaig Shona Dhuit!" },
    {"belgica", "Zalig Kerstfeest!" },
    {"italia", "Buon Natale!" },
    {"libia", "Buon Natale!" },
    {"siria", "Milad Mubarak!" },
    {"marrocos", "Milad Mubarak!" },
    {"japao", "Merii Kurisumasu!" }
};

bool Test = false;
TimeSpan Time = new TimeSpan(0, 0, 3);
DateTime End = new DateTime();
End = DateTime.Now.Add(Time);

while (End > DateTime.Now)
{
    string Data = Console.ReadLine();

    for (int i = 0; i < valuePairs.Length / 2; i++)
    {
        if (valuePairs[i, 0] == Data && End < DateTime.Now)
        {
            Console.WriteLine(valuePairs[i, 1]);
            Test = true;
            break;
        }
    }

    if (Test == false)
    {
        Console.WriteLine("--- NOT FOUND ---");
        if(End < DateTime.Now)
        {
            break;
        }
    }

    Test = false;
    if(End <= DateTime.Now)
    {
        break;
    }
}

