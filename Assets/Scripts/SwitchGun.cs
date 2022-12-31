using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchGun : MonoBehaviour
{
    public List<GameObject> Guns = new List<GameObject>();
    private int currentGun=1;
    // Start is called before the first frame update
    void Start()
    {
        EnableSelectedGun();
    }

    // Update is called once per frame
    void Update()
    {
        float scroll = Input.GetAxis("Mouse ScrollWheel");
        ScrollToSwitchWeapon(scroll);
    }

    void ScrollToSwitchWeapon(float scroll){
            if(scroll>0f && currentGun<Guns.Count-1){  //scroll up
                currentGun++;
                Debug.Log(currentGun);
                EnableSelectedGun();
            }else if(scroll<0f && currentGun>0){     //Scroll down
                currentGun--;
                Debug.Log(currentGun);
                EnableSelectedGun();
            }
    }

    void EnableSelectedGun(){
        foreach (var gun in Guns)
        {
            gun.SetActive(false);
        }
        Guns[currentGun].SetActive(true);
    }
}
