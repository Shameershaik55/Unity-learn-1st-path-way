using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player; 
    private Vector3 offset= new Vector3(0,5,-7);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = player.transform.position+ offset;
    }
}
