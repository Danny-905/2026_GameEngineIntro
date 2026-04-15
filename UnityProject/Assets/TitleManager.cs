using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleManager : MonoBehaviour
{
    public void GameStart()
    {
        SceneManager.LoadScene("PlayScene_Door1");
    }
    public void GoToLobby()
    {
        SceneManager.LoadScene("TitleScene");
    }

    public void ExitGame() => Application.Quit();
    
}
