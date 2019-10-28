using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Collections;

namespace Assets
{
    class Unit : MonoBehaviour
    {
        public GameObject Team;
        public GameObject MyStorage;
        public GameObject MyStorageResources;
        public GameObject MeleeUnit;
        public GameObject MyResources;
        public GameObject Attacking;
        public int Health = 100;
        public int Attack = 25;


        public int NUM_RESOURCES;
        public bool ATTACK;
        public bool INRANGE;

        public Transform[] INRANGEMOVE;
        

    }
}
