using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayUI : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
}
