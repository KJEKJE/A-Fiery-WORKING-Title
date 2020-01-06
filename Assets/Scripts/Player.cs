using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Animator fbAnim; //where fb is fireball
    private void Start()
    {
        fbAnim = GetComponent<Animator>();//stores for later
    }
    private void Update()
    {
        if (Input.GetMouseButton(0))//when mouse pressed
        {
            fbAnim.SetBool("Firing?", true);
        }
        else//when not pressed, or released
        {
            fbAnim.SetBool("Firing?", false);
        }
    }
}
