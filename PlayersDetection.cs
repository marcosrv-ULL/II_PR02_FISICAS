using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersDetection : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player1;
    public GameObject player2;
    public float DistanceGrows = 5.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distanceP1 = Vector3.Distance(transform.position, player1.transform.position);
        float distanceP2 = Vector3.Distance(transform.position, player2.transform.position);

        if (distanceP1 < DistanceGrows) {
            transform.localScale += new Vector3 (0.01f,0.01f,0.01f);
        }

        if (distanceP2 < DistanceGrows) {
            transform.localScale -= new Vector3 (0.01f,0.01f,0.01f);
        }
    }
}
