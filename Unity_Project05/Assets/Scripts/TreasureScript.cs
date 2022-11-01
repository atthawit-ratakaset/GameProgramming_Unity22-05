using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureScript : MonoBehaviour
{   
    [SerializeField] private AudioPlayer audioPlayer;
    [SerializeField] private SoAudioClips treasureAudioClips;
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
            audioPlayer.PlaySound(treasureAudioClips);
            Debug.Log("Get!");

            yield return new WaitForSeconds(1f);
            
            Destroy(gameObject);
        }
    }
    
}
