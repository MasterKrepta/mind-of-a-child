using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour, IDamageable {

    [SerializeField]
    private float currentHealth;

    [SerializeField]
    private float maxHealth = 10;

    public float CurrentHealth {
        get {
            return currentHealth;
        }

        set {
            currentHealth = value;
            if (currentHealth <= 0) {
                EventManager.OnKilled();
            }
        }
    }

    // Use this for initialization
    void Start () {
        CurrentHealth = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TakeDamage(float amnt) {
        CurrentHealth -= amnt;
    }
}
