using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;
using UnityEngine;

public class RoomCheck : MonoBehaviour
{

    public static RoomCheck instance;
    public GameObject deskTable;
    public GameObject deskChair;
    public GameObject door;

    public UnityEngine.Vector3 tablePos;
    public UnityEngine.Vector3 chairPos;
    public UnityEngine.Vector3 doorPos;

    void Start() {
         deskTable = GameObject.FindGameObjectWithTag("DeskTable");
         deskChair = GameObject.FindGameObjectWithTag("deskChair");
         door = GameObject.FindGameObjectWithTag("Door");

         tablePos = deskTable.transform.position;
         chairPos = deskChair.transform.position;
         doorPos = door.transform.position;


    }

    private void Awake() {
        instance = this;
    }

    public void OrientationCheck() {
        
        
        ObjectivesScript.instance.completeObjective();

    }

    public void PlacementCheck() {

        UnityEngine.Vector3 tableToDoor = tablePos - doorPos;
        UnityEngine.Vector3 chairToDoor = chairPos - doorPos;
        
        if (Mathf.Atan(tableToDoor.z/tableToDoor.x) != 0 && Mathf.Atan(chairToDoor.z/tableToDoor.x) != 0) {
            ObjectivesScript.instance.completeObjective();
        }

    }
}
