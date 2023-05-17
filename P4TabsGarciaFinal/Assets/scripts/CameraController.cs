using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraController : MonoBehaviour
{
    public float cameraSpeed = 20f;
    public float Border = 10f;
    public Vector2 Limit;

    public float scrollSpeed = 100f;
    public float minY = 20f;
    public float maxY = 120f;

    //private bool isGameActive;

    private GameManager gameManager;
    private CameraController cameraController;

    // Start is called before the first frame update
    void Start()
    {
        cameraController = GameObject.Find("Main Camera").GetComponent<CameraController>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        cameraController.gameObject.SetActive(true);
        //gameActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if(isGameActive == true)
        
        float moveX = Input.GetAxis("Horizontal") * cameraSpeed * Time.deltaTime;
        float moveZ = Input.GetAxis("Vertical") * cameraSpeed * Time.deltaTime;

        transform.Translate(moveX, 0, moveZ);
        
        
    }
}
