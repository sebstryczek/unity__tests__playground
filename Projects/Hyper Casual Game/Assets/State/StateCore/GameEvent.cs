﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameEvent : ScriptableObject
{
    private List<GameEventListener> listeners = new List<GameEventListener>();

    public void Raise()
    {
        for (int i = this.listeners.Count - 1; i >= 0 ; i--)
        {
            listeners[i].OnEventRaised();
        }
    }

    public void RegisterListener(GameEventListener listener)
    {
        this.listeners.Add(listener);
    }

    public void UnregisterListener(GameEventListener listener)
    {
        this.listeners.Remove(listener);
    }
}
