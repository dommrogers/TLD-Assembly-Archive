using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AnimationStartOnRandomFrame : MonoBehaviour
{
	public string m_StateName;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public AnimationStartOnRandomFrame()
	{
	}
}
