using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawn : MonoBehaviour
{
    public GameObject Basketball;
    void Start()
    {
        
    }
    public void BasketballSpawn()
    {
        Instantiate(Basketball, transform.position, transform.rotation);
    }
}
