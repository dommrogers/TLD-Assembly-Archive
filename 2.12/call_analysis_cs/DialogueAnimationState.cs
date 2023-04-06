using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DialogueAnimationState : ScriptableObject
{
	public string m_AnimationStateKey;

	public string m_CameraFramingIn;

	public string m_CameraFramingOut;

	public string m_ExitDialoguePoint;

	public bool m_FadedOutOnLoad;

	public bool m_FadedOutOnExit;

	public bool m_CanApplyCameraMotionToJoint;

	public bool m_ResetAimingMode;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ScriptableObject), Member = ".ctor")]
	public DialogueAnimationState()
	{
	}
}
