using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.Collections;
using Random = UnityEngine.Random;

namespace Assets
{
    class Map : MonoBehaviour
    {
        public GameObject UnitType;
        public int size;
        private Map[,] map;
        new Unit unit;
       
        // Use this for initialization
        void Start()
        {
            map = new Map[size, size];

            for (int x = 0; x < size; x++)
            {
                for (int z = 0; z < size; z++)
                {
                    Map t = new Map();
                    if (Random.Range(0, 100) > 80)
                    {
                        t.unit = UnitType.Attack;
                    }
                    else
                    {
                        t.unit = UnitType.map;
                    }
                    map[x, z] = t;
                }
            }


            for (int x = 0; x < size; x++)
            {
                for (int z = 0; z < size; z++)
                {
                    switch (map[x, z].UnitType)
                    {
                        case Unit.Map:
                            Instantiate(UnitType, new Vector3(x, 0, z), Quaternion.identity);
                            break;
                        case UnitType.Attack:
                            Instantiate(UnitType, new Vector3(x, 0, z), Quaternion.identity);
                            break;
                        case UnitType.Hit:
                            Instantiate(UnitType, new Vector3(x, 0, z), Quaternion.identity);
                            break;
                    }
                }
            }
        }
        // Update is called once per frame
        void Update()
        {


        }

    }
}
