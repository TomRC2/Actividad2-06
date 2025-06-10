using UnityEngine;

public class GameUI : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject gameHUD;

    public void ShowPauseMenu()
    {
        pauseMenu.SetActive(true);
        gameHUD.SetActive(false);
    }

    public void ShowGameHUD()
    {
        gameHUD.SetActive(true);
        pauseMenu.SetActive(false);
    }
}