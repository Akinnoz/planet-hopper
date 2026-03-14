using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Player Hit!");
            Time.timeScale = 0f;
        }
    }
}