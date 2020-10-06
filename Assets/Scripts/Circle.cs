using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Circle : MonoBehaviour
{
    public Text myText;
    

    void OnTriggerEnter2D(Collider2D activator)
    {
        //if (Global.health < 20)
        //{
            Global.health = Global.health + 2;
            Debug.Log(Global.health);
        //}
        //if (Global.health >= 20)
        //{
            //Global.score = Global.score + 5;
            //Debug.Log(Global.score);
            
        //}
        
    }
        void OnTriggerExit2D(Collider2D activator)
        {
            Destroy(gameObject);
        }
    
}
