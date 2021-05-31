using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterKontrolörü : MonoBehaviour
{
    public float Hız;
    public GameObject KafaIK;
    public Vector3 Fark;
    public GameObject armature;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Hedef = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        gameObject.transform.position = gameObject.transform.position + Hedef*Hız/100;

        gameObject.transform.Rotate(0, Input.GetAxis("Mouse X"),0);

        KafaIK.transform.RotateAround(gameObject.transform.position,new Vector3(0, 1, 0), Input.GetAxis("Mouse X")/5);
        KafaIK.transform.RotateAround(gameObject.transform.position, new Vector3(-1, 0, 0), Input.GetAxis("Mouse Y")/5);

        //Camera.main.transform.Rotate(-Input.GetAxis("Mouse Y"), Input.GetAxis("Mouse X"), 0,Space.World);
    }
}
