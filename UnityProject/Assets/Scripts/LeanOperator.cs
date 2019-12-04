using UnityEngine;

public class LeanOperator : MonoBehaviour
{
    public int A = 10, B = 3;
    public int C = 1;
    public int D = 1, E = 1;
    public int F = 100;
    
    public float  G = 1.5f, H = 99.9f;

    public float Hp = 50;

    public bool Key;
    public int enemy;

    private void Update()
    {
        print("死亡:" + (Hp <= 0));
        print("過關:" + (Key || enemy >= 5));
    }

    private void Start()
    {

        print(A + B);
        print(A - B);
        print(A * B);
        print(A / B);
        print(A % B);

        //指派右邊先運算再給左邊
        C = 99 + 1;
        print(C);

        C = C + 1;

        print(D++);
        print(++E);

        print(F += 100);

        print(G > H);
        print(G < H);
        print(G >= H);
        print(G <= H);
        print(G == H);
        print(G != H);

        print(true && true);
        print(true && false);
        print(false && true);
        print(false && false);

        print(true || true);
        print(true || false);
        print(false || true);
        print(false || false);

        if (true)
        {
            print("測試");
        }
    }
}
