using UnityEngine;
using UnityEngine.Events;

public class GameStateManager : MonoBehaviour
{
    public UnityEvent onGameStart;
    public UnityEvent onGamePause;

    public void StartGame()
    {
        onGameStart.Invoke();
        Time.timeScale = 1.0f;
    }

    public void PauseGame()
    {
        onGamePause.Invoke();
        Time.timeScale = 0f;
    }
}
