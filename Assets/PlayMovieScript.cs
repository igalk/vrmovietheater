using UnityEngine;
using System.Collections;

public class PlayMovieScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	    MovieTexture tex = (MovieTexture)renderer.material.mainTexture;
        tex.Play();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
