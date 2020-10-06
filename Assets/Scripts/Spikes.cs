using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{


    void OnTriggerEnter2D(Collider2D activator)
    {
      Global.health --;
        Debug.Log(Global.health);

        }

    }

