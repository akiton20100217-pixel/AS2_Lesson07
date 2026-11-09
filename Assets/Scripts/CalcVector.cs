using UnityEngine;

public class CalcVector : MonoBehaviour
{
    [Header("Field")]
    public Vector3 A;
    public Vector3 B;
    public Vector3 C;

    void Update()
    {
        //C = Additive(A, B);
        //C = SubStruct(A, B);
        //C = ScalerMultiply(A, 2);

        float dot = Multoply(A, B);
        C = CrossMultoply(A, B).normalized;
    }

    //べクトル足し算
    private Vector3 Additive(Vector3 a, Vector3 b)
    {
        //可視化
        //Debug.DrawaRay((Vector3)開始地点, (Vector3)方向, (Color)描画色, (float)描画時間, (bool)深度設定)
        Debug.DrawRay(Vector3.zero, a, Color.red, 0, false);
        Debug.DrawRay(Vector3.zero, b, Color.blue, 0, false);

        Debug.DrawRay(Vector3.zero, a + b, Color.green, 0, false);

        //return new Vector3(a x + b x, a y + b y, a z + b z)
        return a + b;
    }

    //ベクトル引き算
    private Vector3 SubStruct(Vector3 a, Vector3 b)
    {
        Debug.DrawRay(Vector3.zero, a, Color.red, 0, false);
        Debug.DrawRay(Vector3.zero, b, Color.blue, 0, false);
        Debug.DrawRay(Vector3.zero, a - b, Color.green, 0, false);

        return a - b;
    }

    //ベクトル*整数の掛け算
    private Vector3 ScalerMultiply(Vector3 a, float b)
    {
        Debug.DrawRay(Vector3.zero, a * b, Color.blue, 0, false);

        Debug.DrawRay(Vector3.zero, a, Color.red, 0, false);

        return a * b;
    }

    //ベクトル同士の掛け算
    private float Multoply(Vector3 a, Vector3 b)
    {
        //float c = (a.x * b.x) + (a.y * b.y) + (a.z * b.z); //内積
        float c = Vector3.Dot(a, b);
        Debug.Log($"{a}と{b}の内積 = + {c}");

        return c;
    }

    private Vector3 CrossMultoply(Vector3 a, Vector3 b)
    {
        Vector3 c = Vector3.zero;

        /*
        外積
        c.x = (a.y * b.z) - (a.z * b.y);
        c.y = (a.x * b.z) - (a.x * b.z);
        c.z = (a.x * b.y) - (a.y * b.x);
        */

        c = Vector3.Cross(a, b);

        Debug.DrawRay(Vector3.zero, a, Color.red, 0, false);
        Debug.DrawRay(Vector3.zero, b, Color.blue, 0, false);
        Debug.DrawRay(Vector3.zero, c, Color.green, 0, false);

        return c.normalized;
    }
}
