using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zeminTespit : MonoBehaviour
{
    public float yEkseni = 0.7f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position = new Vector3(gameObject.transform.position.x, yEkseni, gameObject.transform.position.z);


        RaycastHit Hit;
        if(Physics.Raycast(gameObject.transform.position,-gameObject.transform.up,out Hit))
        {
            Debug.DrawRay(gameObject.transform.position, -gameObject.transform.up, Color.red);
            if(Hit.distance >= 0 && Hit.distance < 0.4f)
            {
                yEkseni += Time.deltaTime*2 ;
            }
            if (Hit.distance > 0.4f)
            {
                yEkseni -= Time.deltaTime*2;
            }

        }
        //Debug.Log(Hit.distance);
    }
}
