using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    private Rigidbody2D playerRigidbody2D;

    private float movePlayerHorizontal;
    private float movePlayerVertical;
    private Vector2 movement;

    public float speed = 4f;

    public void Awake()
    {
        playerRigidbody2D = (Rigidbody2D)GetComponent(typeof(Rigidbody2D));
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movePlayerHorizontal = Input.GetAxis("Horizontal");
        movePlayerVertical = Input.GetAxis("Vertical");
        movement = new Vector2(movePlayerHorizontal, movePlayerVertical);

        playerRigidbody2D.velocity = movement * speed;
    }
}
