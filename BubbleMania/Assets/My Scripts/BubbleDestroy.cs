using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BubbleDestroy : MonoBehaviour
{

    public float LifeTime = 10f;


    // Update is called once per frame
    void Update()
    { 
        if (LifeTime > 0)
            {
                LifeTime -= Time.deltaTime;
                if (LifeTime <= 0)
                {
                    Destruction();
                }
            }

            if (this.transform.position.y <= -20)
            {
                Destruction();
            }
        }

        void OnCollisionEnter(Collision coll)
        {
            if (coll.gameObject.name == "BubbleDestroy")
            {
                Destruction();
            }
        }

        void Destruction()
        {
            Destroy(this.gameObject);
        }
    }
