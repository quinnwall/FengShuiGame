using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelTwoObjectives : MonoBehaviour
{
    public GameObject ObjectiveOneText;
    public GameObject ObjectiveTwoText;
    public GameObject Bed;
    public GameObject Closet;
    public GameObject Coffee_Table;
    public GameObject CompletionScreen;

    public GameObject Door;
    public bool BedAngle;
    public bool Coffee_TableAngle;
    public bool ClosetAngle;
    public bool BedXPos;
    public bool ClosetXPos;
    public bool Coffee_TableXPos;

    public TMP_Text ScoreText;
    
    int MaxScore = 600;


    // Start is called before the first frame update
    void Start()
    {
        BedAngle = false;
        ClosetAngle = false;
        Coffee_TableAngle = false;
        BedXPos = false;
        ClosetXPos = false;
        Coffee_TableXPos = false;
        ScoreText.text = "0 Points";
    }


    // Update is called once per frame
    public void checkLevelTwoObjectives()
    {
        print("Door position:" + Door.transform.localPosition.x);
        print("Bed position:" + Bed.transform.localPosition.x);
        print("Closet position:" + Closet.transform.localPosition.x);
        //check bed orientation
        if(Bed.transform.localRotation.eulerAngles.y == 180){
            BedAngle = true;
        }
        else{
            BedAngle = false;
        }

        //check table orientation
        if(Coffee_Table.transform.localRotation.eulerAngles.y == 180 | Coffee_Table.transform.localRotation.eulerAngles.y == 0){
            Coffee_TableAngle = true;
        }
        else{
            Coffee_TableAngle = false;
        }

        //closet table orientation
        if(Closet.transform.localRotation.eulerAngles.y == 180 | Closet.transform.localRotation.eulerAngles.y == 0){
            ClosetAngle = true;
        }
        else{
            ClosetAngle = false;
        }

        //check bed position
        if(Bed.transform.localPosition.x > Door.transform.localPosition.x){
            BedXPos = true;
        }
        else{
            BedXPos = false;
        }

        //check coffee table position
        if(Coffee_Table.transform.localPosition.x > Door.transform.localPosition.x){
            Coffee_TableXPos = true;
        }
        else{
            Coffee_TableXPos = false;
        }

         //check coffee table position
        if(Closet.transform.localPosition.x > Door.transform.localPosition.x){
            ClosetXPos = true;
        }
        else{
            ClosetXPos = false;
        }

        //TODO: ensure chair and table are together

        //check if objective one (orientation) is satisfied
        if (BedAngle & Coffee_TableAngle & ClosetAngle){
            ObjectiveOneText.SetActive(false);
        }
        else{
            ObjectiveOneText.SetActive(true);
        }

        //check if objective two (postion) is satisfied
        if (BedXPos & Coffee_TableXPos & ClosetXPos){
            ObjectiveTwoText.SetActive(false);
        }
        else{
            ObjectiveTwoText.SetActive(true);
        }

        Points();

        if ((BedAngle & Coffee_TableAngle & ClosetAngle & BedXPos & Coffee_TableXPos & ClosetXPos) || (MaxScore <= 0)){
            ScoreText.text = MaxScore.ToString() + " Points";
            CompletionScreen.SetActive(true);
        }
    }

    public void Points() {
        if ((ObjectiveOneText.activeSelf == true & ObjectiveTwoText.activeSelf == false) || (ObjectiveOneText.activeSelf == false & ObjectiveTwoText.activeSelf == true)) {
            MaxScore -= 10;
        } else if (ObjectiveOneText.activeSelf == true & ObjectiveTwoText.activeSelf == true) {
            MaxScore -= 20;
        } else {
        
        }
    }

}
