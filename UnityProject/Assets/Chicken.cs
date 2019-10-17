using UnityEngine;

public class Chicken : MonoBehaviour
{
    public Animator chicken;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            chicken.SetTrigger("吃飯觸發器");
        }

        chicken.SetBool("跑步開關", Input.GetKey(KeyCode.R));
    }
}
