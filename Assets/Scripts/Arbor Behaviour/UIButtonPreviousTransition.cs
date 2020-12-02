using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Arbor;
using Arbor.StateMachine.StateBehaviours;
using UnityEngine.UI;

[AddComponentMenu("")]
public class UIButtonPreviousTransition : StateBehaviour {

	[SerializeField]
	[SlotType(typeof(Button))]
	private FlexibleComponent _Button = new FlexibleComponent(FlexibleHierarchyType.Self);

	public Button cachedButton
	{
		get
		{
			return _Button.value as Button;
		}
	}

	void Start () {
	
	}

	// Use this for awake state
	public override void OnStateAwake() {
	}

	// Use this for enter state
	public override void OnStateBegin() {
		Button button = cachedButton;
		if (button != null)
		{
			button.onClick.AddListener(OnClick);
		}
	}

	// Use this for exit state
	public override void OnStateEnd() {
		Button button = cachedButton;
		if (button != null)
		{
			button.onClick.RemoveListener(OnClick);
		}
	}
	
	public void OnClick()
	{
		Transition(prevTransitionState);
	}
	
}
