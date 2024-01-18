using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(Collider2D))]
public class DoActionOnClick : MonoBehaviour
{
    [SerializeField] private UnityEvent onClick;

    private void OnMouseUpAsButton()
    {
        onClick?.Invoke();
    }
}