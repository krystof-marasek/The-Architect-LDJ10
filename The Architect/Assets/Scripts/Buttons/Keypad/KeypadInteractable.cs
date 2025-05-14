using UnityEngine;

public class KeypadInteractable : MonoBehaviour, IInteractable
{
    [SerializeField] private Camera keypadCamera;

    private void ChangeToKeypadCamera()
    {
        Debug.Log("Interacted with keypad");
    }

    public void Interact(Transform interactorTransform)
    {
        ChangeToKeypadCamera();
    }

    public string GetInteractText()
    {
        return "Insert code";
    }

    public Transform GetTransform()
    {
        return transform;
    }
}
