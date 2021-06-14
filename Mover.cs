using UnityEngine;

public class Mover : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.position += new Vector3(0f, 0f, 3f) * Time.deltaTime;
               

        PlayerMovement();

    }

    private void PlayerMovement()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * 10;
        float yValue = Input.GetAxis("Jump") * Time.deltaTime * 5;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * 10;

        transform.Translate(xValue, yValue, zValue);
    }
}
/*
 ilk yazdığın kod da olur.
translate kullanmaya özen göster ama.
 
 */