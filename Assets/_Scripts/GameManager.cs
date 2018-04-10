using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent (typeof(EventManager))]
public class GameManager : MonoBehaviour {


    EventManager eventManager;

    private void Awake() {
        eventManager = GetComponent<EventManager>();
        
    }


}
