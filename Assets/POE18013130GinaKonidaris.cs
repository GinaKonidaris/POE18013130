using Assets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POE18013130GinaKonidaris : MonoBehaviour {
    //Creating the Building StoryingClass
    public GameObject BuildingFactory;
    private GameObject BuildingRescoures;
    private GameObject Unit;

    //Game Timer
    public float MyTimer = 3.0f;
    private float EndTimer = 0.0f;
	// Use this for initialization
	void Start () {
        Vector3 pos = new Vector3(this.transform.position.x + 1, 2,this.transform.position.z + 1);
        this.BuildingRescoures = GameObject.Instantiate(this.BuildingFactory, pos, this.transform.rotation) as GameObject;
        this.BuildingRescoures.GetComponent<Building>().mystorage = this.gameObject;
        this.Unit = GameObject.FindGameObjectsWithTag("MeleeUnit") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if(this.EndTimer > Time.time)
        {
            //code  will come soon
        }
        else if(this.EndTimer == 0.0f)
        {
            ; 
        }
        else
        {
            this.EndTimer = 0.0f;
            this.BuildingRescoures.GetComponent<Building>().GOTO_RESOURCE = true;
            //Gives Units Resources
            this.Unit.GetComponent<MeleeUnit>().NUM_RESOURCES += 1;
        }
	}
    private void OnCollisionEnter(Collision c)
    {
        if(c.transform.tag.Equals("CollectorUnit"))
        {
            c.transform.GetComponent<Building>().GOTO_STORAGE = false;
            // starts timer for Game
            this.EndTimer = this.MyTimer + Time.time;
        }
    }
}
