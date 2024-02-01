// 
int weekday = Convert.ToInt32(DateTime.Now.DayOfWeek); //0...6

switch(weekday)
{
    case 0:   //case 0 is same as if(weekday == 0)
        Console.WriteLine("It's Sunday.");
        break;
    case 1:
        Console.WriteLine("It's Monday.");
        break;
    case 2:
        Console.WriteLine("It's Tuesday.");
        break;
    case 3:
        Console.WriteLine("It's Wednesday, my dude!");
        break;
    case 4:
        Console.WriteLine("It's Thursday.");
        break;
    case 5:
        Console.WriteLine("TGIF!");
        break;
    case 6:
        Console.WriteLine("It's Saturday.");
        break;
    default:
        Console.WriteLine("Your calendar must be broken.");
        break;
}
Console.WriteLine("Thank you, come again!");
