using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneRacket : MonoBehaviour {
    public float movementSpeed = 100;
    private void FixedUpdate()
    {
        float axis = Input.GetAxisRaw("Vertical");
        GetComponent<Rigidbody2D>().velocity = new Vector2(0,axis) * movementSpeed;
    }

}
