﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    public GameEvent gameEvent;
    public UnityEvent unityEvent;

    private void OnEnable()
    {
        gameEvent.RegisterListener(this);
    }

    private void OnDisable() {
        gameEvent.UnregisterListener(this);
    }

    public void OnEventRaised()
    {
        this.unityEvent.Invoke();
    }
}
