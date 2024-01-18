using System.Collections;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class AnimateOnClick : MonoBehaviour
{
    [SerializeField] private Animator animator;
    [SerializeField] private string runAnimation;
    [SerializeField] private string idleAnimation;
    [SerializeField] [Range(0, 10)] private float maxTimeToPlay;

    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void OnMouseUpAsButton()
    {
        if (string.IsNullOrEmpty(runAnimation) || string.IsNullOrEmpty(idleAnimation))
        {
            Debug.LogError("'Run Animation' and 'Idle Animation' cannot be empty!");
        }
        else
        {
            StartCoroutine(PlayTime());
        }
    }

    private IEnumerator PlayTime()
    {
        animator.Play(runAnimation);
        yield return new WaitForSeconds(maxTimeToPlay);
        animator.Play(idleAnimation);
    }
}