using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Instantiate : MonoBehaviour
{
    //public Vector3 Offset;
    public GameObject ScoresTab;
    public GameObject AddTab;

    Vector3 lastPosition = new ();
    Vector3 Offset = new (0,70,0);

    public void NewListTab()
    {
        //GameObject ScoresTab = Instantiate(ScoresTab,transform.position,transform.rotation) as GameObject;
        // ScoresTab.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
        // GameObject ScoresNew = GameObject.Instantiate(ScoresTab,Vector3.zero, Quaternion.identity, GameObject.FindGameObjectWithTag("Canvas").transform);
        //GameObject AddTab = Instantiate(ScoresTab, transform.position, transform.rotation) as GameObject;
        //GameObject AddTab = GameObject.Instantiate(ScoresTab, new Vector3(0, 10, 0), Quaternion.identity) as GameObject;



        GameObject AddTabi = GameObject.Instantiate(ScoresTab, lastPosition - Offset, Quaternion.identity) as GameObject;
        AddTabi.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
        
        lastPosition=ScoresTab.transform.position;
       

        
        //GameObject Tab = Instantiate(AddTab, Vector3.zero, Quaternion.identity) as GameObject;
        //Tab.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
    } 



    public void DestroyAddTab(GameObject AddTab)
    {
        Destroy(AddTab);
    }

}