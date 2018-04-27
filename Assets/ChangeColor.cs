using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour {
    //define the car change shader/material here
    public Material[] _carBodyColorMat;
    Material _currentMat;
    Renderer _carMeshRenderer;
	// Use this for initialization
	void Start () {
        _carMeshRenderer = this.GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ChangeBlue()
    {
        _carMeshRenderer.material = _carBodyColorMat[0];
        _currentMat = _carMeshRenderer.material;
    }
    public void ChangeRed()
    {
        _carMeshRenderer.material = _carBodyColorMat[1];
        _currentMat = _carMeshRenderer.material;
    }
    public void ChangeGreen()
    {
        _carMeshRenderer.material = _carBodyColorMat[2];
        _currentMat = _carMeshRenderer.material;
    }
}
