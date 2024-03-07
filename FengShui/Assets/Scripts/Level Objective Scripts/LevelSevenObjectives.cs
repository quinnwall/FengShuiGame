using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class LevelSevenObjectives : MonoBehaviour
{
    
    public GameObject Desk;
    public GameObject Chair;
    public GameObject BookshelfOne;
    public GameObject BookshelfTwo;
    public GameObject BookshelfThree;

    public GameObject BlackTortoiseObjectiveText;
    public GameObject RedPheonixObjectiveText;
    public GameObject CommandPositionObjectiveText;

    public bool BackToSolidWall;
    public bool OpenSpaceInFront;
    public bool DiagonalToDoor;

    public GameObject CompletionScreen;

    public TMP_Text ScoreText;
    int MaxScore = 500;

    // Start is called before the first frame update
    void Start()
    {
        BackToSolidWall = false;
        OpenSpaceInFront = false;
        DiagonalToDoor = false;
    }

    public void checkLevelSevenObjectives(){
        
        //checks if the backs of the chairs are all facing a solid wall
        if (Desk.transform.localRotation.eulerAngles.y != 0 &
            Chair.transform.localRotation.eulerAngles.y != 0 
            ){
            BackToSolidWall = true;
        }
        else {
            BackToSolidWall = false;
        }

        //checks if the furniture is diagonal to the door
        // TODO: change # values
        if ( Desk.transform.localPosition.x < 1.5 &
            Chair.transform.localPosition.x < 1.5
            ){
                DiagonalToDoor = true;
        }
        else{
            DiagonalToDoor = false;
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

        if (DiagonalToDoor){
            CommandPositionObjectiveText.SetActive(false);
        }
        else {
            CommandPositionObjectiveText.SetActive(true);
        }

        if (BackToSolidWall & OpenSpaceInFront & DiagonalToDoor){
            CompletionScreen.SetActive(true);
        }
    }

    public void Points() {
       
    }

}
