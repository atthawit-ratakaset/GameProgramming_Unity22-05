using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTeleporter : MonoBehaviour
{
    private GameObject currentTeleporter;

    private void Update() 
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (currentTeleporter != null)
            {
                transform.position = currentTeleporter.GetComponent<Teleporter>().GetDestination().position;
            }   
        }
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.CompareTag("Teleporter"))
        {
            currentTeleporter = other.gameObject;
            Debug.Log("Preessed E to use!");
        }
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        if (other.gameObject == currentTeleporter)
        {
            currentTeleporter = null;
        }
    }
}
