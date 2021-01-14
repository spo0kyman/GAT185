using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class Player : MonoBehaviour
{
    float speed = 2.0f;
    
    void Update()
    {

        Vector3 velocity = Vector3.zero;

        velocity.x = Input.GetAxis("Horizontal");
        velocity.z = Input.GetAxis("Vertical");

        if (Input.GetButtonDown("Jump")) velocity.y = 100;

        transform.position += velocity * speed * Time.deltaTime;
    }
}
