using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AandD : MonoBehaviour
{
    public float nextTime;
    public float currentTime;
    private SphereCollider collider;
    private MeshRenderer renderer;
    public float visibleTime = 2.0f;
    public bool hasAppared = false;

   
    

    private void Start()
    {
       
       
        collider = gameObject.GetComponent<SphereCollider>();
        renderer = gameObject.GetComponent<MeshRenderer>();
        Disappear();

        currentTime = 0.0f;

        // Get a random number!
        nextTime = Random.Range(3.0f, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {
        // get the current time!
        currentTime += Time.deltaTime;



        // Check if Time.time is greater then nextTime 
        if (currentTime > nextTime)
        {

            Appear();

            nextTime = Random.Range(3.0f, 5.0f) + currentTime;

            hasAppared = true;



        }
        if (hasAppared == true)
        {
            visibleTime -= Time.deltaTime;
            if (visibleTime < 0)
            {
                Disappear();
                visibleTime = 2.0f;
                hasAppared = false;
            }
        }
     
    }


    private void Appear()
    {
        collider.enabled = true;
        renderer.enabled = true;
    }

    public void Disappear()
    {
        collider.enabled = false;
        renderer.enabled = false;
    }
}
