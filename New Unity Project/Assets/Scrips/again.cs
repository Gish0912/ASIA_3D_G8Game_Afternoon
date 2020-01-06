using UnityEngine.SceneManagement;
using UnityEngine;

public class again : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.name == "小明" )
        {
            SceneManager.LoadScene("123");
        }
    }
}
