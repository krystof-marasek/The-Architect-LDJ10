using UnityEngine;

public class KeypadInteractable : MonoBehaviour, IInteractable
{
    public CursorController cursor;
    private bool onKeypadCamera = false;
    
    [SerializeField] private Camera keypadCamera;
    [SerializeField] private Camera playerCamera;

    private void ChangeToKeypadCamera()
    {
        if (!onKeypadCamera)
        {
            cursor.Hide_ShowMouseCursor();

            playerCamera.enabled = false;
            keypadCamera.enabled = true;

            onKeypadCamera = true;
        }
        else {
            ChangeToPlayerCamera();
        }
    }

    public void ChangeToPlayerCamera()
    {
        cursor.Hide_ShowMouseCursor();

        keypadCamera.enabled = false;
        playerCamera.enabled = true;

        onKeypadCamera = false;
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
