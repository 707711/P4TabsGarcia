using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordScript : MonoBehaviour
{
    //public PlayerHealth playerHealth;
    //public EnemyHealth enemyHealth;

    public int damage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerHealth playerHealth = GetComponent<PlayerHealth>();
        EnemyHealth enemyHealth = GetComponent<EnemyHealth>();

        if (enemyHealth != null)
        {
            enemyHealth.TakeDamage(damage);
            Debug.Log("Enemy hit");
        }

        if (playerHealth != null)
        {
            playerHealth.TakeDamage(damage);
            Debug.Log("Player hit");
        }

    }

    public void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            FindObjectOfType<EnemyHealth>().TakeDamage(damage);
            Debug.Log("Enemy hit");
        }
    }
}
