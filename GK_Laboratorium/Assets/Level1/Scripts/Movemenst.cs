using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movemenst : MonoBehaviour
{
    public CharacterController player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            player.SimpleMove(Vector3.left *3);
        }
        if (Input.GetKey(KeyCode.A))
        {
            player.SimpleMove(Vector3.right * 3);
        }

        if (Input.GetKey(KeyCode.W))
        {
            player.SimpleMove(Vector3.back * 3);
        }
        if (Input.GetKey(KeyCode.S))
        {
            player.SimpleMove(Vector3.forward * 3);
        }
    }
}
