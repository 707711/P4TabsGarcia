using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Animator playerAnim;
    public Rigidbody rb;
    public float r_Speed, rb_Speed, ro_Speed;
    public bool walking;
    public Transform playerTrans;

    public Health health;
    Transform enemy;

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.velocity = transform.forward * r_Speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.velocity = -transform.forward * rb_Speed * Time.deltaTime;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Forawrd and back movement
        if (Input.GetKeyDown(KeyCode.W))
        {
            playerAnim.SetTrigger("Run");
            //playerAnim.SetTrigger("Idle");
            walking = true;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            //playerAnim.SetTrigger("Run");
            playerAnim.SetTrigger("Idle");
            walking = false;
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            playerAnim.SetTrigger("RunBack");
            //playerAnim.SetTrigger("Idle");
            walking = true;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            //playerAnim.SetTrigger("RunBack");
            playerAnim.SetTrigger("Idle");
            walking = false;
        }

        //Rotation
        if (Input.GetKey(KeyCode.A))
        {
            playerTrans.Rotate(0, -ro_Speed * Time.deltaTime, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            playerTrans.Rotate(0, ro_Speed * Time.deltaTime, 0);
        }

        //attacking
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            Attack();
        }

        //taking damage
        //if ()
        {

        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }

    void Attack()
    {
        playerAnim.SetTrigger("Attack");
        health.DealDamage(enemy.gameObject);
        
    }
}
