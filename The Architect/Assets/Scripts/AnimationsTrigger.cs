using UnityEngine;

public class AnimationsTrigger : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void OpenSecretPassage()
    {
        animator.SetInteger("OpenPassage", 1);
    }
}
