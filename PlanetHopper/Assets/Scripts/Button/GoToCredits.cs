using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToCredits : MonoBehaviour
{
    public static string previousScene;

    public void OpenCredits()
    {
        previousScene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene("CreditScene");
    }
}