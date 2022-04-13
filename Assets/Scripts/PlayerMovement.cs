using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody playerRb;
    [SerializeField] float speed = 8f;
    [SerializeField] float jumpStrength = 5f;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
            playerMovement();        
    }
    void playerMovement(){
        float verticalInput = Input.GetAxis("Vertical");
        float horizontalInput = Input.GetAxis("Horizontal");

        playerRb.velocity = new Vector3(horizontalInput * speed, playerRb.velocity.y, verticalInput * speed);

        if(Input.GetButtonDown("Jump")){
           playerRb.velocity = new Vector3(playerRb.velocity.x, jumpStrength ,playerRb.velocity.z);
        }
    }

    
}
