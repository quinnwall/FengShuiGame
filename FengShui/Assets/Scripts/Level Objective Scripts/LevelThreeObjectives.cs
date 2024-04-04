using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelThreeObjectives : MonoBehaviour
{
    public GameObject Objective;
    public GameObject KitchenItem1;
    public GameObject KitchenItem2;
    public GameObject KitchenItem3;
    public GameObject KitchenItem4;
    public GameObject KitchenItem5;
    public GameObject CompletionScreen;

    public GameObject Door;
    public bool KitchenItem1Angle;
    public bool KitchenItem2Angle;
    public bool KitchenItem3Angle;
    public bool KitchenItem4Angle;
    public bool KitchenItem5Angle;

    public bool KitchenItem1XPos;
    public bool KitchenItem2XPos;   
    public bool KitchenItem3XPos;
    public bool KitchenItem4XPos;
    public bool KitchenItem5XPos;
    public TMP_Text ScoreText;
    
    int MaxScore = 600;


    // Start is called before the first frame update
    void Start()
    {
        KitchenItem1Angle = false;
        KitchenItem2Angle = false;
        KitchenItem3Angle = false;
        KitchenItem4Angle = false;
        KitchenItem5Angle = false;
        KitchenItem1XPos = false;
        KitchenItem2XPos = false;
        KitchenItem3XPos = false;
        KitchenItem4XPos = false;
        KitchenItem5XPos = false;
        ScoreText.text = "0 Points";
    }


    // Update is called once per frame
    public void checkLevelThreeObjectives()
    {
        print("1: " + KitchenItem1.transform.localPosition.x);
        print("2: " + KitchenItem2.transform.localPosition.x);
        print("3: " + KitchenItem3.transform.localPosition.x);
        print("4: " + KitchenItem4.transform.localPosition.x);
        print("table: " + KitchenItem5.transform.localPosition.x);
        print("door: " + Door.transform.localPosition.x);

        //check bed orientation
        if(KitchenItem1.transform.localRotation.eulerAngles.y == 90 | KitchenItem1.transform.localRotation.eulerAngles.y == 270){
            KitchenItem1Angle = true;
        }
        else{
            KitchenItem1Angle = false;
        }

        //check table orientation
        if(KitchenItem2.transform.localRotation.eulerAngles.y == 90 | KitchenItem2.transform.localRotation.eulerAngles.y == 270){
            KitchenItem2Angle = true;
        }
        else{
            KitchenItem2Angle = false;
        }

        //closet table orientation
        if(KitchenItem3.transform.localRotation.eulerAngles.y == 90 | KitchenItem3.transform.localRotation.eulerAngles.y == 270){
            KitchenItem3Angle = true;
        }
        else{
            KitchenItem3Angle = false;
        }

        if(KitchenItem4.transform.localRotation.eulerAngles.y == 90 | KitchenItem4.transform.localRotation.eulerAngles.y == 270){
            KitchenItem4Angle = true;
        }
        else{
            KitchenItem4Angle = false;
        }

        if(KitchenItem5.transform.localRotation.eulerAngles.y == 180 | KitchenItem5.transform.localRotation.eulerAngles.y == 0){
            KitchenItem5Angle = true;
        }
        else{
            KitchenItem5Angle = false;
        }

        //check bed position
        if(KitchenItem1.transform.localPosition.x < Door.transform.localPosition.x){
            KitchenItem1XPos = true;
        }
        else{
            KitchenItem1XPos = false;
        }

        //check coffee table position
        if(KitchenItem2.transform.localPosition.x < Door.transform.localPosition.x){
            KitchenItem2XPos = true;
        }
        else{
            KitchenItem2XPos = false;
        }

         //check coffee table position
        if(KitchenItem3.transform.localPosition.x < Door.transform.localPosition.x){
            KitchenItem3XPos = true;
        }
        else{
            KitchenItem3XPos = false;
        }

        if(KitchenItem4.transform.localPosition.x < Door.transform.localPosition.x){
            KitchenItem4XPos = true;
        }
        else{
            KitchenItem4XPos = false;
        }

        if(KitchenItem5.transform.localPosition.x < Door.transform.localPosition.x){
            KitchenItem5XPos = true;
        }
        else{
            KitchenItem5XPos = false;
        }

        //TODO: ensure chair and table are together

        Points();

        if ((KitchenItem1Angle & KitchenItem2Angle & KitchenItem3Angle & KitchenItem4Angle & KitchenItem5Angle & KitchenItem1XPos & KitchenItem2XPos & KitchenItem3XPos & KitchenItem4XPos & KitchenItem5XPos) || (MaxScore <= 0)){
            Objective.SetActive(false);
            ScoreText.text = MaxScore.ToString() + " Points";
            CompletionScreen.SetActive(true);
        }
    }

    public void Points() {
        if (((KitchenItem1Angle & KitchenItem2Angle & KitchenItem3Angle & KitchenItem4Angle & KitchenItem5Angle) == true & (KitchenItem1XPos & KitchenItem2XPos & KitchenItem3XPos & KitchenItem4XPos & KitchenItem5XPos) == false) || ((KitchenItem1Angle & KitchenItem2Angle & KitchenItem3Angle & KitchenItem4Angle & KitchenItem5Angle) == false & (KitchenItem1XPos & KitchenItem2XPos & KitchenItem3XPos & KitchenItem4XPos & KitchenItem5XPos) == true)) {
            MaxScore -= 15;
        } else if ((KitchenItem1Angle & KitchenItem2Angle & KitchenItem3Angle & KitchenItem4Angle & KitchenItem5Angle) == false & (KitchenItem1XPos & KitchenItem2XPos & KitchenItem3XPos & KitchenItem4XPos & KitchenItem5XPos) == false) {
            MaxScore -= 25;
        } else {
        
        }
    }

}
