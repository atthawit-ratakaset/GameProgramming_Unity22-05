using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    private bool isFollowing;
    public float followSpeed;
    public Transform followTarget;

    void Update()
    {
        if (isFollowing)
        {
            transform.position = Vector3.Lerp(transform.position, followTarget.position, followSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.tag == "Player")
        {
            if(!isFollowing)
            {
                PlayerController thePlayer = FindObjectOfType<PlayerController>();
                followTarget = thePlayer.keyFollowPoint;
                isFollowing = true;
                thePlayer.followKey = this;
            }
        }    
    }
}   

