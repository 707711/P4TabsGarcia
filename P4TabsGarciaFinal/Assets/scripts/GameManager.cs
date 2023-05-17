using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public bool isGameActive;
    public Button button;
    public GameObject titleScreen;
    public GameObject mainCamera;

    //private Button startButtom;


    // Start is called before the first frame update
    void Start()
    {
        isGameActive = false;

        //button = GetComponent<Button>();

    }

    public void StartGame()
    {
        isGameActive = true;
        titleScreen.gameObject.SetActive(false);
        mainCamera.gameObject.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        //mainCamera.gameObject.SetActive(true);
    }
}
