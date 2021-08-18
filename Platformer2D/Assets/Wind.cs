
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    Rigidbody2D rb1;
    // Start is called before the first frame update
    void Start()
    {
        rb1 = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb1.velocity = new Vector2(-0.2f, 0f);
    }
}
