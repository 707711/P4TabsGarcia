using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartButton : MonoBehaviour
{
    private Button button;
    private GameManager gameManager;
    //private CameraController cameraController;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();

        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

       // cameraController = GameObject.Find("Main Camera").GetComponent<CameraController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
