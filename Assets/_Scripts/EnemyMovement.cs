using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.FirstPerson;

public class EnemyMovement : MonoBehaviour {

    [SerializeField]
    private float speed = 5f;
    private NavMeshAgent navMeshAgent;
    private FirstPersonController target;

    // Use this for initialization
    void Start () {
        navMeshAgent = GetComponent<NavMeshAgent>();
        target = FindObjectOfType<FirstPersonController>();
	}
	
	// Update is called once per frame
	void Update () {
        //navMeshAgent.SetDestination(target.transform.position);
	}
}
