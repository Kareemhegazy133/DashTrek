using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePlayer : MonoBehaviour
{
    public Animator animator;

    public HealthBar healthbar;

    public int maxHealth = 100;
    public int currenthealth;

    public int maceDamage;
    public int swingingMaceDamage;
    public int sawDamage;
    public int rollingSphereDamage;

    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        currenthealth = maxHealth;
        healthbar.SetMaxHealth(maxHealth);
    }

    void OnCollisionEnter2D(Collision2D colinfo)
    {
        if(colinfo.collider.name == "Mace")
        {
            TakeDamage(maceDamage);
        }

        if (colinfo.collider.name == "Swinging Mace")
        {
            TakeDamage(swingingMaceDamage);
        }

        if (colinfo.collider.name == "Saw")
        {
            TakeDamage(sawDamage);
        }

        if (colinfo.collider.name == "Rolling Sphere")
        {
            TakeDamage(rollingSphereDamage);
        }
    }
     
    public void TakeDamage(int damage)
    {
        currenthealth -= damage;

        healthbar.SetHealth(currenthealth);
        if (currenthealth == 0)
        {
            animator.SetBool("isDead", true);
            Destroy(Player, 1f);
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
