using UnityEngine;

public class AudioEffectsTrigger : MonoBehaviour
{
    [SerializeField] private AudioSource audioClip;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!audioClip.isPlaying) 
            {
                PlayAudio();
            }
        }
    }

    public void PlayAudio()
    {
        audioClip.Play();
    }

    public void StopAudio()
    {
        audioClip.Stop();
    }
}
