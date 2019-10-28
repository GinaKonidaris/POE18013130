using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Collections;

namespace Assets
{
    class BuildingResources : Building
    {
        public GameObject colletorunit;

        //timer
        public float MyTimer = 3.0f;
        private float EndTimer = 0.0f;

        void Start()
        {
            
        }
        private void Update()
        {
             if(this.EndTimer > Time.time)
            {
                //coming soon
            }
            else if(this.EndTimer == 0.0f)
            {
                ; //do nothing then
            }
            else
            {
                this.EndTimer = 0.0f;
                this.colletorunit.GetComponent<BuildingResources>().GOTO_STORAGE = true;
            }
        }
        void OnTriggerEnter(Collider c)
        {
            if(c.tag.Equals("CollectorUnit"))
            {
                c.GetComponent<BuildingResources>().GOTO_RESOURCE = false;
                this.colletorunit = c.gameObject;

                //starts timer
                this.EndTimer = this.MyTimer + Time.time;
            }
        }

    }
}
