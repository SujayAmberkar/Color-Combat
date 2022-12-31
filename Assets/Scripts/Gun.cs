using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Gun : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Recoil(Input.GetMouseButtonDown(0));
    }

    void Recoil(bool isFiring){
        anim.SetBool("isFiring",isFiring);
    }

}
