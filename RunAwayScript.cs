using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunAwayScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float runawayspeed = 7f;
    public GameObject player;
    public float enemyDistanceRun = 5.0f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.transform.position);

        if (distance < enemyDistanceRun) {
            Vector3 dirToplayer = transform.position - player.transform.position;
            //Vector3 newDir = transform + dirToplayer;
            dirToplayer[1] = 0f;
            transform.Translate(dirToplayer.normalized * runawayspeed * Time.deltaTime);
        }
    }
}
