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

    public bool gameActive;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gameActive == true)
        {
            float moveX = Input.GetAxis("Horizontal") * cameraSpeed * Time.deltaTime;
            float moveZ = Input.GetAxis("Vertical") * cameraSpeed * Time.deltaTime;

            transform.Translate(moveX, 0, moveZ);
        }
        //float moveX = Input.GetAxis("Horizontal") * cameraSpeed * Time.deltaTime;
        //float moveZ = Input.GetAxis("Vertical") * cameraSpeed * Time.deltaTime;

        //transform.Translate(moveX, 0, moveZ);

        //Vector3 pos = transform.position;

        //if (Input.GetKey("w") || Input.mousePosition.y >= Screen.height - Border)
        {
            //pos.z -= Speed * Time.deltaTime;
        }

       // if (Input.GetKey("s") || Input.mousePosition.y <= Border)
        {
            //pos.z += Speed * Time.deltaTime;
        }
       // if (Input.GetKey("d") || Input.mousePosition.x >= Screen.height - Border)
        {
            //pos.x += Speed * Time.deltaTime;
        }
        //if (Input.GetKey("a") || Input.mousePosition.x <= Border)
        {
            //pos.x -= Speed * Time.deltaTime;
        }

        //float scroll = Input.GetAxis("Mouse ScrollWheel");
        //pos.y -= scroll * scrollSpeed * 10f * Time.deltaTime;

        //pos.x = Mathf.Clamp(pos.x, -Limit.x, Limit.x);
       // pos.x = Mathf.Clamp(pos.z, -Limit.y, Limit.y);

       // transform.position = pos;
    }
}
