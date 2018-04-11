using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

[RequireComponent (typeof(EventManager))]
public class GameManager : MonoBehaviour {


    EventManager eventManager;

    private void Awake() {
        eventManager = GetComponent<EventManager>();
    }

    private void OnEnable() {
        EventManager.OnKilled += PauseGamePlay;
    }
    private void OnDisable() {
        EventManager.OnKilled -= PauseGamePlay;
    }


    void PauseGamePlay() {
        Time.timeScale = 0;
        FirstPersonController fpc = FindObjectOfType<FirstPersonController>();
        fpc.enabled = false;
    }
}
