using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Movable selfMovable;
    PlayerController selfController;
    
    public float speed = 1;
    
    void Start()
    {
        selfMovable = GetComponent<Movable>();
        selfController = GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
    }
}
