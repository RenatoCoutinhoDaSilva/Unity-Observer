using System;
using System.Collections.Generic;
using UnityEngine;

public class Observer : MonoBehaviour
{
    // This observer is still a Singleton to optimize performance.
    public static Observer Instance;

    private void Awake() {
        if (Instance == null)
            Instance = this;
        else
            Destroy(this);
    }

    private HashSet<Action> Callbacks = new HashSet<Action>();

    public void AddCallback(Action callback) {
        Callbacks.Add(callback);
    }
    public bool RemoveCallback(Action callback) {
        return Callbacks.Remove(callback);
    }

    public void Invoke() {
        foreach(var callback in Callbacks) {
            callback.Invoke();
        }
    }
}
