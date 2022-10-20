using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureScript : MonoBehaviour
{
    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private IEnumerator OnCollisionEnter2D(Collision2D other) 
    {
        if (other.transform.CompareTag("Player"))
        {
            anim.SetBool("Get", true);
            Debug.Log("Get!");

            yield return new WaitForSeconds(2f);
            
            Destroy(gameObject);
        }
    }
    
}
