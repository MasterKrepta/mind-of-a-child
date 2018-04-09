using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

[RequireComponent(typeof(SphereCollider))]
public class DetectPlayer : MonoBehaviour {

    private void OnTriggerEnter(Collider other) {
        if (other.GetComponent<FirstPersonController>()) {
            Debug.Log("player Detected");
        }
    }
}
