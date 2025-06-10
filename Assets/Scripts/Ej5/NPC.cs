using UnityEngine;
using UnityEngine.Events;

public class NPC : MonoBehaviour
{
    public UnityEvent onInteract;

    public void Interact()
    {
        onInteract.Invoke();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Interact();
    }
}