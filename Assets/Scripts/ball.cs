using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    private Rigidbody2D myRB;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector2(500f, 500f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
