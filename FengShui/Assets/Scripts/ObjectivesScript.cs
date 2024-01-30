using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectivesScript : MonoBehaviour
{
    
    public static ObjectivesScript instance;

    public GameObject objectiveText;
    public GameObject bed;
    public GameObject closet;
    public GameObject coffeeTable;
    public GameObject completionScreen;

    public bool bedAngle;
    public bool closetAngle;
    public bool coffeeTableAngle;
    public bool bedXPos;
    public bool closetXPos;
    public bool coffeeTableXPos;

    private void Awake() {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        bedAngle = false;
        closetAngle = false;
        coffeeTableAngle = false;
        bedXPos = false;
        closetXPos = false;
        coffeeTableXPos = false;
    }
    
    public void checkObjectives() {
        /**
        UnityEngine.Vector3 tableToDoor = tablePos - doorPos;
        UnityEngine.Vector3 chairToDoor = chairPos - doorPos;
        
        if (Mathf.Atan(tableToDoor.z/tableToDoor.x) != 0 && Mathf.Atan(chairToDoor.z/tableToDoor.x) != 0) {
            objectiveText = (objectiveText.ToString() + " (Complete)");
        }
        **/
        //check chair orientation
        if(bed.transform.localRotation.eulerAngles.y == 180){
            bedAngle = true;
        }
        else{
            bedAngle = false;
        }

        //check table orientation
        if(closet.transform.localRotation.eulerAngles.y == 180 | closet.transform.localRotation.eulerAngles.y == 0){
            closetAngle = true;
        }
        else{
            closetAngle = false;
        }

        //check chair position
        if(bed.transform.localPosition.x < 1){
            bedXPos = true;
        }
        else{
            bedXPos = false;
        }

        //check table position
        if(closet.transform.localPosition.x < 1){
            closetXPos = true;
        }
        else{
            closetXPos = false;
        }

        //TODO: ensure chair and table are together

        //check if objective one & 2 (orientation) is satisfied
        if (bedAngle & closetAngle & closetXPos & bedXPos){
            objectiveText.SetActive(false);
        }
        else{
            objectiveText.SetActive(true);
        }

    }

}
