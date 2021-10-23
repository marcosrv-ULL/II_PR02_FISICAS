using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "CylinderB" || other.gameObject.tag == "CylinderA" || other.gameObject.tag == "ScaryCylinder") {
            ScoreScript.ScoreValue += 100;
            other.gameObject.transform.localScale += new Vector3 (1,1,1);
        }
    }
}
