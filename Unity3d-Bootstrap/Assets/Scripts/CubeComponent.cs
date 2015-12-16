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
        this.MyService.SomethingHappened += this.OnSameEventHappened;
	}

    public void Update()
    {
        MyService.DoSomething();
    }

    private void OnEventHappened(object sender, EventArgs e)
    {
        Debug.Log("Something happened - coming from event ");
    }

	private void OnSameEventHappened(object sender, EventArgs e)
	{
		Debug.Log("Something happened from second event");
	}
}
