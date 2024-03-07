using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class LevelSixObjectives : MonoBehaviour
{
    
    public GameObject CoffeeTable;
    public GameObject ArmChairOne;
    public GameObject ArmChairTwo;
    public GameObject ArmChairThree;
    public GameObject ArmChairFour;

    public GameObject BlackTortoiseObjectiveText;
    public GameObject CommandPositionObjectiveText;

    public bool BackToSolidWall;
    public bool DiagonalToDoor;

    public GameObject CompletionScreen;

    public TMP_Text ScoreText;
    int MaxScore = 500;

    // Start is called before the first frame update
    void Start()
    {
        BackToSolidWall = false;
        DiagonalToDoor = false;
    }

    public void checkLevelSixObjectives(){
        
        //checks if the backs of the chairs are all facing a solid wall
        if (ArmChairOne.transform.localRotation.eulerAngles.y != 0 &
            ArmChairTwo.transform.localRotation.eulerAngles.y != 0 &
            ArmChairThree.transform.localRotation.eulerAngles.y != 0 &
            ArmChairFour.transform.localRotation.eulerAngles.y != 0
            ){
            BackToSolidWall = true;
        }
        else {
            BackToSolidWall = false;
        }

        //checks if the furniture is diagonal to the door
        if (ArmChairOne.transform.localPosition.x < 1.5 &
            ArmChairTwo.transform.localPosition.x < 1.5 &
            ArmChairThree.transform.localPosition.x < 1.5 &
            ArmChairFour.transform.localPosition.x < 1.5
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

        if (DiagonalToDoor){
            CommandPositionObjectiveText.SetActive(false);
        }
        else {
            CommandPositionObjectiveText.SetActive(true);
        }

        if (BackToSolidWall & DiagonalToDoor){
            CompletionScreen.SetActive(true);
        }
    }

    public void Points() {
       
    }

}
