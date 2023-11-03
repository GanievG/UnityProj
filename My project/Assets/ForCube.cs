using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine; //базовая библиотека для работы с Unity
using UnityEngine.UI;

public class ForCube : MonoBehaviour
{
    public float Speed = 10f;
    /*public int a;

    private int b;*/ 
    public int c;

    public GameObject sphere;
    // Start is called before the first frame update
    public Text x;

    public GameObject cam;
    public GameObject bcam;

    void Start()
    {
    
    }

    // Update is called once per frame
    void FixedUpdate()//лучше, чем Update потому что работает медлен 
    {
        if (Input.GetKey(KeyCode.W)) 
        {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.down * 5 * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * 5 * Speed * Time.deltaTime);
        }

        if (c <= 0)
        {
            this.gameObject.SetActive(false);
           /* cam.SetActive(true);
            bcam.SetActive(false);*/
            x.text = "Game Over";
        }
        else x.text = c.ToString();
    }
    
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("CS");
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("CEN");
        this.gameObject.GetComponent<Renderer>().material.color = Color.red;
        c--;
    }
        
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("CET");
        this.gameObject.GetComponent<Renderer>().material.color = Color.white;

    }

    private void OnTriggerStay(Collider other)
    {
        Debug.Log("TS");
        
    }
        
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TE");
        
    }
        

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("TX");
        
    }
    public void heal() 
    {
        c = 5;
    }

}
