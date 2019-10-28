using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;


namespace Assets
{
    class Wizard :Unit
    {
        public GameObject WizardUnit;
        private int nextMove;
        public float myTime = 5.0f;
        private float endTime = 0.0f;

        void Start()
        {
            transform.position = WizardUnit.transform.position - Vector3.forward * 10f;
            //starts meleeunit with resource
            this.NUM_RESOURCES = 1;
            //tells meleeunit to attack
            this.ATTACK = true;
            //finds other units
            this.WizardUnit = GameObject.FindGameObjectsWithTag("Wizard") as GameObject;
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
            if (this.ATTACK)
            {
                Vector3 refillHeading = this.WizardUnit.transform.position - this.transform.position; refillHeading.Normalize();
                // use Quaternion Slerp function to make smooth transition ... 
                this.transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(refillHeading)
                , 10 * Time.deltaTime);
                this.transform.Translate(Vector3.forward * Time.deltaTime * this.SPEED);
                if (Vector3.Distance(this.MeleeUnit.transform.position, this.transform.position) < 5.0f)
                {
                    if (this.NUM_RESOURCES > 0)
                    {
                        if (this.endTime < Time.time)
                        {
                            //
                        }
                        else
                        {
                            ;
                        }
                    }
                }
            }

            if (ATTACK == true)
            {
                Health = Health - 25;
            }
            else if (ATTACK == false)
            {
                nextMove = 1;
            }
        }

        public bool isdead()
        {
            if (Health < +0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
