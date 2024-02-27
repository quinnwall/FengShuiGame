using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

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

    public TMP_Text ScoreText;
    
    int MaxScore = 500;


    // Start is called before the first frame update
    void Start()
    {
        ChairAngle = false;
        TableAngle = false;
        ChairXPos = false;
        TableXPos = false;
        ScoreText.text = "0 Points";
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

        Points();

        if ((ChairAngle & TableAngle & ChairXPos & TableXPos) || (MaxScore <= 0)){
            print('2');
            ScoreText.text = MaxScore.ToString() + " Points";
            CompletionScreen.SetActive(true);
        }
    }

    public void Points() {
        print("1");
        if ((ObjectiveOneText.activeSelf == true & ObjectiveTwoText.activeSelf == false) || (ObjectiveOneText.activeSelf == false & ObjectiveTwoText.activeSelf == true)) {
            MaxScore -= 10;
        } else if (ObjectiveOneText.activeSelf == false & ObjectiveTwoText.activeSelf == false) {
            MaxScore -= 20;
        }
    }

}
