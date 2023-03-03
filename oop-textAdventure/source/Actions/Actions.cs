namespace OOPAdventure;

public sealed class Actions
{
    private static Actions _instance;

    public static Actions Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Actions();
            }
                return _instance;
        }
    }

    private readonly Dictionary<string, Action> _registeredactions = new();
    private Actions()
    {

    }
    public void Register(Action action)
    {
        string name = action.Name.ToLower();

        if (_registeredactions.ContainsKey(name))
        {
            _registeredactions[name] = action;
        }
        else
        {
            _registeredactions.Add(name, action);
        }
    }
    public void Execute(string[] args)
    {
        var actionName = args[0];

        if(_registeredactions.ContainsKey(actionName))
        {
            _registeredactions[actionName].Execute(args);
        }
        else
        {
            Console.WriteLine(Text.Language.ActionError);
        }
    }
}
