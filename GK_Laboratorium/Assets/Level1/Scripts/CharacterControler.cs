using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//dopisane
using UnityEngine.UI;

public class CharacterControler : MonoBehaviour
{
    public Vector3 jump;
    public float jumpForce = 2.5F;
    public float Speed = 5.0F;
    public float RunSpeed = 10.0F;
    public float NormalSpeed=5.0F;
    public bool isRunning = false;
    public bool isGrounded;
    Rigidbody rb;


    //dopisane
    public Text countText;
    private int count;

    //end dopisane

    // Start is called before the first frame update
    void Start()
    {
        //dopisane
        count = 0;
        countText.text = "Count: " + count.ToString();
        //end
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 1.5f, 0.0f);
        Cursor.lockState = CursorLockMode.Locked;
    }

    //dopsane

    void SetCountText()
    {
        countText.text = "Count: " + count.ToString();       
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Diamond"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }
    }



    //
    void OnCollisionStay()
    {
        isGrounded = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
        float translation = Input.GetAxis("Vertical") * Speed;
        float straffe   =  Input.GetAxis("Horizontal") * Speed;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;
        transform.Translate(straffe, 0, translation);
        if (Input.GetKeyDown("escape"))
            Cursor.lockState = CursorLockMode.None;

        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift)) {
            isRunning = true;
            Speed = RunSpeed;
        }
        else
        {
            isRunning = false;
            Speed = NormalSpeed;
            print("Not Running");

        }
    }
}
