using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D activator)
    {
        if(Input.GetKeyDown("space")){
            Debug.Log("released");
            //Global.coin += 1;
            //Debug.Log(Global.coin);
        }
    }
    void OnTriggerExit2D(Collider2D activator)
    {
        Destroy(gameObject);
    }
}
