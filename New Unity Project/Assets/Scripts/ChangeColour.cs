using UnityEngine;

public class ChangeColour : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Pillar;

    void OnCollisionEnter() 
    {
        var cubeRenderer = Pillar.GetComponent<Renderer>();
        cubeRenderer.material.SetColor("_Color", Color.yellow);
    }
}
