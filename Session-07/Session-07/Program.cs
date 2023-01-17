// See https://aka.ms/new-console-template for more information
using Session_07;

Guid requestId = Guid.NewGuid();
string? input = "Dimitris";
ActionEnum actionEnum = ActionEnum.Convert;

ActionRequest request = new ActionRequest(requestId, input, actionEnum);
ActionResponse response = new ActionResponse(requestId);
MessageLogger messageLogger = new MessageLogger();

var a = 5;



//ActionResolver resolver = new ActionResolver();

//response = resolver.Execute(request);

