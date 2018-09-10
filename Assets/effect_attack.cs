using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effect_attack : MonoBehaviour {


    float loc_x;
    float loc_y;
    float frames;
    float D=100.0f;

    void Start()
    {
        this.loc_x = transform.position.x - 100.0f;
        this.loc_y = transform.position.y - 100.0f;
        this.frames = 0;
        this.D = (6 - this.loc_x) / 0.3f;
    }

    // Update is called once per frame
    void Update()

    {
       
  

       

        this.frames += 1;

        if (this.frames >= (this.D + 5.0f))
        {
            Destroy(gameObject);
        }
        if (this.frames > this.D){

            transform.position = new Vector2(6.0f, loc_y);

        }

    }
}