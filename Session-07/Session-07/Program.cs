// See https://aka.ms/new-console-template for more information
using Session_07;

Console.WriteLine("Give a String");
string? input = Console.ReadLine();
ActionEnum actionEnum = ActionEnum.Uppercase;

ActionRequest request = new ActionRequest(input, actionEnum);
ActionResponse response = new ActionResponse();

MessageLogger messageLogger = new MessageLogger();

ActionResolver resolver = new ActionResolver(messageLogger);

switch (actionEnum) {
    case ActionEnum.Uppercase: {

            break;
        }
    case ActionEnum.Reverse: {


            break;
        }

    default: {

            

            break;
        }
}

response = resolver.Execute(request);

Console.WriteLine(response.Output);

Console.ReadLine();





