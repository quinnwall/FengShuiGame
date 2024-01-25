using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NavigateLevel : MonoBehaviour
{
    public int NavToLevel;
    // Start is called before the first frame update
    public void ToLevel()
    {
        SceneManager.LoadScene("Level " + NavToLevel);
    }
}
