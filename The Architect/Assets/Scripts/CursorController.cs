using UnityEngine;

public class CursorController : MonoBehaviour
{
    private bool _cursorLocked;

    void Start()
    {
        // Hide cursor
        Cursor.lockState = CursorLockMode.Locked;
        _cursorLocked = true;
    }

    // Toggle mouse cursor lock mode
    public void Hide_ShowMouseCursor()
    {
        if (!_cursorLocked)
        {
            Cursor.lockState = CursorLockMode.Locked;
            _cursorLocked = true;
        }
        else
        {
            Cursor.lockState = CursorLockMode.None;
            _cursorLocked = false;
        }
    }
}
