using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelOneObjectives : MonoBehaviour
{
    public GameObject ObjectiveOneText;
    public GameObject ObjectiveTwoText;
    public GameObject DeskChair;
    public GameObject DeskTable;
    public GameObject CompletionScreen;
    public bool ChairAngle;
    public bool TableAngle;
    public bool ChairXPos;
    public bool TableXPos;

    // Start is called before the first frame update
    void Start()
    {
        ChairAngle = false;
        TableAngle = false;
        ChairXPos = false;
        TableXPos = false;
    }

    // Update is called once per frame
    public void checkLevelOneObjectives()
    {
        //check chair orientation
        if(DeskChair.transform.localRotation.eulerAngles.y == 180){
            ChairAngle = true;
        }
        else{
            ChairAngle = false;
        }

        //check table orientation
        if(DeskTable.transform.localRotation.eulerAngles.y == 180 | DeskTable.transform.localRotation.eulerAngles.y == 0){
            TableAngle = true;
        }
        else{
            TableAngle = false;
        }

        //check chair position
        if(DeskChair.transform.localPosition.x < 1){
            ChairXPos = true;
        }
        else{
            ChairXPos = false;
        }

        //check table position
        if(DeskTable.transform.localPosition.x < 1){
            TableXPos = true;
        }
        else{
            TableXPos = false;
        }

        //TODO: ensure chair and table are together

        //check if objective one (orientation) is satisfied
        if (ChairAngle & TableAngle){
            ObjectiveOneText.SetActive(false);
        }
        else{
            ObjectiveOneText.SetActive(true);
        }

        //check if objective two (postion) is satisfied
        if (ChairXPos & TableXPos){
            ObjectiveTwoText.SetActive(false);
        }
        else{
            ObjectiveTwoText.SetActive(true);
        }

        if (ChairAngle & TableAngle & ChairXPos & TableXPos){
            CompletionScreen.SetActive(true);
        }
    }
}
