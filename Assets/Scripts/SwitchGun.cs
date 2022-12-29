using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchGun : MonoBehaviour
{
    public List<GameObject> Guns = new List<GameObject>();
    private int count;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        ScrollToSwitchWeapon(scroll);
    }

    void ScrollToSwitchWeapon(float scroll){
        if(count>=0 && count<= Guns.Count){
            if(scroll>0f){
                count++;
            }else{
                count--;
            }
        }
        
    }
}
