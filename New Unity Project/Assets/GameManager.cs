using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1f;

    public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;

            Debug.Log("GAME OVER");
            //restart game - function defined below
            Invoke("Restart", restartDelay);
        }
       
    }

    void Restart ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void WinGame()
    {
        Debug.Log("YOU WIN!");
    }
}
