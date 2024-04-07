using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarMotion : MonoBehaviour
{
    private float timer = 0;
    private Vector2 newPosition;
    // Start is called before the first frame update
    void Start()
    {
        transform.localScale *= Random.Range(0.2f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < 0.01)
            timer += Time.deltaTime;
        else  
        {
            newPosition = transform.position;
            newPosition.y -= 0.01f;
            transform.position = newPosition;
            timer = 0;
        }
        if (transform.position.y < -Camera.main.orthographicSize)
            Destroy(gameObject);
    }
}
