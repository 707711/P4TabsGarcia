using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{
    // Start is called before the first frame update

    Transform player;
    public float enemySpeed, dis;
    Vector3 startPos;

    private NavMeshAgent navMeshAgent;
    //private Transform movePositionTransform;
    
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        dis = Vector3.Distance(transform.position, player.position);
        if (dis <= 10.0f)
        {
            chase();
        }

        //navMeshAgent.destination = movePositionTransform.position;
    }

    void chase()
    {
        transform.LookAt(player);
        transform.Translate(0, 0, enemySpeed * Time.deltaTime);
    }
}
