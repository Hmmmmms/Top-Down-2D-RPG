using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Animator animator;

    public float damage = 1;

    public float Health
    {
        set { health = value; 

        if(health <= 0)
            {
                Defeated();
            }
        }
        get { return health; } 
    }

    public float health = 1;


    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    public void Defeated()
    {
        animator.SetTrigger("Defeated");
    }

    public void RemoveEnemy()
    {
        Destroy(gameObject);
    }
    private void OnCollisionEnter2D(Collision2D col)
    {
        
            print("PlayerDamage");
            //Deal damage to enemy
            PlayerController playerController = col.collider.GetComponent<PlayerController>();

            if (playerController != null)
            {
                playerController.PlayerHealth -= damage;
            }
        
    }

}
