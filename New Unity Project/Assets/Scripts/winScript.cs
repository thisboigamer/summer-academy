using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider colliderInfo)
    {
        if (colliderInfo.tag == "Player")
        //Collider target = Collider.GetComponent(colliderInfo.tag);
        {
            Debug.Log("You Win!");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
