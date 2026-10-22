using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    float speed;
    float test;
    string StTest;
    public float a;
    public float b;
    public float c;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        a = 20;
        b = a + 100;
        c = a + b;
        speed = c;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
