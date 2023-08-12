using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TaxiMovement : MonoBehaviour
{
    //TaxiMove
    public bool ýtCanMove = false;
    //Enum
    public enum Stations {Start , Red , Blue , Green , Yellow }
    public Stations station;
    //Fuel
    [SerializeField] Image fuel_Img;
    float fuelCounter = 100f;
    private void Update()
    {
         StationsUpdate();
    }
    public void TargetFind(Vector3 target)
    {
        StartCoroutine(TargetDoMove(target));
    }
    public IEnumerator TargetDoMove(Vector3 targetPos)
    {
            ýtCanMove = true;
            this.transform.DOMove(targetPos - new Vector3(0.1f, 0, 0.1f), 1f);
            transform.LookAt(targetPos);
            yield return new WaitForSeconds(1);
            ýtCanMove = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Start"))   
        {
            station = Stations.Start;
            fuelCounter -= 20;
            fuel_Img.fillAmount = fuelCounter / 100;
        }
        else if (other.CompareTag("Red")) 
        {
            station = Stations.Red;
            fuelCounter -= 20;
            fuel_Img.fillAmount = fuelCounter / 100 ;
            transform.DOScale(new Vector3(0.02f, 0.02f, 0.02f), 0.5f);
            other.transform.DOScale(new Vector3(0.6f, 2.1f, 0.6f), 0.2f).OnComplete(() =>
            {
                other.transform.DOScale(new Vector3(0.5f, 2f, 0.5f), 0.2f);
            }); 
        }
        else if (other.CompareTag("Blue")) 
        {
            station = Stations.Blue;
            fuelCounter = 100;
            fuel_Img.fillAmount = fuelCounter / 100;
            transform.DOScale(new Vector3(0.02f, 0.02f, 0.02f), 0.5f);
            other.transform.DOScale(new Vector3(0.8f, 0.8f, 0.8f), 0.2f).OnComplete(() =>
            {
                other.transform.DOScale(new Vector3(0.7f, 0.7f, 0.7f), 0.2f);
            });
        }
        else if (other.CompareTag("Green"))
        {
            station = Stations.Green;
            fuelCounter -= 20;
            fuel_Img.fillAmount = fuelCounter / 100;
            transform.DOScale(new Vector3(0.02f, 0.02f, 0.02f), 0.5f);
            other.transform.DOScale(new Vector3(0.6f, 0.6f, 0.6f), 0.2f).OnComplete(() =>
            {
                other.transform.DOScale(new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            });
        }
        else if(other.CompareTag("Yellow"))
        {
            station = Stations.Yellow;
            fuelCounter -= 20;
            fuel_Img.fillAmount = fuelCounter / 100;
            transform.DOScale(new Vector3(0.02f, 0.02f, 0.02f), 0.5f);
            other.transform.DOScale(new Vector3(0.6f, 0.6f, 0.6f), 0.2f).OnComplete(() =>
            {
                other.transform.DOScale(new Vector3(0.5f, 0.5f, 0.5f), 0.2f);
            });
        }
    }
    void StationsUpdate()
    {
        if (station == Stations.Start) 
        {
            GameObject go = GameObject.FindGameObjectWithTag("Start");
            for (int i = 0; i < go.GetComponent<TargetManager>().itCanGo.Count; i++)
            {
                TargetManager target = go.GetComponent<TargetManager>().itCanGo[i];
                target.GetComponent<BoxCollider>().enabled = true;
            }
            for (int i = 0; i < go.GetComponent<TargetManager>().itCanNotGo.Count; i++)
            {
                TargetManager target = go.GetComponent<TargetManager>().itCanNotGo[i];
                target.GetComponent<BoxCollider>().enabled = false;
            }
        }
        if (station == Stations.Red)
        {
            GameObject go = GameObject.FindGameObjectWithTag("Red");
            for (int i = 0; i < go.GetComponent<TargetManager>().itCanGo.Count; i++)
            {
                TargetManager target = go.GetComponent<TargetManager>().itCanGo[i];
                target.GetComponent<BoxCollider>().enabled = true;
            }
            for (int i = 0; i < go.GetComponent<TargetManager>().itCanNotGo.Count; i++)
            {
                TargetManager target = go.GetComponent<TargetManager>().itCanNotGo[i];
                target.GetComponent<BoxCollider>().enabled = false;
            }
        }
        if (station == Stations.Yellow)
        {
            GameObject go = GameObject.FindGameObjectWithTag("Yellow");
            for (int i = 0; i < go.GetComponent<TargetManager>().itCanGo.Count; i++)
            {
                TargetManager target = go.GetComponent<TargetManager>().itCanGo[i];
                target.GetComponent<BoxCollider>().enabled = true;
            }
            for (int i = 0; i < go.GetComponent<TargetManager>().itCanNotGo.Count; i++)
            {
                TargetManager target = go.GetComponent<TargetManager>().itCanNotGo[i];
                target.GetComponent<BoxCollider>().enabled = false;
            }
        }
        if (station == Stations.Blue)
        {
            GameObject go = GameObject.FindGameObjectWithTag("Blue");
            for (int i = 0; i < go.GetComponent<TargetManager>().itCanGo.Count; i++)
            {
                TargetManager target = go.GetComponent<TargetManager>().itCanGo[i];
                target.GetComponent<BoxCollider>().enabled = true;
            }
            for (int i = 0; i < go.GetComponent<TargetManager>().itCanNotGo.Count; i++)
            {
                TargetManager target = go.GetComponent<TargetManager>().itCanNotGo[i];
                target.GetComponent<BoxCollider>().enabled = false;
            }
        }
        if (station == Stations.Green)
        {
            GameObject go = GameObject.FindGameObjectWithTag("Green");
            for (int i = 0; i < go.GetComponent<TargetManager>().itCanGo.Count; i++)
            {
                TargetManager target = go.GetComponent<TargetManager>().itCanGo[i];
                target.GetComponent<BoxCollider>().enabled = true;
            }
            for (int i = 0; i < go.GetComponent<TargetManager>().itCanNotGo.Count; i++)
            {
                TargetManager target = go.GetComponent<TargetManager>().itCanNotGo[i];
                target.GetComponent<BoxCollider>().enabled = false;
            }
        }
    }

}