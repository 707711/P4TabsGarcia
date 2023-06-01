using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health;
    public int attackDamage;
    public bool alive = true;

    public void TakeDamage(int amount)
    {
        health -= amount;
        
        if(health <= 0)
        {
            Die();
        }
    }

    public void DealDamage(GameObject target)
    {
        var atm = target.GetComponent<Health>();
        if(atm != null)
        {
            atm.TakeDamage(attackDamage);
            Debug.Log("Damage dealth");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        alive = true;
    }
    private void OnCollisionEnter(Collision collision)
    {
        //DealDamage();
        //TakeDamage();

    }



    // Update is called once per frame
    void Update()
    {
        if(health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        gameObject.SetActive(false);
    }
}
