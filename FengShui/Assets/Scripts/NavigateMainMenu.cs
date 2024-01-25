using UnityEngine;
using UnityEngine.SceneManagement;
 
public class NavigateMainMenu : MonoBehaviour
{
    public void NextScene()
    {
        SceneManager.LoadScene("Blank");
    }
}
    
