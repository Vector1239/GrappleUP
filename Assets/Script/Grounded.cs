using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{
    public GameObject Gun;
    [SerializeField] Transform groundCheckCollider;
    [SerializeField]LayerMask groundLayer;
    const float groundCheckRadius = 0.2f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        GroundCheck();
    }

    void GroundCheck()
    {
        Gun.GetComponent<Tutorial_GrapplingGun>().isGrounded = false;
        Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheckCollider.position, groundCheckRadius,groundLayer);
        if(colliders.Length>0)
        {
            Gun.GetComponent<Tutorial_GrapplingGun>().isGrounded = true;
            //SoundManager.PlaySound("ground");

        }
    }
}
