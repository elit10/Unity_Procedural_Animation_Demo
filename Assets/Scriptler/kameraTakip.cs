using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameraTakip : MonoBehaviour
{
    public GameObject Hedef;
    public Vector3 fark;
    
    void Start()
    {
        HedefBelirle(Hedef);
    }

    public void HedefBelirle(GameObject belirlenecek)
    {
        fark = gameObject.transform.position - belirlenecek.transform.position;
    }

    void Update()
    {
        TakipEt(Hedef);
    }

    public void TakipEt(GameObject TakipEdilecek)
    {
        Vector3 gerçekHedef = TakipEdilecek.transform.position + fark;
        gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, gerçekHedef, Time.deltaTime/1.5f);

    }
    


}
