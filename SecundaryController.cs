using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecundaryController : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 6f;
    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal2");
        float vertical = Input.GetAxisRaw("Vertical2");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
    
        if(direction.magnitude >= 0.1f) {

            controller.Move(direction.normalized * speed * Time.deltaTime);
        }
    }
}

