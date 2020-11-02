using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public int delay = 2;
    public void EndGame ()
    {
        if(gameHasEnded == false)
        {
            Debug.Log("Game Over");
            gameHasEnded = true;
            Invoke("Restart", delay);
        }
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
