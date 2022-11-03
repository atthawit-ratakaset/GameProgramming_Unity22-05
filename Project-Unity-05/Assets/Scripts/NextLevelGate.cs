using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevelGate : MonoBehaviour
{
    private const string PlayerTag = "Player";
    private GameManager _gameManager;
    private PlayerController thePlayer;
    public bool waitingKey, openGate;
    public SpriteRenderer theSR;
    public Sprite gateOpenSprite;
    [SerializeField] private AudioPlayer audioPlayer;
    [SerializeField] private SoAudioClips openAudioClips;
    private void Start()
    {   
        FindGameManager();
        thePlayer = FindObjectOfType<PlayerController>();
    }
    private void Update() 
    {
        if (waitingKey)
        {
            if (Vector3.Distance(thePlayer.followKey.transform.position, transform.position) <0.1f)
            {
                waitingKey = false;
                openGate = true;
                theSR.sprite = gateOpenSprite;
                thePlayer.followKey.gameObject.SetActive(false);
                thePlayer.followKey = null;
            }
        }
        if (openGate && Vector3.Distance(thePlayer.transform.position, transform.position) < 1f && Input.GetAxis("Vertical") > 0.1f)
        {
            FindGameManager();
            _gameManager.LoadNextLevel();
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(PlayerTag))
        {   
            if (thePlayer.followKey != null)
            {
                thePlayer.followKey.followTarget = transform;
                waitingKey = true;
                audioPlayer.PlaySound(openAudioClips);

            }
        }
    }

    private void FindGameManager()
    {
        if (_gameManager != null) return;
        _gameManager = FindObjectOfType<GameManager>();
    }
}
