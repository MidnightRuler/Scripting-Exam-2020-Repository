using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCaster : MonoBehaviour
{
    public GameManager gameManager;

   

    // Update is called once per frame
    void Update()
    {
           if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject.tag == "Target")
                {
                    gameManager.UpdateScore();

                    hit.collider.gameObject.GetComponent<AandD>().Disappear();
                }
            }
        }
    }
}
