using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformMovement : MonoBehaviour

{
    public float moveSpeed = 0.1f;
    public float moveLength = 0.1f;
    bool moveRight = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x > moveLength)
        {
            moveRight = false;
        }
        if (transform.position.x < moveLength)
        {
            moveRight = true;
        }

        if (moveRight)
        {
            transform.position = new Vector2(transform.position.x, transform.position.y + moveSpeed * Time.deltaTime);
        }
        else {
            transform.position = new Vector2(transform.position.x , transform.position.y - moveSpeed * Time.deltaTime);

        }
    }
}
