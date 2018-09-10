using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafController : MonoBehaviour {




    public  GameObject Leaf1 = GameObject.Find("white_leaf_Prefab");



    public GameObject Leaf2= GameObject.Find("black_leaf_Prefab");


    float delta1 = 0;

    float span1;
   


    
    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
        this.delta1 += Time.deltaTime;
        this.span1 = 0.5f;
        float px1 = Random.Range(-8.0f, 7.0f);
        float px2 = Random.Range(-8.0f, 7.0f);
       

        Vector3 Rx1 = new Vector3(px1, 7, 0);
        Vector3 Rx2 = new Vector3(px2, 7, 0);
       
       

        if (this.delta1 > this.span1)
        {
            this.delta1 = 0;
            GameObject L1 = Instantiate(Leaf1) as GameObject;
            GameObject L2 = Instantiate(Leaf2) as GameObject;


            L1.transform.position = Rx1;
            L2.transform.position = Rx2;

        }


    }
}
