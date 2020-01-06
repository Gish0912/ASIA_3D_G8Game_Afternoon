using UnityEngine;

public class player : MonoBehaviour
{
    public Transform tra;
    public Rigidbody rig;
    public Animator ani;
    public float speed;
    public float turn;

    private void Update()
    {
        walk();
        run();
    }

    private void walk()
    {
        if (ani.GetCurrentAnimatorStateInfo(0).IsName("pickup")) return;

        float v = Input.GetAxis("Vertical");
        rig.AddForce(tra.forward * speed * v * Time.deltaTime);
        float h = Input.GetAxis("Horizontal");
        tra.Rotate(0, h * turn * Time.deltaTime, 0);

        ani.SetBool("走路", v != 0);
    }
    private void run()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            ani.SetBool("跑步", true);
            ani.SetBool("走路", false);
        }
        else
        {
            ani.SetBool("跑步", false);
        }
    }
}
