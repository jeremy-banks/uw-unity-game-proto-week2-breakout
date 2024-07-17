using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
    Vector2 startPos = new Vector2(0f, -4.5f);

    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = startPos;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
