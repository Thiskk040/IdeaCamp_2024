using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float playerspeed;
    private Rigidbody2D rb;
    private Vector2 playerDicrection;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        playerDicrection = new Vector2(0, directionY).normalized;
    }
     void FixedUpdate()
    {
        rb.velocity = new Vector2(0, playerDicrection.y * playerspeed);  
    }
}
