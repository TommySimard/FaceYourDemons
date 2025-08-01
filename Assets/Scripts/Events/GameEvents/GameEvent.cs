using System.Collections.Generic;
using UnityEngine;

public class GameEvent<T> : ScriptableObject
{
    private readonly List<IGameEventListener<T>> listeners = new();

    public void Raise(T item)
    {
        for (int i = listeners.Count - 1; i >= 0; i--)
        {
            listeners[i].OnEventRaised(item);
        }
    }

    public void RegisterListener(IGameEventListener<T> listener)
    {
        if (!listeners.Contains(listener))
        {
            listeners.Add(listener);
        }
    }

    public void UnregisterListener(IGameEventListener<T> listener)
    {
        if (listeners.Contains(listener))
        {
            listeners.Remove(listener);
        }
    }
}
