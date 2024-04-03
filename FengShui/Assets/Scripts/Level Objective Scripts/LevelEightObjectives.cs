using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelEightObjectives : MonoBehaviour
{
    public GameObject Bed;
    public GameObject Carpet;

    public GameObject BlackTortoiseObjectiveText;
    public GameObject RedPheonixObjectiveText;
    public GameObject GreenDragonObjective;
    public GameObject WhiteTigerObjective;
    public GameObject CommandPositionObjectiveText;

    public bool BackToSolidWall;
    public bool OpenSpaceInFront;
    public bool EnergySourceToLeft;
    public bool BookshelvesToRight;
    public bool CommandPosition;

    public GameObject CompletionScreen;

    public TMP_Text ScoreText;
    int MaxScore = 500;

    // Start is called before the first frame update
    void Start()
    {
        BackToSolidWall = false;
        OpenSpaceInFront = false;
        EnergySourceToLeft = false;
        BookshelvesToRight = false;
        CommandPosition = false; 
    }

    public void checkLevelEightObjectives(){
        
         //checks if the bed has a back to solid wall
        if (Bed.transform.localRotation.eulerAngles.y != 0 &
            Bed.transform.localRotation.eulerAngles.y != 270 
            ){
            BackToSolidWall = true;
        }
        else {
            BackToSolidWall = false;
        }

        //checks if the bed has the energy source on the left and collects energy on the right
        if (Bed.transform.localRotation.eulerAngles.y == 180){
            EnergySourceToLeft = true;
            BookshelvesToRight = true;
            if (Bed.transform.localPosition.x <= 1){
                CommandPosition = true;
            }
            else {
                CommandPosition = false;
            }
        }
        else{
            EnergySourceToLeft = false;
            BookshelvesToRight = false;
        }

        //checks if there is open space in front of the desk
        if (Bed.transform.localPosition.z >= -1){
            OpenSpaceInFront = true;
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

        if (EnergySourceToLeft){
            GreenDragonObjective.SetActive(true);
        }
        else{
            GreenDragonObjective.SetActive(false);
        }

        if (BookshelvesToRight){
            WhiteTigerObjective.SetActive(true);
        }
        else{
            WhiteTigerObjective.SetActive(false);
        }

        if (CommandPosition){
            CommandPositionObjectiveText.SetActive(false);
        }
        else {
            CommandPositionObjectiveText.SetActive(true);
        }

        if (BackToSolidWall & EnergySourceToLeft & BookshelvesToRight & OpenSpaceInFront & CommandPosition){
            CompletionScreen.SetActive(true);
        }
    }

    public void Points() {
       
    }
}
