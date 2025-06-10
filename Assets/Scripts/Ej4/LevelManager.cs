using UnityEngine;
using UnityEngine.Events;

public class LevelManager : MonoBehaviour
{
    public UnityEvent<int> onLevelChanged;
    private int currentLevel = 1;

    public void NextLevel()
    {
        currentLevel++;
        onLevelChanged.Invoke(currentLevel);
    }
}