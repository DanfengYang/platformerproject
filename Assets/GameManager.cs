
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{ public float restartDelay = 1f;
    bool gameHasEnded = false;
    public void EndGame() {
        //if (gameHasEnded == false)
        //{
            //gameHasEnded = true;
            Debug.Log("endgame");
        //Invoke("Restart", restartDelay);
        Restart();
        //}
    }
    void Restart() {

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Global.health = 10;
    }
}
