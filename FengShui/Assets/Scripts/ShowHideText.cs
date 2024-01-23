using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideText : MonoBehaviour
{
    public GameObject tutorialCanvas;
    public GameObject textOne;
    public GameObject textTwo;
    public GameObject textThree;
    public GameObject textFour;
    public GameObject textFive;
    public GameObject textSix;
    public GameObject textSeven;
    private int textNum;
    private GameObject[] tutorialTexts;

    // Start is called before the first frame update
    void Start()
    {
        textNum = 1;
        tutorialTexts = new GameObject[] {textOne, textTwo, textThree, textFour, textFive, textSix, textSeven};
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClick(){

        if (textNum == 7){
            tutorialCanvas.SetActive(false);
            textNum = 1;
        }

        tutorialTexts[textNum - 1].SetActive(false);
        tutorialTexts[textNum].SetActive(true);
        
        textNum += 1;
    }
}
