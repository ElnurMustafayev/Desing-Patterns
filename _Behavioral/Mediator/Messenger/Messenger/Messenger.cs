using Messenger.Messages.Base;
using Messenger.Messenger.Base;

namespace Messenger.Messenger;

public class Messenger : IMessenger
{
    private static Dictionary<Type, List<Action<IMessage>>> actions;

    static Messenger()
    {
        actions = new Dictionary<Type, List<Action<IMessage>>>();
    }

    public void Subscribe<T>(Action<IMessage> action) where T : IMessage
    {
        var key = typeof(T);
        if (actions.ContainsKey(key) == false)
            actions.Add(key, new List<Action<IMessage>>());

        actions[key].Add(action);
    }

    public void Send<T>(T message) where T : IMessage
    {
        var key = typeof(T);
        if (actions.ContainsKey(key) == false)
            return;

        actions[key].ForEach(action => action?.Invoke(message));
    }
}