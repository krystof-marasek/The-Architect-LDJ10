using UnityEngine;

public class DoorInteractable : MonoBehaviour, IInteractable
{
    private Animator animator;
    public bool isOpen;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void ToggleDoor()
    {
        isOpen = !isOpen;
        animator.SetBool("IsOpen", isOpen);
    }

    public void Interact(Transform interactorTransform)
    {
        ToggleDoor();
    }

    public string GetInteractText()
    {
        return "Open/Close Door";
    }

    public Transform GetTransform()
    {
        return transform;
    }
}
