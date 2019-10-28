﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Collections;

namespace Assets
{
    class MeleeUnit :Unit
    {
        public GameObject meleeUnit;
        private int nextMove;
        public float myTime = 5.0f;
        private float endTime = 0.0f;

        void Start()
        {
            //starts meleeunit with resource
            this.NUM_RESOURCES = 1;
            //tells meleeunit to attack
            this.ATTACK = true;
            //finds other units
            this.meleeUnit = GameObject.FindGameObjectsWithTag("RangedUnit") as GameObject;
            this.endTime = this.myTime + Time.time;
            this.nextMove = 0;
        }
        private float SPEED = 2.0f;
        private void Update()
        {
            if (this.endTime < Time.time)
            { // drop the storage
                Vector3 pos = new Vector3(this.transform.position.x + 1, 2, this.transform.position.z + 1);
                this.MyStorageResources = GameObject.Instantiate(this.MyStorage, pos, this.MyStorage.transform.rotation) as GameObject;
                this.endTime = 0.0f;
            }

            if (this.NUM_RESOURCES > 1)
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
