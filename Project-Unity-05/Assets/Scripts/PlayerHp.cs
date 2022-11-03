using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHp : MonoBehaviour
{
    public int maxHealth = 100;
    [SerializeField] private PlayerAudioController audioController;
    public int currentHealth;
    public HealthBar healthBar;
    public GameObject monster;

    public LayerMask enemyLayer;
    public LayerMask hazardLayer;

    void Start()
    {      
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    public void TakeDamage(int damage)
    {   
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
        if (currentHealth <= 0)
        {   
            PopsUpManager.isGameOver = true;
            audioController.PlayDeath();
            monster.SetActive(false);
            gameObject.SetActive(false);
        }
    }

}
