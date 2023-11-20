using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float speed = 6.0f;
	private float X;
	private float Y;

    // Update is called once per frame
    void Update()
    {
        // WASD movements
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        
        Vector3 movement = new Vector3(horizontalInput, 0, verticalInput);
        movement.Normalize(); //movement speed will be the same in every direction
        transform.Translate(movement * 6.0f * Time.deltaTime);
        
        //camera rotation
        //rotates the camera based on cursor movement when left clicking
        if(Input.GetMouseButton(0)) {
			transform.Rotate(new Vector3(Input.GetAxis("Mouse Y") * speed, -Input.GetAxis("Mouse X") * speed, 0));
			X = transform.rotation.eulerAngles.x;
			Y = transform.rotation.eulerAngles.y;
			transform.rotation = Quaternion.Euler(X, Y, 0);
		}

        /* up-down movements
           space bar is up
           shift key is down
        */
        if(Input.GetKey("space")){
            transform.Translate(new Vector3(0, 12f* Time.deltaTime, 0));
        }
        if(Input.GetKey(KeyCode.LeftShift)){
            transform.Translate(new Vector3(0, -12f* Time.deltaTime, 0));
        }
        
    }
}
