using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    //Start VAR
    Animator animator;
    int isWalkingHash;
    int isRunningHash;
    int goRightHash;
    int goLeftHash;
    // Update VAR
    bool isWalking;
    bool isRunning;
    bool goRight;
    bool goLeft;
    bool upPressed;
    bool runPressed;
    bool rightPressed;
    bool leftPressed;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
        goRightHash = Animator.StringToHash("goRight");
        goLeftHash = Animator.StringToHash("goLeft");
    }

    // Update is called once per frame
    void Update()
    {
         isWalking = animator.GetBool(isWalkingHash);
         isRunning = animator.GetBool(isRunningHash);
         goRight = animator.GetBool(isRunningHash);
         goLeft = animator.GetBool(isRunningHash);
         upPressed = Input.GetKey("up");
         runPressed = Input.GetKey("left shift");
         rightPressed = Input.GetKey("right");
         leftPressed = Input.GetKey("left");

        //WALK
        if (!isWalking && upPressed  )//Commence a marcher
        {
            animator.SetBool(isWalkingHash, true);
        }
        if (isWalking && !upPressed )//Arrete marche
        {
            animator.SetBool(isWalkingHash, false);

         
        }
        //WALK TURN
        if (isWalking && rightPressed && !goRight && !goLeft && !leftPressed)//Commence a tourner a droite
        {
            animator.SetBool(goRightHash, true);
        }
        if ((!isWalking || !rightPressed || leftPressed) && goRight)//Arrete a tourner a droite
        { 
            animator.SetBool(goRightHash, false);
        }
        if (isWalking && !rightPressed && !goRight && !goLeft && leftPressed)//Commence a tourner a droite
        {
            animator.SetBool(goRightHash, true);
        }
        if ((!isWalking || rightPressed || !leftPressed) && goLeft)//Arrete a tourner a droite
        {
            animator.SetBool(goLeftHash, false);
        }





        //RUN
        if (!isRunning && (upPressed && runPressed && !rightPressed && !leftPressed))
        {
            animator.SetBool(isRunningHash, true);
        }
        if (isRunning && (!upPressed || !runPressed && !rightPressed && !leftPressed))
        {
            animator.SetBool(isRunningHash, false);
        }
    }
}
