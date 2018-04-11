using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineOfSight : MonoBehaviour {

    [SerializeField]
    Transform barrel;

    float sightDistance = 100f;

 
    public bool TargetInSight() {
        bool inSight = false;
        Ray view = new Ray(barrel.position, barrel.forward);
        RaycastHit hitInfo;
        if(Physics.Raycast(view, out hitInfo, sightDistance)) {
            Debug.Log(hitInfo.collider.name);
            if (hitInfo.collider.GetComponent<IDamageable>() != null) {
                inSight = true;

            }
        }
        return inSight;
    }
}
