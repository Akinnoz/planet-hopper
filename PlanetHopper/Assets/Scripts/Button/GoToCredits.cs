using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToCredits : MonoBehaviour
{
    public void OpenCredits()
    {
        SceneManager.LoadScene("CreditScene");
    }
}