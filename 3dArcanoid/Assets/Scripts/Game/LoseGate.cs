using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseGate : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("EndGame");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    
}
