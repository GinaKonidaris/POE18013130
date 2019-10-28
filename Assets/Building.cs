using UnityEngine;
using System.Collections;

public class Building : MonoBehaviour
{
    public GameObject BuildingResource;
    public GameObject mystorage;

    public bool GOTO_RESOURCE;
    public bool GOTO_STORAGE;

    public int ResourcesGiven;

    private void Start()
    {
        this.BuildingResource = GameObject.FindGameObjectsWithTag("ResourcesGiven") as GameObject;
        this.GOTO_RESOURCE = true;
        this.GOTO_STORAGE = false;

        this.ResourcesGiven = 0;
    }

    private void Update()
    {
        if(this.GOTO_RESOURCE)
        {
            //makes player go to building for resources
            Vector3 refillHeading = this.BuildingResource.transform.position - this.transform.position;
            refillHeading.Normalize();
            this.transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(refillHeading), 10 * Time.deltaTime);
            this.transform.Translate(Vector3.forward * Time.deltaTime);
        }
        if(this.GOTO_STORAGE)
        {
            Vector3 refillHeading = this.BuildingResource.transform.position - this.transform.position;
            refillHeading.Normalize();
            this.transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(refillHeading), 10 * Time.deltaTime);
            this.transform.Translate(Vector3.forward * Time.deltaTime);
        }
    }
}