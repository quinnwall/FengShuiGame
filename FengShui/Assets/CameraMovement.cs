using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float speed = 1.0f;
	private float X;
	private float Y;

    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.W) == true) {
            gameObject.transform.position = new Vector3(1.0f, 0, 1.0f);
        }

        if (Input.GetKeyDown(KeyCode.S) == true) {
            gameObject.transform.position = new Vector3(-1.0f, 0, -1.0f);
        }
        */
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput);
        movement.Normalize(); //movement speed will be the same in every direction
        transform.Translate(movement * 5.0f * Time.deltaTime);
        
        if(Input.GetMouseButton(0)) {
			transform.Rotate(new Vector3(Input.GetAxis("Mouse Y") * speed, -Input.GetAxis("Mouse X") * speed, 0));
			X = transform.rotation.eulerAngles.x;
			Y = transform.rotation.eulerAngles.y;
			transform.rotation = Quaternion.Euler(X, Y, 0);
		}
    }
}
