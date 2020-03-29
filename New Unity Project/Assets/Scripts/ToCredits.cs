using UnityEngine;
using UnityEngine.SceneManagement;

public class ToCredits : MonoBehaviour
{
    public void LoadNextLevel ()
    {
        Cursor.lockState = CursorLockMode.None;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
