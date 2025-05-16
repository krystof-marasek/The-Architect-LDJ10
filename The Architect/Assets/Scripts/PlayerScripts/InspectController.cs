using TMPro;
using UnityEngine;

public class InspectController : MonoBehaviour
{
    //public float onScreenTimer;
    [SerializeField] private TextMeshProUGUI extraInfoUI;
    [SerializeField] private GameObject extraInfoBG;
    [HideInInspector] public bool startTimer;
    private float inspectControllerTimer;

    private void Start()
    {
        extraInfoBG.SetActive(false);
    }

    private void Update()
    {
        if (startTimer)
        {
            inspectControllerTimer -= Time.deltaTime;

            if (inspectControllerTimer <= 0)
            {
                inspectControllerTimer = 0;
                ClearInspect();
                startTimer = false;
            }
        }
    }

    public void Inspect(string newInfo, float onScreenTimer)
    {
        inspectControllerTimer = onScreenTimer;
        startTimer = true;
        extraInfoBG.SetActive(true);
        extraInfoUI.text = newInfo;
    }

    void ClearInspect()
    {
        extraInfoBG.SetActive(false);
        extraInfoUI.text = "";
    }
}
