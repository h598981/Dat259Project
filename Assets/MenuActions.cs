using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuActions : MonoBehaviour
{
    public GameObject storyPanel;  // Assign in the inspector
    public GameObject controlsPanel;  // Assign in the inspector

    public void PlayGame()
    {
        SceneManager.LoadScene("Main");
    }

    public void ToggleStoryPanel()
    {
        storyPanel.SetActive(!storyPanel.activeSelf);
    }

    public void ToggleControlsPanel()
    {
        controlsPanel.SetActive(!controlsPanel.activeSelf);
    }
}
