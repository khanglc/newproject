using UnityEngine;

public class move : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {

            anim.SetBool("isrun", true);
            anim.SetBool("isidle", false);
        }
    }
}
