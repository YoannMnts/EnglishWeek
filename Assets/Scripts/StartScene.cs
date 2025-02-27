using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }
}
