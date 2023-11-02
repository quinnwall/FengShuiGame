using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) == true) {
            gameObject.transform.position = new Vector3(1.0f, 0, 1.0f);
        }

        if (Input.GetKeyDown(KeyCode.S) == true) {
            gameObject.transform.position = new Vector3(-1.0f, 0, -1.0f);
        }
    }
}
