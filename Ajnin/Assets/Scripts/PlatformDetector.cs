﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlatformDetector : MonoBehaviour
{
    public Transform player;
    public bool isGrounded;
    public bool check;
    void Update()
    {
        //public static bool m_Grounded;
       

        if(isGrounded != true)
        {
            check = false;
        }

        if(check != true)
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, .125f);

            if(hit.collider != null)
            {
                if (hit.collider.CompareTag("MovingPlatform2"))
                {
                    player.SetParent(hit.transform);
                }
                else
                {
                    player.SetParent(null);
                }
                check = true;
            }
        }
    }
}
