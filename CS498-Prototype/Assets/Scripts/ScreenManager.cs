using UnityEngine;
using UnityEngine.SceneManagement;

public class ScreenManager : MonoBehaviour
{
   public void GoToDoList()
    {
        SceneManager.LoadScene("SampleScene");
    }
    
}
