using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyController : MonoBehaviour {

    float delta = 0;
    float span;
    string motion="false";
    float Before_x;
    float Before_y;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
         this.span = 2.0f;
        this.delta += Time.deltaTime;
        this.motion = "false";
        this.Before_x = transform.position.x;
        this.Before_y = transform.position.y;

        if (span < this.delta)
        {
            int Rand_move = Random.Range(1, 5);

            this.delta = 0;

            if(motion=="false"){

            if (Rand_move == 1)
            { motion = "jump_Front"; };

            if (Rand_move == 2)
            { motion = "jump_Back"; };

            if (Rand_move == 3)
            { motion = "jump"; };

            if (Rand_move == 4)
            { motion = "false"; }

            }

            if (motion=="jump_Front"){

                if(transform.position.x<5.0){

                    if(transform.position.x<=this.Before_x+0.2f){
                    transform.Translate(-0.1f, 0.1f, 0);
                    }
                    else if (transform.position.y!=this.Before_y){
                    transform.Translate(0, -0.2f, 0);
                    }
                    else{
                        this.delta = 0;
                    }
                   }

            }
        }

	}
}
