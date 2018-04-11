using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
using UnityEngine.AI;

[RequireComponent(typeof(SphereCollider))]
[RequireComponent(typeof(LineOfSight))]
public class DetectPlayer : MonoBehaviour {

    NavMeshAgent navMeshAgent;
    LineOfSight los;

    private void Awake() {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }
    private void OnTriggerEnter(Collider other) {
        if (other.GetComponent<FirstPersonController>()) {
            Debug.Log("player Detected");
            var canFire = los.TargetInSight();

            //navMeshAgent.SetDestination(other.transform.position);
        }
    }
}
