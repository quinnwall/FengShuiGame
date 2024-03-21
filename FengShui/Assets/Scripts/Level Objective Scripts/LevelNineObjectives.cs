using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelNineObjectives : MonoBehaviour
{
    public GameObject Desk;
    public GameObject Chair;
    public GameObject BookshelfOne;
    public GameObject BookshelfTwo;
    public GameObject BookshelfThree;

    public GameObject BlackTortoiseObjectiveText;
    public GameObject RedPheonixObjectiveText;
    public GameObject GreenDragonObjective;
    public GameObject WhiteTigerObjective;
    public GameObject CommandPositionObjectiveText;

    public bool BackToSolidWall;
    public bool OpenSpaceInFront;
    public bool EnergySourceToLeft;
    public bool BookshelvesToRight;
    public bool DeskDiagonalToDoor;

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
        DeskDiagonalToDoor = false;
    }

    public void checkLevelNineObjectives(){
        
        GameObject[] Bookshelves = {BookshelfOne, BookshelfTwo, BookshelfThree};

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

        //checks if the primary energy source (the windows) is to the left
        if (Desk.transform.localRotation.eulerAngles.y == 0){
            EnergySourceToLeft = true;
        }
        else{
            EnergySourceToLeft = false;
        }

        //checks if the energy collectors (bookshelves) are to the right
         if (Desk.transform.localRotation.eulerAngles.y == 0){
            BookshelvesToRight = true; 

            foreach (GameObject shelf in Bookshelves){
                if (!(shelf.transform.localPosition.x <= Desk.transform.localPosition.x)){
                    BookshelvesToRight = false;
                }
            }
        }
        else if (Desk.transform.localRotation.eulerAngles.y == 90){
            BookshelvesToRight = true; 
            
            foreach (GameObject shelf in Bookshelves){
                if (!(shelf.transform.localPosition.z <= Desk.transform.localPosition.z)){
                    BookshelvesToRight = false;
                }
            }
        }
        else if (Desk.transform.localRotation.eulerAngles.y == 180){
            BookshelvesToRight = true; 
            
            foreach (GameObject shelf in Bookshelves){
                if (!(shelf.transform.localPosition.x >= Desk.transform.localPosition.x)){
                    BookshelvesToRight = false;
                }
            }
        }
        else if (Desk.transform.localRotation.eulerAngles.y == 270){
            BookshelvesToRight = true; 
            
            foreach (GameObject shelf in Bookshelves){
                if (!(shelf.transform.localPosition.z >= Desk.transform.localPosition.z)){
                    BookshelvesToRight = false;
                }
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

        if (DeskDiagonalToDoor){
            CommandPositionObjectiveText.SetActive(false);
        }
        else {
            CommandPositionObjectiveText.SetActive(true);
        }

        if (BackToSolidWall & EnergySourceToLeft & BookshelvesToRight & OpenSpaceInFront & DeskDiagonalToDoor){
            CompletionScreen.SetActive(true);
        }
    }

    public void Points() {
       
    }

}
