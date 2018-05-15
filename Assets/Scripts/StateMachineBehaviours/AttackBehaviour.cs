using UnityEngine;

[SharedBetweenAnimators]
public class AttackBehaviour : StateMachineBehaviour
{
	public override void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
	{
		Debug.Log("OnStateEnter");
	}
}