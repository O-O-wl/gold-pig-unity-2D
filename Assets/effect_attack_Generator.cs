using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript1 : MonoBehaviour {

    // Use this for initialization
    public GameObject player = GameObject.Find("pig_gold");
    float loc_x;
    float loc_y;
    float dir;
    float frame=0;
    bool fire=false;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(this.frame>= this.dir){
            if(this.frame > this.dir){
                Debug.Log("삭!!!!!!"+this.frame);
                Destroy(gameObject);
            }
            transform.position = new Vector2(6, this.loc_y);
            
        }



        if(Input.GetKeyDown(KeyCode.A)){
            this.loc_y = player.transform.position.y;
            this.loc_x = player.transform.position.x;
            this.dir = (6 - loc_x) / 0.3f;
            this.fire = true;

        }

        if(this.fire){
            this.frame += 1;

        }

	}
}
