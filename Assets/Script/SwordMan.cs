using UnityEngine;

public class SwordMan : MonoBehaviour
{
    [SerializeField] private Animator swordManAnimator;
    [SerializeField] private Animator bgAnimator;

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            swordManAnimator.SetTrigger("ShoutTrig");
            bgAnimator.SetTrigger("StartFlash");
        }
        else if (Input.GetKeyUp(KeyCode.K))
        {
            
            swordManAnimator.SetTrigger("EndShout");
            bgAnimator.SetTrigger("EndFlash");
        }
    }
}
