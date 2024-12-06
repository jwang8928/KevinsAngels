using UnityEngine;
using TMPro;

public class DisplayTotalPoints : MonoBehaviour
{
    public TextMeshProUGUI TotalPointsTxt; // UI Text element for displaying total points

    private void Start()
    {
        // Retrieve the points from PlayerPrefs (default to 0 if not set)
        int totalPoints = PlayerPrefs.GetInt("TotalPoints", 0);

        // Update the UI with the retrieved points
        if (TotalPointsTxt != null)
        {
            TotalPointsTxt.text = totalPoints.ToString();
        }
        else
        {
            Debug.LogWarning("TotalPointsTxt is not assigned in the Inspector!");
        }
    }
}