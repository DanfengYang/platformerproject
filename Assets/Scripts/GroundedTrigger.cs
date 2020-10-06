using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundedTrigger : MonoBehaviour
{
    public Player myCharacter;
    void Start()
    {
       
    }
    //happens every frame there's an object inside this trigger
    void OnTriggerStay2D(Collider2D activator)
    {   if (Global.trigger1 == 0)
        {
            myCharacter.isGrounded = true;
        }
    }


    //happens the first frame when object leaves the trigger
    void OnTriggerExit2D(Collider2D activator)
    {
        if (Global.trigger1 == 0)
        {
            myCharacter.isGrounded = false;
        }
    }
    void Update()
    {
        if (Global.trigger1 == 1)
        {
            
            //Destroy(gameObject);
            
        }
    }
}
