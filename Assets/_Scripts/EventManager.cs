using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour {


    public delegate void HealthEvents();
    public static HealthEvents OnKilled;

    private Dictionary<string, List<Component>> Listeners = new Dictionary<string, List<Component>>();
    private List<string> Events = new List<string>();

    public void AddEvent(string e) {
        if (!Events.Contains(e)) {
            Events.Add(e);
        }
    }

    public void CallEvent(Event e) {

    }
}
