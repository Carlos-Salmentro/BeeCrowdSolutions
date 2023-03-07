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

while (true)
{
    string Data = Console.ReadLine();

    if(Data == null || Data == String.Empty)
    {
        break;
    }

    for (int i = 0; i < valuePairs.Length / 2; i++)
    {
        if (valuePairs[i, 0] == Data)
        {
            Console.WriteLine(valuePairs[i, 1]);
            Test = true;
            break;
        }
    }

    if(Test == false)
    {
        Console.WriteLine("--- NOT FOUND ---");
    }

    Test = false;
}



