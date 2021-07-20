using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class UIButtons : MonoBehaviour
{
    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("AssetHandler");

    }

    public void EndGame()
    {
        Application.Quit();
    }

}
