using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    public string StartScene;  // Variable names in C# should be camelCase

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SceneManager.LoadScene(StartScene);  // Use the variable, not the string literal
            Debug.Log("You have finished the level.");  // Changed the log to English for consistency
        }
    }
}
