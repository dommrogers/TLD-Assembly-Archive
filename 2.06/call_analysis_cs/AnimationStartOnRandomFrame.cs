using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AnimationStartOnRandomFrame : MonoBehaviour
{
	public string m_StateName;

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public AnimationStartOnRandomFrame()
	{
	}
}
