using TMPro;
using UnityEngine;

public class InspectController : MonoBehaviour
{
    [SerializeField] private float onScreenTimer;
    [SerializeField] private TextMeshProUGUI extraInfoUI;
    [SerializeField] private GameObject extraInfoBG;
    [HideInInspector] public bool startTimer;
    private float timer;

    private void Start()
    {
        extraInfoBG.SetActive(false);
    }

    private void Update()
    {
        if (startTimer)
        {
            timer -= Time.deltaTime;

            if (timer <= 0)
            {
                timer = 0;
                ClearInspect();
                startTimer = false;
            }
        }
    }

    public void Inspect(string newInfo)
    {
        timer = onScreenTimer;
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
