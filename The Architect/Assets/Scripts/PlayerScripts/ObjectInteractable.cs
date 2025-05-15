using UnityEngine;

public class ObjectInteractable : MonoBehaviour, IInteractable
{
    [SerializeField] private string interactText;
    [TextArea][SerializeField] private string itemInspectInfo;
    private InspectController inspectController;

    private void Awake()
    {
        inspectController = FindAnyObjectByType<InspectController>();
    }

    public void Interact(Transform interactorTransform)
    {
        ShowInspectInfo();
    }

    public void ShowInspectInfo()
    {
        inspectController.Inspect(itemInspectInfo);
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
