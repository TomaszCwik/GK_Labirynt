using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BridgeMechanizm : MonoBehaviour
{
    GameObject Mechanizm;
    public KeyCode openningKey;
    bool isOpen = false;
    Animator anim;

    private void Awake()
    {
        Mechanizm = transform.Find("Mechanizm").gameObject;
        anim = Mechanizm.GetComponent<Animator>();
    }//coś tu kurwa nie działą

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(openningKey))
            {

                if (!isOpen)
                {
                    isOpen = !isOpen;
                    anim.SetBool("isOpened2", true);
                }
                else
                {
                    isOpen = !isOpen;
                    anim.SetBool("isOpened2", false);
                }
            }
        }
    }
}