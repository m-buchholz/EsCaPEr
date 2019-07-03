using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitExplosion : StateMachineBehaviour
{
    public Sprite pseLeftFull, pseRightFull;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    //override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    //override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}

    // OnStateMove is called right after Animator.OnAnimatorMove()
    //override public void OnStateMove(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that processes and affects root motion
    //}

    // OnStateIK is called right after Animator.OnAnimatorIK()
    //override public void OnStateIK(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    // Implement code that sets up animation IK (inverse kinematics)
    //}

    public override void OnStateEnter(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex)
    {
        GameObject.Find("ExplosionLeft").GetComponentInChildren<Animator>().SetBool("play", true);
        GameObject.Find("ExplosionRight").GetComponentInChildren<Animator>().SetBool("play", true);
    }

    public override void OnStateExit(Animator animator, AnimatorStateInfo animatorStateInfo, int layerIndex)
    {
        GameObject.Find("PSE Left Button").GetComponent<Image>().sprite = pseLeftFull;
        GameObject.Find("PSE Right Button").GetComponent<Image>().sprite = pseRightFull;
        if(GameObject.Find("ExitSound1")) GameObject.Find("ExitSound1").GetComponent<AudioSource>().enabled = true;
        if (GameObject.Find("ExitSound2")) GameObject.Find("ExitSound2").GetComponent<AudioSource>().enabled = true;
        PlayerPrefs.SetInt("Exit", 1);
    }
}
