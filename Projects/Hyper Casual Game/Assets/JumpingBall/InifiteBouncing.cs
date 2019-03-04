using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InifiteBouncing : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetAxis("Horizontal") > 0) {
            Vector2 curr = this.gameObject.GetComponent<Rigidbody>().velocity;
            this.gameObject.GetComponent<Rigidbody>().velocity = new Vector2(1, curr.y);
        }
    }
    
    private void OnCollisionEnter(Collision other)
    {
        Debug.Log('!');
        this.gameObject.GetComponent<Rigidbody>().velocity = new Vector2(0, 3);
    }
}
