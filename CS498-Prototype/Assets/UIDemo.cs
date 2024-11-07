using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIDemo : MonoBehaviour
{

    // Entering New Task Variables
    public TMP_InputField inputNewTask;


    // Assinging Amount to New Task
    public Slider newTaskAmount;
    public TextMeshProUGUI newTaskAmountTxt;
    
    
    public TextMeshProUGUI listNewTaskTxt;
    public TextMeshProUGUI listNewTaskAmountTxt;


    private void Start() {
        inputNewTask.onSubmit.AddListener(delegate { ButtonDemo(); });
        
        UpdateSliderValue(newTaskAmount.value);

        newTaskAmount.onValueChanged.AddListener(UpdateSliderValue);
    }

    private void UpdateSliderValue(float value) {
        int intSliderValue = Mathf.RoundToInt(value);
        newTaskAmountTxt.text = intSliderValue.ToString();
    }

    public void ButtonDemo() {
        listNewTaskTxt.text = inputNewTask.text;
        listNewTaskAmountTxt.text = newTaskAmountTxt.text;

        // Reset Input fields
        inputNewTask.text = "";
        newTaskAmount.value = 0;
    }
}
