
using UnityEngine;

public class player : MonoBehaviour {
    public Animator Chicken;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		 if (Input.GetKeyDown(KeyCode.E))
        {
            Chicken.SetTrigger("吃飯觸發器");
        }
        if (Input.GetKey(KeyCode.R))
        {
            Chicken.SetBool("跑步開關",true);
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            Chicken.SetBool("跑步開關",false);
        }
    }
}
