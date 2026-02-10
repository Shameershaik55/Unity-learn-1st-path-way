using UnityEngine;

public class Delegate : MonoBehaviour
{

    public delegate void MyDelegate();
    MyDelegate myAction;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
     myAction= SayHello;  
     myAction(); 
    }

    // Update is called once per frame
    void SayHello()
    {
        Debug.Log("Hello from Delegate");
    }

}
