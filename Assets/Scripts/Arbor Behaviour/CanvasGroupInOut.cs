using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Arbor;

[AddBehaviourMenu("User/Canvas Group InOut")]
public class CanvasGroupInOut : StateBehaviour
{
	[SerializeField] private CanvasGroup canvasGroupToFadeInOut;
	void Awake ()
	{
		canvasGroupToFadeInOut.alpha = 0;
		canvasGroupToFadeInOut.interactable = false;
		canvasGroupToFadeInOut.blocksRaycasts = false;
	}

	// Use this for awake state
	public override void OnStateAwake() {
	}

	// Use this for enter state
	public override void OnStateBegin() {
		canvasGroupToFadeInOut.alpha = 1;
		canvasGroupToFadeInOut.interactable = true;
		canvasGroupToFadeInOut.blocksRaycasts = true;
	}

	// Use this for exit state
	public override void OnStateEnd() {
		canvasGroupToFadeInOut.alpha = 0;
		canvasGroupToFadeInOut.interactable = false;
		canvasGroupToFadeInOut.blocksRaycasts = false;
	}
	
	// OnStateUpdate is called once per frame
	public override void OnStateUpdate() {
	}

	// OnStateLateUpdate is called once per frame, after Update has finished.
	public override void OnStateLateUpdate() {
	}
}
