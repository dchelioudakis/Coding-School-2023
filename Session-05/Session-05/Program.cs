
using Session_05;


// Exercise #1

Console.WriteLine("Exercise #1");
NameReverse myName = new NameReverse();
Console.WriteLine(myName.Reverse());


// Exercise #2
string userNumber;
//Validate number
do
{
    Console.WriteLine("Exercise #2");
    Console.WriteLine("Give an integer equal to or greater than 1:");
    userNumber = Console.ReadLine();
} while (Convert.ToInt32(userNumber) < 1);

string option;
//Validate option
do
{
    Console.WriteLine("Exercise #2");
    Console.WriteLine(String.Format("For Sum of 1,...,{0} press 0", userNumber));
    Console.WriteLine(String.Format("For Product of 1,...,{0} press 1", userNumber));
    option = Console.ReadLine();
} while (Convert.ToInt32(option) != 0 && Convert.ToInt32(option) != 1);


SumOrProduct givenSumOrProduct = new SumOrProduct();
givenSumOrProduct.number = Convert.ToInt32(userNumber);
if (Convert.ToInt32(option) == 0)
{
    Console.WriteLine(String.Format("Sum of 1,...,{0} is {1}", userNumber, givenSumOrProduct.Sum()));
}
else
{
    Console.WriteLine(String.Format("Product of 1,...,{0} is {1}", userNumber, givenSumOrProduct.Product()));
}


Console.ReadLine();
