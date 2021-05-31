using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IkTracker : MonoBehaviour
{
    RaycastHit Hit;
    public GameObject IK;
    public float Mesafe;
    public GameObject Hedef;
    public bool AtabilirMi;
    public IkTracker Eş;
    private void Start()
    {
        IK.transform.position = Hedef.transform.position;
    }

    void Başla()
    {

    }

    void Update()
    {
        Debug.DrawRay(gameObject.transform.position, Vector3.down, Color.red);
        Mesafe = Vector3.Distance(IK.transform.position, Hedef.transform.position);


        if(Mesafe > 0.7f)
        {
            if(!Eş.AtabilirMi && AtabilirMi)
            
            
            StartCoroutine("AdımAt");
        }

    }


    IEnumerator AdımAt()
    {
        IK.transform.position = Hedef.transform.position;
        AtabilirMi = false;
        yield return new WaitForSeconds(0.2f);
        Eş.AtabilirMi = true;
        yield return null;
    }

}
