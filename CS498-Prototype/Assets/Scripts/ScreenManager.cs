using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenManager : MonoBehaviour
{
   public void GoToDoList()
    {
        SceneManager.LoadScene("SampleScene");
    }
    
    public void GoBack()
    {
        SceneManager.LoadScene("UI");
    }

    public void GoToMarket()
    {
        SceneManager.LoadScene("Market");
    }
}
