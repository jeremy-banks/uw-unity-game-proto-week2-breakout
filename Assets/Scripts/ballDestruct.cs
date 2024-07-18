using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballDestruct : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Zapper"))
        {
            Destroy(gameObject);
        }
    }
}
