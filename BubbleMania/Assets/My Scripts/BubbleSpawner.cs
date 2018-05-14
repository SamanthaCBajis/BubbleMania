using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleSpawner : MonoBehaviour {

    public Transform spawnPos;
    public GameObject [] spawnee;
    public Vector3 spawnValues;

    int randbub;
	
	// Update is called once per frame
	void Update () {
        if(Input.GetMouseButton(0)) 
        {

                randbub = Random.Range(0, 0);

                Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), 1, Random.Range(-spawnValues.z, spawnValues.z));

                Instantiate(spawnee[randbub], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
            }
        }
	}
