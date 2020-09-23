using UnityEngine;
using System.Collections;

public class MyCameraController : MonoBehaviour
{
    //Unityちゃんのオブジェクト
    private GameObject unitychan;
    //Unityちゃんとカメラの距離(Z)
    private float differenceZ;
    //Unityちゃんとカメラの距離(X)
    private float differenceX;



    // Use this for initialization
    void Start()
    {
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
        //Unityちゃんとカメラの位置（z座標）の差を求める
        this.differenceZ = unitychan.transform.position.z - this.transform.position.z;
        //Unityちゃんとカメラの位置（X座標）の差を求める
        this.differenceX = unitychan.transform.position.x - this.transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        //Unityちゃんの位置に合わせてカメラの位置を移動
        this.transform.position = new Vector3(this.unitychan.transform.position.x - differenceX, this.transform.position.y, this.unitychan.transform.position.z - differenceZ);
    }
}