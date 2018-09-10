using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectGenerator : MonoBehaviour
{

    // Use this for initialization
    public GameObject effect = GameObject.Find("EffectAttackPrefab");
    public GameObject player = GameObject.Find("pig_gold");
    float cal = 100.0f;
    bool fire = false;
    float frame = 0;
    float fire_start_y = 10;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (this.fire)
        {
            this.frame += 1;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            if(player.transform.position.y<2.0f){
            GameObject go = Instantiate(effect) as GameObject;
            go.transform.position = new Vector2(player.transform.position.x + 100, player.transform.position.y + 100);
            }
            //this.cal = (6.5f- player.transform.position.x)/0.3f;
            // this.fire = true;
            //fire_start_y = player.transform.position.y;


        }
        // if(frame>=cal){
        //  GameObject bomb = Instantiate(effect) as GameObject;
        //  bomb.transform.position = new Vector2(6, fire_start_y);
        //   this.frame = 0.0f;
        //   this.cal = 100.0f;
        //   this.fire = false;

    }

}
