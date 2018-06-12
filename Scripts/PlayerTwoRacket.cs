using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwoRacket : MonoBehaviour {
    public float movementSpeed = 100;
    public GameObject ball;

    private void FixedUpdate()
    {
       //if (PlayerPrefs.GetString("idAI")==false) {
            float axis = Input.GetAxisRaw("Vertical2");
            GetComponent<Rigidbody2D>().velocity = new Vector2(0, axis) * movementSpeed;
       // }
    }
}
