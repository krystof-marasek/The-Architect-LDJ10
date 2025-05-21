using UnityEngine;
using UnityEngine.Events;

public class ObjectInteractable : MonoBehaviour, IInteractable
{
    [Header("Interact/Inspect")]
    [SerializeField] private string interactText;
    [TextArea][SerializeField] private string itemInspectInfo;
    [SerializeField] private float setOnScreenTime;
    private InspectController inspectController;

    [Header("Events")]
    [SerializeField] private UnityEvent onInteract;

    public UnityEvent OnInteract => onInteract;

    private void Awake()
    {
        inspectController = FindAnyObjectByType<InspectController>();
    }

    public void Interact(Transform interactorTransform)
    {
        ShowInspectInfo();
        onInteract?.Invoke();
    }

    public void ShowInspectInfo()
    {
        if (setOnScreenTime >= 1)
        {
            inspectController.Inspect(itemInspectInfo, setOnScreenTime);
        }
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
