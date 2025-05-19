using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private void Awake()
    {
        // Check if the instance is null
        if (instance == null)
        {
            // Set the instance to this GameManager object
            instance = this;

            // Make the GameManager object persistent across scene changes
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // Destroy the duplicate GameManager object
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        { 
            Application.Quit();
        }
    }
}
