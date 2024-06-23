using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("Main"); // Make sure "Main" matches your main game scene's name
    }

    public void OpenStory()
    {
        // Here you might load a new scene with the story or simply activate a panel in the current menu that has the story text.
        Debug.Log("Open Story");
    }

    public void ShowControlsAndTips()
    {
        // Similar to the story, you might load a scene or display a UI panel with this information.
        Debug.Log("Show Controls and Tips");
    }
}
