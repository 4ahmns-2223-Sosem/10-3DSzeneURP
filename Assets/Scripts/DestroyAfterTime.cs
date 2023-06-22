using UnityEngine;

public class DestroyAfterTime : MonoBehaviour
{
    public float lifetime = 7f;

    private void Start()
    {
        Destroy(gameObject, lifetime);
    }
}