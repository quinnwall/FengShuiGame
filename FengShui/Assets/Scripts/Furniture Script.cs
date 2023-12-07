using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[RequireComponent(typeof(Collider))]
public class FurnitureScript : MonoBehaviour
{
    private Camera mainCamera;
    private float CameraZDistance;

    void Start()
    {
        mainCamera = Camera.main;
        CameraZDistance =
            mainCamera.WorldToScreenPoint(transform.position).z; //z axis of the game object for screen view
    }

    void Update()
    {
        
    }


    private float counter = 0;

    void OnMouseDrag()
    {
        Vector3 ScreenPosition =
            new Vector3(Input.mousePosition.x, Input.mousePosition.y, CameraZDistance); //z axis added to screen point 
        Vector3 NewWorldPosition =
            mainCamera.ScreenToWorldPoint(ScreenPosition); //Screen point converted to world point

        transform.position = new Vector3(NewWorldPosition.x, 0.0f, NewWorldPosition.z);

        if (Input.GetKeyDown(KeyCode.R)){
            transform.Rotate(new Vector3(0.0f, 90.0f, 0.0f));
            print("R pressed");
        }
    }

}
