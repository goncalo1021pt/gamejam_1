using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarSpawner : MonoBehaviour
{
    public GameObject Star;
    private float StarDensity = 8;
    private float timer = 0;
    // Start is called before the first frame update
    private int startingStars = 500;
    void Start()
    {
        while (startingStars-- > 0)
            Instantiate(Star, new Vector2(Random.Range(-Camera.main.orthographicSize * 2, Camera.main.orthographicSize * 2), Random.Range(-Camera.main.orthographicSize, Camera.main.orthographicSize)), transform.rotation, gameObject.transform);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < 1 / StarDensity)
            timer += Time.deltaTime;
        else
        {
            Instantiate(Star, new Vector2(transform.position.x + Random.Range(-Camera.main.orthographicSize * 2, Camera.main.orthographicSize * 2), transform.position.y), transform.rotation, gameObject.transform);
            timer = 0;
        }
    }
}
