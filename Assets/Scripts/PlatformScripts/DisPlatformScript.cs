using UnityEngine;

[RequireComponent(typeof(Animator))]
public class DisPlatformScript : MonoBehaviour
{
    private Animator animator;
    [SerializeField] private float deactivationTime;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Invoke("Deactivate", deactivationTime);
        animator.Play("Fade");
    }

    private void Deactivate()
    {
        gameObject.SetActive(false);
    }

}
