
using Session_05;


// Exercise #1

Console.WriteLine("Exercise #1");
NameReverse myName = new NameReverse();
Console.WriteLine(String.Format("My name reversed is: {0}", myName.Reverse()));


// Exercise #2

Console.WriteLine(Environment.NewLine + "Exercise #2");
string userNumber;
do
{
    Console.WriteLine("Give an integer equal to or greater than 1:");
    userNumber = Console.ReadLine();
} while (Convert.ToInt32(userNumber) < 1); //Validate number

string option;
do
{
    Console.WriteLine(String.Format("For Sum of 1,...,{0} press 0", userNumber));
    Console.WriteLine(String.Format("For Product of 1,...,{0} press 1", userNumber));
    option = Console.ReadLine();
} while (Convert.ToInt32(option) != 0 && Convert.ToInt32(option) != 1); //Validate option


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


// Exercise #3

Console.WriteLine(Environment.NewLine + "Exercise #3");

do
{
    Console.WriteLine("Give an integer equal to or greater than 1:");
    userNumber = Console.ReadLine();
} while (Convert.ToInt32(userNumber) < 1); //Validate number

PrimeNumbers userPrimeNumbers = new PrimeNumbers();
userPrimeNumbers.number = Convert.ToInt32(userNumber);
Console.WriteLine(String.Format("Prime Numbers from 1 to {0} are: {1}", userNumber, userPrimeNumbers.Calculate()));


// Exercise #4

Console.WriteLine(Environment.NewLine + "Exercise #4");
ArrayMultiplication myArrays = new ArrayMultiplication();
Console.WriteLine(String.Format("New Array is: {0}", myArrays.Get()));

// Exercise #5

Console.WriteLine(Environment.NewLine + "Exercise #5");
Console.WriteLine("Sorted Array is:");
ArraySort mySort = new ArraySort();
Console.WriteLine(mySort.Sort());

Console.ReadLine();
