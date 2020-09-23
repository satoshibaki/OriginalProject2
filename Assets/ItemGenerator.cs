using UnityEngine;
using System.Collections;

public class ItemGenerator : MonoBehaviour
{
    //carPrefabを入れる
    public GameObject BombBallPrefab;
    //coinPrefabを入れる
    public GameObject EyeBallPrefab;
    //cornPrefabを入れる
    public GameObject SpikeBallPrefab;
    //スタート地点
    private int startPos = 80;
    //ゴール地点
    private int goalPos = 500;
    //敵を出すx方向の範囲
    private float posRange = 46f;

    // Use this for initialization
    void Start()
    {
        //一定の距離ごとにアイテムを生成
        for (int i = startPos; i < goalPos; i += 10)
        {
            //どのアイテムを出すのかをランダムに設定
            int num = Random.Range(1, 11);
            if (num <= 2)
            {
                //爆弾をx軸方向に一直線に生成
                for (float j = -1; j <= 1; j += 0.1f)
                {
                    GameObject BombBall = Instantiate(BombBallPrefab);
                    BombBall.transform.position = new Vector3(4 * j, 30, i);
                }
            }
            else
            {

                //レーンごとにアイテムを生成
                for (int j = -1; j <= 1; j++)
                {
                    //アイテムの種類を決める
                    int item = Random.Range(1, 11);
                    //アイテムを置くZ座標のオフセットをランダムに設定
                    int offsetZ = Random.Range(-5, 6);
                    //目玉おやじ配置:30%とげとげボール配置:10%何もなし
                    if (1 <= item && item <= 6)
                    {
                        //目玉おやじを生成
                        GameObject EyeBall = Instantiate(EyeBallPrefab);
                        EyeBall.transform.position = new Vector3(posRange * j, 30, i + offsetZ);
                    }
                    else if (7 <= item && item <= 9)
                    {
                        //とげとげボールを生成
                        GameObject SpikeBall = Instantiate(SpikeBallPrefab);
                        SpikeBall.transform.position = new Vector3(posRange * j, 30, i + offsetZ);
                    }
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}