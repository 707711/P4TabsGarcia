using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed;
    Transform enemy;
    Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime;
        float moveZ = Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime;

        transform.Translate(moveX, 0, moveZ);
    }
}
