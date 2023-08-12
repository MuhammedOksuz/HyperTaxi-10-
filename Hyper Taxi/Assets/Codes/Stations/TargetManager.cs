using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TargetManager : MonoBehaviour
{
    GameObject player;
    public List<TargetManager> itCanGo = new();
    public List<TargetManager> itCanNotGo = new();
    public bool itCanGo_ = false;

    private void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        //itCanGo = new();
    }
    private void Update()
    {
        //StationManager();
        Debug.Log(player.GetComponent<TaxiMovement>().station);
    }
    private void OnMouseDown()
    {
        //if (itCanGo_)
        //{
            if (player.GetComponent<TaxiMovement>().ýtCanMove == false)
            {
                Vector3 mousePos = new Vector3(transform.position.x, player.transform.position.y, transform.position.z); ;
                player.GetComponent<TaxiMovement>().TargetFind(mousePos);
                itCanGo_ = false;
                player.transform.DOScale(new Vector3(0.14f, 0.14f, 0.14f), 0.5f);
            }
        //}
        
    }
    //void StationManager()
    //{
    //    if (player.GetComponent<TaxiMovement>().station == TaxiMovement.Stations.Start)
    //    {
    //        GameObject start = GameObject.FindGameObjectWithTag("Start");
    //        Debug.Log(player.GetComponent<TaxiMovement>().station);
    //        if (start.GetComponent<TargetManager>().itCanGo.Count > 1)
    //        {
    //            for (int i = 0; i < start.GetComponent<TargetManager>().itCanGo.Count; i++)
    //            {
    //                script = start.GetComponent<TargetManager>().itCanGo[i];
    //                script.GetComponent<BoxCollider>().enabled = true;
    //                script.itCanGo_ = true;
    //            }
    //        }
    //        else
    //        {
    //            TargetManager script = start.GetComponent<TargetManager>().itCanGo[0];
    //            script.GetComponent<BoxCollider>().enabled = true;
    //            script.itCanGo_ = true;
    //        }
    //    }
        //if (player.GetComponent<TaxiMovement>().station == TaxiMovement.Stations.Red)
        //{
        //    GameObject red = GameObject.FindGameObjectWithTag("Red");
        //    Debug.Log(player.GetComponent<TaxiMovement>().station);
        //    if (red.GetComponent<TargetManager>().itCanGo.Count > 1)
        //    {
        //        for (int i = 0; i < red.GetComponent<TargetManager>().itCanGo.Count; i++)
        //        {
        //            script = red.GetComponent<TargetManager>().itCanGo[i];
        //            script.GetComponent<BoxCollider>().enabled = true;
        //            script.itCanGo_ = true;
        //        }
        //    }
        //    else
        //    {
        //        TargetManager script = red.GetComponent<TargetManager>().itCanGo[0];
        //        script.GetComponent<BoxCollider>().enabled = true;
        //        script.itCanGo_ = true;
        //    }
        //}
    //}
}
