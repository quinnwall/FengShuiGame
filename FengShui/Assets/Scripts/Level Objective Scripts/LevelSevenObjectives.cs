using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class LevelSevenObjectives : MonoBehaviour
{
    
    public GameObject Desk;
    public GameObject Chair;

    public GameObject BlackTortoiseObjectiveText;
    public GameObject RedPheonixObjectiveText;
    public GameObject CommandPositionObjectiveText;

    public bool BackToSolidWall;
    public bool OpenSpaceInFront;
    public bool DeskDiagonalToDoor;

    public GameObject CompletionScreen;

    public TMP_Text ScoreText;
    int MaxScore = 500;

    // Start is called before the first frame update
    void Start()
    {
        BackToSolidWall = false;
        OpenSpaceInFront = false;
        DeskDiagonalToDoor = false;
    }

    public void checkLevelSevenObjectives(){
        
        //checks if the backs of the chairs are all facing a solid wall
        if (Desk.transform.localRotation.eulerAngles.y != 180 &
            Chair.transform.localRotation.eulerAngles.y != 0 
            ){
            BackToSolidWall = true;
        }
        else {
            BackToSolidWall = false;
        }

        //checks if the furniture is diagonal to the door
        if ( Desk.transform.localPosition.x < -0.5 &
            Chair.transform.localPosition.x < 0
            ){
                DeskDiagonalToDoor = true;
        }
        else{
            DeskDiagonalToDoor = false;
        }

        //checks if there is open space in front of the desk
        if (Desk.transform.localRotation.eulerAngles.y == 0){
            if(Desk.transform.localPosition.z >= -3){
                OpenSpaceInFront = true;
            }
        }
        else if (Desk.transform.localRotation.eulerAngles.y == 90){
            if(Desk.transform.localPosition.x <= 2.5){
                OpenSpaceInFront = true;
            }
        }
        else if (Desk.transform.localRotation.eulerAngles.y == 180){
            if(Desk.transform.localPosition.z <= 0){
                OpenSpaceInFront = true;
            }
        }
        else if (Desk.transform.localRotation.eulerAngles.y == 270){
            if(Desk.transform.localPosition.x >= -2.5){
                OpenSpaceInFront = true;
            }
        }
        else{
            OpenSpaceInFront = false;
        }

        if (BackToSolidWall){
            BlackTortoiseObjectiveText.SetActive(false);
        }
        else{
            BlackTortoiseObjectiveText.SetActive(true);
        }

        if (OpenSpaceInFront){
            RedPheonixObjectiveText.SetActive(false);
        }
        else{
            RedPheonixObjectiveText.SetActive(true);
        }

        if (DeskDiagonalToDoor){
            CommandPositionObjectiveText.SetActive(false);
        }
        else {
            CommandPositionObjectiveText.SetActive(true);
        }

        if (BackToSolidWall & OpenSpaceInFront & DeskDiagonalToDoor){
            CompletionScreen.SetActive(true);
        }
    }

    public void Points() {
       
    }

}
