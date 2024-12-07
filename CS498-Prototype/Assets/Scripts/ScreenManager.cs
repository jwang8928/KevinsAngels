using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenManager : MonoBehaviour
{
   public void GoToDoList()
    {
        Debug.Log("pressed");
        SceneManager.LoadScene("SampleScene");
    }
    
    public void GoToHome()
    {
        SceneManager.LoadScene("UI");
    }

    public void GoToMarket()
    {
        Debug.Log("pressed");
        SceneManager.LoadScene("Market");
    }
}
