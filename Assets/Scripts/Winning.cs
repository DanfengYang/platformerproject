using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winning : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D activator)

    {
        Debug.Log("in trigger");
        
        
        if (Input.GetKeyDown(KeyCode.Return))
        {
            FindObjectOfType<GameManager>().EndGame();
        }

    }
    void Update()
    {
        
    }
   

    

}
