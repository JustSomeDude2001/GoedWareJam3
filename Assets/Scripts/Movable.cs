using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movable : MonoBehaviour
{
    Rigidbody2D selfRigidBody;

    // Start is called before the first frame update
    void Start()
    {
        selfRigidBody = GetComponent<Rigidbody2D>();
    }
    
    public void Move(Vector2 vector) {
        selfRigidBody.AddForce(vector, ForceMode2D.Impulse);
    }
}
