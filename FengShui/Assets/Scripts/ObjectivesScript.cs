using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectivesScript : MonoBehaviour
{
    
    public static ObjectivesScript instance;

    public Text objectiveText;

    private void Awake() {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        objectiveText.text = objectiveText.text;
    }
    
    //
    public void completeObjective() {
        objectiveText.text = objectiveText + " (Complete)";
    }

}
