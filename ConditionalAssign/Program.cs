

Console.Write("Please Enter Your Score : ");


int yourScore = Convert.ToInt32(Console.ReadLine());


if (yourScore >= 10 && yourScore <= 30)
{
    Console.WriteLine("Fail");
}
else if (yourScore >= 40 && yourScore <= 60)
{
    Console.WriteLine("Credit");
}
else if (yourScore >= 70 && yourScore <= 80)
{
    Console.WriteLine("Distinction");
}
else
{
    Console.WriteLine("You can only score between 10-30, 40-60, 70-80");
}