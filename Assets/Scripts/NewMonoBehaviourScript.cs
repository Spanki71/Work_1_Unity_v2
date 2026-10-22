using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    float speed;
    public float a;
    public float b;
    public float c;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        a = 50;
        b = a + 40;
        c = a + b;
        speed = c;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
