using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	public GameObject from;
	public GameObject to;
	public float SPEED = 5f;

	// Use this for initialization
	void Start () {
		// fromの場所に移動
		transform.position = from.transform.position;
		// 移動方向を計算
		//// 移動いたい方向
		Vector3 dir = to.transform.position-from.transform.position;
		//// 単位ベクトル=長さ1にする
		dir = dir.normalized;
		GetComponent<Rigidbody> ().velocity = dir * SPEED;
		// Unityに切り替えて、Cubeをfrom、Cube(1)をtoにドラッグ＆ドロップして実行
		// SphereのSphereColliderのIs Triggerにチェック
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
