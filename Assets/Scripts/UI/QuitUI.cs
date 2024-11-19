using UnityEngine;
using UnityEngine.SceneManagement;

public class QuitUI : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();

    #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; //Only execute inside editor
    #endif
    }
}
