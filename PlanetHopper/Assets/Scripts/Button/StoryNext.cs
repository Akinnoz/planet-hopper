using UnityEngine;
using UnityEngine.SceneManagement;

public class StoryNext : MonoBehaviour
{
    public void StartGameplay()
    {
        SceneManager.LoadScene("PlanetHopper_Gameplay");
    }
}
