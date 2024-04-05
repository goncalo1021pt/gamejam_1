using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class x_wing : MonoBehaviour
{
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
            rb.velocity = Vector2.right * 5;
        else if (Input.GetKey(KeyCode.A))
            rb.velocity = Vector2.left * 5;
    }
}
