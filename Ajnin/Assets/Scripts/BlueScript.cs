using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueScript : MonoBehaviour
{
    [SerializeField] private float leftCap;
    [SerializeField] private float rightCap;

    [SerializeField] private float walkspeed;
    private Collider2D coll;
    private Rigidbody2D rb;
    
    
    
    private bool facingRight = true;

    private void Start()
    {
        coll = GetComponent<Collider2D>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (facingRight)
        {
            //Test to see if we are beyond the rightcap
            if(transform.position.x > rightCap)
            {
                if (transform.localScale.x != -1)
                {
                    transform.localScale = new Vector3(-1, 1);
                }
            }
            else
            {
                facingRight = false;
            }
            //If it is not, we are going to face left
        }
    }
}
