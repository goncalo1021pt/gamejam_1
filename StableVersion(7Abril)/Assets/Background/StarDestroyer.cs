using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarDestroyer : MonoBehaviour
{
    public float DestroyerTime = 240;
    public bool flag = true;
    public float timer = 0;
    private Vector2 newPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        if (flag && timer < DestroyerTime)
            timer += Time.deltaTime;
        else  
        {
            flag = false;
            newPosition = transform.position;
            newPosition.y -= 0.01f;
            transform.position = newPosition;
            timer = 0;
            DestroyerTime = 0.01f;
        }
        if (transform.position.y < -Camera.main.orthographicSize * 2)
            Destroy(gameObject);
    }
}
