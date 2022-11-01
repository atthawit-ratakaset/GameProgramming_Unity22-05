using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiBot : MonoBehaviour
{   
    [HideInInspector]
    public bool mustPatrol;

    public Rigidbody2D rb;

    public float walkSpeed;

    public LayerMask layer;

    public Collider2D myCollider;



    private void Start() 
    {
        mustPatrol = true;
    }

    private void Update() 
    {
        if (mustPatrol)
        {
            Patrol();
        }
    }

    private void Patrol()
    {
        if (myCollider.IsTouchingLayers(layer))
        {
            Flip(); 
        }
        rb.velocity = new Vector2(walkSpeed * Time.fixedDeltaTime, rb.velocity.y);
    }

    private void Flip()
    {   
        mustPatrol = false;
        transform.localScale = new Vector2(transform.localScale.x * -1, transform.localScale.y);
        walkSpeed *= -1;
        mustPatrol = true;
    }
}
