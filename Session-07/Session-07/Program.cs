// See https://aka.ms/new-console-template for more information
using Session_07;


string? input = Console.ReadLine();
ActionEnum actionEnum = ActionEnum.Convert;

ActionRequest request = new ActionRequest(input, actionEnum);
ActionResponse response = new ActionResponse();

MessageLogger messageLogger = new MessageLogger();

ActionResolver resolver = new ActionResolver(messageLogger);

response = resolver.Execute(request);



Console.ReadLine();





