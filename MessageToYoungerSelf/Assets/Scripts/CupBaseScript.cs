using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent(typeof(MeshRenderer))]
public class CupBaseScript : MonoBehaviour {
	private MeshRenderer _meshRenderer;
	[SerializeField]private Material _material;
	// Use this for initialization
	void Start () {
		_meshRenderer = GetComponent<MeshRenderer>();
		Material matCopy = new Material(_material);
		_meshRenderer.material = matCopy;
	}

	private void OnEnable(){
		_meshRenderer = GetComponent<MeshRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
