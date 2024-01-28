using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAndExit : MonoBehaviour
{
    public Texture2D customCursor;

    private void Start()
    {
        Cursor.SetCursor(customCursor, Vector2.zero, CursorMode.ForceSoftware);
    }

    public void StatGame()
    {
        SceneManager.LoadScene("Chapter 1");
    }

    public void ExitGame()
    {
        Application.Quit();
        Debug.Log("Game close");
    }

}
