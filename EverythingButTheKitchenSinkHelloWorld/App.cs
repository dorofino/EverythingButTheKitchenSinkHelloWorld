using EverythingButTheKitchenSinkHelloWorldLibrary.BusinessLogic;

namespace EverythingButTheKitchenSinkHelloWorld;


public class App
{
    private readonly IMessages _message;

    public App(IMessages message)
    {
        _message = message;
    }
    
    // UltimageHelloWorld.exe -lang=es
    public void Run(string[] args)
    {
        string lang = "es";

        for (int i = 0; i < args.Length; i++)
        {
            if (args[i].ToLower().StartsWith("lang="))
            {
                lang = args[i].Substring(5);
            } 
        }

        string message = _message.Greeting(lang);
        
        Console.WriteLine(message);
    }   
}
