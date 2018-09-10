using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinAttackGenerator : MonoBehaviour {


    public GameObject player = GameObject.Find("player");
    public GameObject Attack = GameObject.Find("SpinAttackPrefab");
   //public GameObject Attack_effect = GameObject.Find("EffectAttactPrefab");
    float fire_y;
    float delta = 0;
    float span = 0.5f;
    float frame = 0;
    float crash = 0;
    bool bombOn = false;
    // Use this for initialization
	void Start () {
        this.fire_y = -10;
	}
	
	// Update is called once per frame
	void Update () {

        /*

       // GameObject bomb = Instantiate(Attack_effect) as GameObject;
       // bomb.transform.position = new Vector2(100, 100);
        if (this.crash< 100000){
            this.frame += 1;

        } //프레임수 

        //if(frame)
       
        if (this.frame >= this.crash){
            if(this.fire_y <2){

               // bomb.transform.position = new Vector2(6, this.fire_y);
                this.bombOn = true;
                this.frame = 0.0f;
                this.crash = 100000.0f;
               / Destroy(bomb);

            }
            else{
            this.frame = 0.0f;
            this.crash =100000.0f;
            }


        }*/
     
        if(Input.GetKeyDown(KeyCode.A)){


            this.fire_y = player.transform.position.y;
            GameObject go = Instantiate(Attack) as GameObject;
            go.transform.position = (player.transform.position);
            this.crash =(6 - player.transform.position.x)/0.3f;  // 몇프레임 후 충돌인지 계산  0.3f는 구체의 매프레임간의 이동량

        }
	}
}
