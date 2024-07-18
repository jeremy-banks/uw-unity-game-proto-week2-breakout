using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    float hor, vert;

    [SerializeField] float rotSpeed;
    [SerializeField] float movSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hor = Input.GetAxisRaw("Horizontal");
        vert = Input.GetAxisRaw("Vertical");

        gameObject.transform.Rotate(0f, 0f, hor * rotSpeed * Time.deltaTime);
        gameObject.transform.Translate(0f, -vert * movSpeed * Time.deltaTime, 0f);
    }
}
