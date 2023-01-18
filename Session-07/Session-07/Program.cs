// See https://aka.ms/new-console-template for more information
using Session_07;

Console.WriteLine("Give a String:");
string? input = Console.ReadLine();
Console.Clear();
ActionEnum actionEnum = ActionEnum.Reverse;

ActionRequest request = new ActionRequest(input, actionEnum);
ActionResponse response = new ActionResponse();

MessageLogger messageLogger = new MessageLogger();

ActionResolver resolver = new ActionResolver(messageLogger);

response = resolver.Execute(request);
Console.WriteLine("---- Response ----");
Console.WriteLine(response.Output);

Console.WriteLine("---- Message Logger ----");
messageLogger.ReadAll();

Console.ReadLine();





