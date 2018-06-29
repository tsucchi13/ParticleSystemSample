using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

	public float speed = 5;
	public float jumpPower = 5;
	int jumpCount;
	float timer = 5.0f;

	bool jumpRightDirection = true;

	float touchtime;
	float pushtime;

	Rigidbody r;//取ってきたRigidbodyを入れておく変数

	// Use this for initialization
	void Start () {
		r = this.gameObject.GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void Update () {

		Debug.Log (pushtime - touchtime);

//		if (Input.GetMouseButtonDown (0) == true && jumpCount < 1) {
//			Debug.Log ("push!");
//			pushtime = Time.time;
//		}
//
//		if (pushtime - touchtime < 0.1f) {
//			//エクセレント
//			if (jumpRightDirection == true) {
//				r.velocity = new Vector3 (speed * 2, jumpPower * 5, 0);
//				jumpCount += 1;
//
//			} else {
//				r.velocity = new Vector3 (-speed * 2, jumpPower * 5, 0);
//				jumpCount += 1;
//
//			}
//
//
//		} else if (0.1f < pushtime - touchtime < 0.3f) {
//			//グレイト
//
//		} else {
//			//グッド！
//
//
//		}
			


	}

	void OnCollisionEnter(Collision col){
		if(col.gameObject.tag == "Wall2"){

			touchtime = Time.time;
			jumpRightDirection = true;
			r.velocity = new Vector3 (-speed*2, jumpPower*2, 0);
			jumpCount = 0;

		}
		if(col.gameObject.tag == "Wall"){

			touchtime = Time.time;
			jumpRightDirection = false;
			r.velocity = new Vector3 (-speed*2, jumpPower*2, 0);
			jumpCount = 0;
		}

	}


	//			if(jumpRightDirection == true)//trueの時
	//			{
	//				timer += Time.deltaTime;
	//				Debug.Log("yeahhhh");
	//				if (timer < 1.0f) {
	//					if (Input.GetMouseButtonDown (0)) {
	//						r.velocity = new Vector3 (speed*2, jumpPower*5, 0);
	//						jumpCount += 1;
	//						timer = 0;
	//
	//					}
	//				}
	//				r.velocity = new Vector3 (speed*2, jumpPower*2, 0);
	//				jumpCount += 1;
	//			}
	//			else//falseの時
	//			{
	//				r.velocity = new Vector3 (-speed*2, jumpPower*2, 0);
	//				jumpCount += 1;
	//			}
	//
	//
	//			r.velocity = new Vector3 (0, 0, 0);
	//			jumpCount = 0;
	//			jumpRightDirection = false;



}