using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToPrevious : MonoBehaviour
{
    public string previousScene;

    public void GoBack()
    {
        SceneManager.LoadScene(previousScene);
    }
}