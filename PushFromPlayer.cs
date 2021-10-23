using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushFromPlayer : MonoBehaviour
{
    public float pushawayspeed = 7f;
    public GameObject player;
    public float pushRange = 5.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(transform.position, player.transform.position);

        if (distance < pushRange && Input.GetKeyDown("space")) {
            Vector3 dirToplayer = transform.position - player.transform.position;
            //Vector3 newDir = transform + dirToplayer;
            dirToplayer[1] = 0f;
            transform.Translate(dirToplayer.normalized * pushawayspeed * 10 * Time.deltaTime);
        }
    }
}
