using UnityEngine;

public class ResizeBall : MonoBehaviour
{
    public Vector3 sizeUp = new Vector3(3f, 3f, 3f);
    public Vector3 sizeDown = new Vector3(1f, 1f, 1f);
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("q")){
            Grow();
        }

        if (Input.GetKeyDown("e")){
            Shrink();
        }
    }

    public void Grow()
    {
        transform.localScale = sizeUp;
        rb.mass = 4;
    }

    public void Shrink()
    {
        transform.localScale = sizeDown;
        rb.mass = 0.2f;
    }


}
