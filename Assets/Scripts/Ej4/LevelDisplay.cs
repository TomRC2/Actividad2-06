using UnityEngine;
using UnityEngine.UI;

public class LevelDisplay : MonoBehaviour
{
    public Text levelText;

    public void UpdateLevelUI(int level)
    {
        levelText.text = "Nivel: " + level;
        //aca profe si queres podes poner lo de cambiar de escena, yo lo hice asi para testear todo
    }
}