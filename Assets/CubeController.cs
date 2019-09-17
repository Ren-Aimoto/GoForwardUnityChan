using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {
	//キューブの移動速度
	private float speed = -0.2f;

	//消滅位置
	private float deadline = -10;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//cubeを移動させる
		transform.Translate(this.speed,0,0);

		//画面外に出たら破棄する
		if (transform.position.x < this.deadline) {
			Destroy (gameObject);
		}
			

	}
	void OnCollisionEnter2D(Collision2D other){
		//ブロックのオーディオソース取得
		AudioClip block = gameObject.GetComponent<AudioSource>().clip;
		if (other.gameObject.name != "UnityChan2D") {
			gameObject.GetComponent<AudioSource> ().PlayOneShot (block);
		}
	}
}
