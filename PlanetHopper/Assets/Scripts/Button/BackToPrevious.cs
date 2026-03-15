using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToPrevious : MonoBehaviour
{
    public void GoBack()
    {
        SceneManager.LoadScene(GoToCredits.previousScene);
    }
}