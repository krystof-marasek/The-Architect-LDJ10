using UnityEngine;

public class FlickeringLight : MonoBehaviour
{
    private Light theLight;
    public float maxWait = 1;
    public float maxFlicker = 0.2f;

    float timer;
    float interval;
    private bool stopFlicker = false;

    private void Awake()
    {
        theLight = GetComponent<Light>();
    }

    void Update()
    {
        if (!stopFlicker)
        {
            timer += Time.deltaTime;
            if (timer > interval)
            {
                ToggleLight();
            }
        }
    }

    void ToggleLight()
    {
        theLight.enabled = !theLight.enabled;
        if (theLight.enabled)
        {
            interval = Random.Range(0, maxWait);
        }
        else
        {
            interval = Random.Range(0, maxFlicker);
        }

        timer = 0;
    }

    public void ChangeColor()
    {
        theLight.color = new Color(144f / 255f, 238f / 255f, 144f / 255f);
        stopFlicker = true;
    }
}
