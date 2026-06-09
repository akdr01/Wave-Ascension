using UnityEngine;

public class pushthisbutton : MonoBehaviour
{

    [SerializeField]
    private AudioSource audioSource;
    [SerializeField]
    private AudioClip ohmygod;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PushThisButton() 
    {

        Debug.Log("Omg, You pushed me!");
    }

    public void Audiojaeseng()
    {

        GetComponent<AudioSource>().PlayOneShot(ohmygod);
    }
}
