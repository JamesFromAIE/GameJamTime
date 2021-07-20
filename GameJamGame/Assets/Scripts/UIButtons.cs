using UnityEngine;
using UnityEngine.SceneManagement;


public class UIButtons : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("AssetHandler");
    }

    public void EndGame()
    {
        Application.Quit();
    }
}
