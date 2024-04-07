using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    private float timer = 0;
    private Vector2 newPosition;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < 0.01)
            timer += Time.deltaTime;
        else  
        {
            newPosition = transform.position;
            newPosition.y -= 0.05f;
            transform.position = newPosition;
            timer = 0;
        }
        if (transform.position.y < -2 * Camera.main.orthographicSize)
            Destroy(gameObject);
    }
}
