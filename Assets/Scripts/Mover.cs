using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Move the game object
        GetComponent<Rigidbody2D>().AddForce(
            new Vector2(2, -5), ForceMode2D.Impulse);
    }

}
