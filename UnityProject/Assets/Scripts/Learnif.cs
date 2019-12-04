using UnityEngine;

public class Learnif : MonoBehaviour
{
    public bool openDoor;

    public int score = 100;

    public int 連擊次數 = 0;
    private void Start()
    {
        if (true)
        {
            print("測試");
        }
    }
    private void Update()
    {
        if (openDoor)
        {
            print("開門");
        }
        else
        {
            print("關門");
        }


        if (score >= 60) 
        {
            print("及格");
        }
        else if (score >= 50)
        {
            print("可以補考唷~");
        }
        else if (score >= 40)
        {
            print("跪拜及得補考ˊˇˋ");
        }
        else
        {
            print("被當了喔ㄅㄅ~");
        }


        if (連擊次數 >= 150)
        {
            print("攻擊10倍");
        }
        else if (連擊次數 >= 100)
        {
            print("攻擊5倍");
        }
        else if(連擊次數 >= 50)
        {
            print("攻擊2倍");
        }
    }
 }
