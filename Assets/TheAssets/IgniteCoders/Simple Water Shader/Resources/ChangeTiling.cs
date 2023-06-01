using UnityEngine;

public class ChangeTiling : MonoBehaviour
{
    public Vector2 tiling = new Vector2(1, 1);

    void Start()
    {
        Renderer renderer = GetComponent<Renderer>();
        Material material = renderer.material;
        material.mainTextureScale = tiling;
    }
}