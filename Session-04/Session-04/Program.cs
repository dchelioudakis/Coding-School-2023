// See https://aka.ms/new-console-template for more information

using Session_04;

// Exercise #1
Console.WriteLine("Exercise #1\n");
PersonalGreeting dimitrisGreeting = new PersonalGreeting();
Console.WriteLine(dimitrisGreeting.Create());

// Exercise #2
Console.WriteLine("\n\nExercise #2\n");
SumAndDivision mySumAndDivision = new SumAndDivision();
Console.WriteLine(mySumAndDivision.GetSum());
Console.WriteLine(mySumAndDivision.GetDivision());

// Exercise #3
Console.WriteLine("\n\nExercise #3\n");
MixedCalculations myMixedCalculations = new MixedCalculations();
Console.WriteLine(myMixedCalculations.Get());

// Exercise #4
Console.WriteLine("\n\nExercise #4\n");
SupriseMessage mySurpriseMessage = new SupriseMessage();
Console.WriteLine(mySurpriseMessage.Get());

// Exercise #5
SecondsConversion myConversion = new SecondsConversion();
myConversion.Calculate();

// Exercise #6
SecondsConversionRevision myConversionRevisioned = new SecondsConversionRevision();
myConversionRevisioned.Calculate();

// Exercise #7
CelciusConversion myDegreesConversion = new CelciusConversion();
myDegreesConversion.Calculate();

Console.ReadLine();
