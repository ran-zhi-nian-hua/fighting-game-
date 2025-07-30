using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    public float Speed = 5.0f;
    public float JumpForce = 6.0f;
    public Rigidbody2D CharacterRig;
    public Animator CharacterAni;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float XInput = Input.GetAxisRaw("Horizontal");
        float YInput = Input.GetAxisRaw("Vertical");
        CharacterRig.velocity = new Vector2(XInput*Speed,CharacterRig.velocity.y);
        if(XInput!=0)
        {
            CharacterAni.SetBool("ISRun", true);
        }
        else
        {
            CharacterAni.SetBool("ISRun", false);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CharacterRig.velocity = new Vector2(CharacterRig.velocity.x, JumpForce);
        }
    }
}
