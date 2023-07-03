// See https://aka.ms/new-console-template for more information

// int x = 5;
// switch (x)
// {
//     case 1:
//     Console.WriteLine("Вы выбрали пункт меню 1.");
//     break;

//     case 2:
//     Console.WriteLine("Вы выбрали пункт меню 2.");
//     break;

//     default:
//     Console.WriteLine("Вы выбрали другой пункт меню.");
//     break;
// }



Console.WriteLine("Хотите ли Вы запустить проверку антивируса?");

    switch (Console.ReadLine())
    {
        case "да":
        Console.WriteLine("Выполняется проверка компьютера на вирусы.....Вирусы не обнаружены.");
        break;

        default:
        Console.WriteLine("Есть опасность заражения компьютера вирусами. Пожалуйста, выполните проверку.");
        break;
    }
 
