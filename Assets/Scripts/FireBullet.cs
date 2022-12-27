using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour
{
    public GameObject[] BallType;   //Array of different balls
    public Transform BulletSpawnPoint;
    public float BallSpeed = 100f;
    private int _CurrentBall = 0;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Fire();
        SetBall();
    }

    void Fire(){
        int currentBall = GetCurrentBall();
        GameObject newBall = BallType[currentBall];
        if(Input.GetMouseButtonDown(0)){
            GameObject bulletInst = Instantiate(newBall,BulletSpawnPoint.position,BulletSpawnPoint.rotation);
            bulletInst.GetComponent<Rigidbody>().velocity = BulletSpawnPoint.transform.forward*BallSpeed;
        }
    }

    public void SetBall(){
        if(Input.GetKey(KeyCode.E)){
            _CurrentBall=0;
        }else if(Input.GetKey(KeyCode.C)){
            _CurrentBall=1;
        }else if(Input.GetKey(KeyCode.Q)){
            _CurrentBall = 2;
        }
    }

    public int GetCurrentBall(){
        return _CurrentBall;
    }
}

