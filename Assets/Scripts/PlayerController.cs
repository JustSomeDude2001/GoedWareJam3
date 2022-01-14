using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public Vector2 direction = Vector2.zero;
    // Update is called once per frame
    void Update()
    {
        direction = Vector2.zero;
        if (Input.GetKeyDown(KeyCode.W)) {
            direction += Vector2.up;
        }
        if (Input.GetKeyDown(KeyCode.S)) {
            direction += Vector2.down;
        }
        if (Input.GetKeyDown(KeyCode.A)) {
            direction += Vector2.left;
        }
        if (Input.GetKeyDown(KeyCode.D)) {
            direction += Vector2.right;
        }
        direction.Normalize();
    }
}
