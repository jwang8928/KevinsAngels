using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenManager : MonoBehaviour
{
   public void GoToDoList()
    {
        SceneManager.LoadScene("SampleScene");
    }
    
    public void GoToHome()
    {
        SceneManager.LoadScene("UI");
    }

    public void GoToMarket()
    {
        SceneManager.LoadScene("Market");
    }
}
