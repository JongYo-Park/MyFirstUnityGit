using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    
    public float jumpPower;

    public Rigidbody rigid;

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigid.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }
    }
}
