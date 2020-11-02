using UnityEngine.SceneManagement;
using UnityEngine;

public class NextScene : MonoBehaviour
{
   public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
