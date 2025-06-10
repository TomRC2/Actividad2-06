using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public GameObject dialoguePanel;

    public void ShowDialogue()
    {
        dialoguePanel.SetActive(true);
    }

    public void HideDialogue()
    {
        dialoguePanel.SetActive(false);
    }
}