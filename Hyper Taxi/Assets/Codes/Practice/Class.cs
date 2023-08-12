using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Class : MonoBehaviour
{
    public enum CustomerColor { red, green, blue, orange, white}
    [SerializeField] List<Customer> customers = new();
    private void Start()
    {
        Customer customer = new();
    }
}
