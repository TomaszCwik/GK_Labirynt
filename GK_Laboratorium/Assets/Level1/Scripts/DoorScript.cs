using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{

    private bool slide ;
    private float speed = 3;
    public KeyCode openningKey;
    public Vector3 endPosition;
    Vector3 startPosition;
    GameObject doors;
    bool isOpen = false;
    Animator anim;

    private void Awake()
    {
        doors = transform.Find("doors").gameObject;
        startPosition = doors.transform.position;
        anim = doors.GetComponent<Animator>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(openningKey))
<<<<<<< HEAD
            { 
=======
            {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> parent of b023ce5... Dodanie Mostu
=======
>>>>>>> parent of b023ce5... Dodanie Mostu
=======
>>>>>>> parent of b023ce5... Dodanie Mostu
=======
>>>>>>> parent of b023ce5... Dodanie Mostu
=======
>>>>>>> parent of b023ce5... Dodanie Mostu
                if (slide)
                {
                    StartCoroutine(SlideDoors());
                }
            }
        }
    }

    IEnumerator SlideDoors()
    {
        Vector3 current = doors.transform.position;
        Vector3 destination = isOpen ? startPosition : endPosition;
        isOpen = !isOpen;
        float t = 0f;
        while (t < 1)
        {
            t += Time.deltaTime * speed;
            doors.transform.position = Vector3.Lerp(current, destination, t);
            yield return null;
        }
    }

}