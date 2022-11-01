using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] private PlayerHp playerHp;
    [SerializeField] private PlayerController playerController;
    [SerializeField] private PlayerAudioController audioController;
    // Start is called before the first frame update
    private Collider2D _playerCollider;
    public LayerMask enemyLayer;
    public LayerMask hazardLayer;
    private void Start()
    {   
        _playerCollider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (_playerCollider.IsTouchingLayers(enemyLayer))
        {
            playerHp.TakeDamage(20);
            audioController.PlayDamageEnemy();
        }

        if (_playerCollider.IsTouchingLayers(hazardLayer))
        {
            playerHp.TakeDamage(10);
            audioController.PlayDamageHazard();
        }
    }
}
