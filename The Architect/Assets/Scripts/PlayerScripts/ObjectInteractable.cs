using UnityEngine;

public class ObjectInteractable : MonoBehaviour, IInteractable
{
    [SerializeField] private string interactText;

    public void Interact(Transform interactorTransform)
    {
        ChatBubble3D.Create(transform.transform, new Vector3(-.3f, 1.7f, 0f), "Hello there!");
    }

    public string GetInteractText()
    {
        return interactText;
    }

    public Transform GetTransform()
    {
        return transform;
    }
}
