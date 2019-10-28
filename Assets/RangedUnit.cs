﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Collections;

namespace Assets
{
    class RangedUnit : Unit
    {
        public GameObject rangedUnit;
        public float myTime = 5.0f;
        private float endTime = 0.0f;
        private int nextMove;

        void Start()
        {
            this.NUM_RESOURCES = 1;
            this.ATTACK = true;
            //finds MeleeUnit
            this.rangedUnit = GameObject.FindGameObjectsWithTag("MeleeUnit") as GameObject;
            this.endTime = this.myTime + Time.time;
            this.nextMove = 0;
        }
        private float SPEED = 2.0f;
        private void Update()
        {
            if (this.endTime<Time.time)
            { // drop the storage
                Vector3 pos = new Vector3(this.transform.position.x + 1, 2, this.transform.position.z + 1);
                this.MyStorageResources = GameObject.Instantiate(this.MyStorage, pos, this.MyStorage.transform.rotation) as GameObject;
                this.endTime = 0.0f;
            }
         
            if(this.NUM_RESOURCES>1)
            {
               this.ATTACK = true;
            } 
            else 
            {
            this.ATTACK = false;
            }

        }
    }
}

