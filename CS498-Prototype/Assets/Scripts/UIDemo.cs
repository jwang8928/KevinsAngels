using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ToDoListManager : MonoBehaviour
{
    public TMP_InputField newTaskInput;           // Input field for new tasks
    public Button submitButton;                   // Button to add tasks
    public GameObject Content;                    // The panel or scroll view content for tasks
    public GameObject ListItemPanel;              // Prefab for each task item (set to your Panel prefab)
    public Slider newTaskAmount;                  // Slider for task amount
    public TextMeshProUGUI newTaskAmountTxt;      // Text display for slider value
    public TextMeshProUGUI TotalPointsTxt;
    private int totalPoints = 0;

    private void Start()
    {
        // Add listeners to the submit button and Enter key in the input field
        submitButton.onClick.AddListener(AddTask);
        newTaskInput.onSubmit.AddListener(delegate { AddTask(); });

        // Update slider value display and set listener for slider changes
        UpdateSliderValue(newTaskAmount.value);
        newTaskAmount.onValueChanged.AddListener(UpdateSliderValue);
    }

    private void UpdateSliderValue(float value)
    {
        int intSliderValue = Mathf.RoundToInt(value);
        newTaskAmountTxt.text = intSliderValue.ToString();
    }

    public void AddTask()
    {
        // Check if the input field is not empty
        if (!string.IsNullOrEmpty(newTaskInput.text))
        {
            // Instantiate a new task item from the prefab
            GameObject newTask = Instantiate(ListItemPanel, Content.transform);

            // Find and set the task text on the new task item
            TMP_Text taskText = newTask.transform.Find("listNewTaskTxt").GetComponent<TMP_Text>();
            if (taskText != null)
                taskText.text = newTaskInput.text;

            // Find and set the task amount text on the new task item
            TMP_Text taskAmountText = newTask.transform.Find("listNewTaskAmountTxt").GetComponent<TMP_Text>();
            if (taskAmountText != null)
                taskAmountText.text = newTaskAmountTxt.text;

            // Find the remove button in the new task and add a click listener
            Button removeButton = newTask.transform.Find("removeTaskButton").GetComponent<Button>();
            if (removeButton != null) 
            {
                removeButton.gameObject.SetActive(true);
                removeButton.onClick.AddListener(() => RemoveTask(newTask));
            }
            // Find the complete button in the new task, activate it, and add a click listener
            Button completeTaskButton = newTask.transform.Find("completeTaskButton").GetComponent<Button>();
            if (completeTaskButton != null)
            {
                completeTaskButton.gameObject.SetActive(true); // Ensure the button is visible
                completeTaskButton.onClick.AddListener(() => AddTotal(taskAmountText.text));
                completeTaskButton.onClick.AddListener(() => RemoveTask(newTask));
            }

            // Clear the input field and reset the slider for the next task
            newTaskInput.text = "";
            newTaskAmount.value = 0;
        }
    }

    private void RemoveTask(GameObject task)
    {
        Destroy(task); // Remove the task item from the list
    }
    private void AddTotal(string taskAmountText) 
    {
        if(int.TryParse(taskAmountText, out int amount)) 
        {
            totalPoints += amount;
            TotalPointsTxt.text = totalPoints.ToString();
        }
    }
}