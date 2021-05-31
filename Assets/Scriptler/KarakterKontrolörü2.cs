using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class KarakterKontrolörü2 : MonoBehaviour
{
    private NavMeshAgent agent;
    void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        if(Input.GetMouseButtonDown(1))
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
            {
                Debug.Log(hit.point);
                agent.SetDestination(hit.point);
            }
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
            {
                agent.SetDestination(hit.point);
                if(hit.collider.tag == "shop")
                {
                    ShopAç(hit.collider.GetComponent<StatikShopNPC>());
                }
            
            
            }
        }
    }

    public void ShopAç(StatikShopNPC NPC)
    {

    }




}
