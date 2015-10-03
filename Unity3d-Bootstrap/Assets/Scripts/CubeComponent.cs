using UnityEngine;
using Bootstrap.Interfaces.Services;
using Adic;
using System;

public class CubeComponent : MonoBehaviour {
    [Inject]
    ISampleService MyService;

    void Start()
    {
        this.Inject();
        this.MyService.SomethingHappened += this.OnEventHappened;
    }

    public void Update()
    {
        MyService.DoSomething();
    }

    private void OnEventHappened(object sender, EventArgs e)
    {
        Debug.Log("Something happened - coming from event ");
    }
}
