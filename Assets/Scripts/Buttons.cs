using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;



public class Buttons : MonoBehaviour
{   
    public GameObject CreditsPanel;
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void CreditsOn()
    {
        CreditsPanel.SetActive(true);
    }

    public void CreditsOff()
    {
        CreditsPanel.SetActive(false);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }
}
