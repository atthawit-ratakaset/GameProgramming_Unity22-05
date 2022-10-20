using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    [SerializeField] private PlayerHp playerHp;
    // Start is called before the first frame update
    private Collider2D _playerCollider;
    public LayerMask enemyLayer;
    private void Start()
    {   
        _playerCollider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (_playerCollider.IsTouchingLayers(enemyLayer))
        {
            playerHp.TakeDamage(50);
        }
        
    }
}
