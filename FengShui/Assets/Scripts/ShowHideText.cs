using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHideText : MonoBehaviour
{
    public GameObject textOne;
    public GameObject textTwo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void onClick(){
        textOne.SetActive(false);
        textTwo.SetActive(true);
    }
}
