//is num odd or even
Console.WriteLine("Please enter number:");
int userNum = Convert.ToInt32(Console.ReadLine());

int result = userNum % 2;

if (result != 0) //not equal to
{
    Console.WriteLine("User number is odd.");
} else
{
    Console.WriteLine("User number is even.");
}

