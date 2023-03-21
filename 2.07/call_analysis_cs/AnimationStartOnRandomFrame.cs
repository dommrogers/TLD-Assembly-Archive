using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AnimationStartOnRandomFrame : MonoBehaviour
{
	public string m_StateName;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Animator), Member = "Play")]
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
