using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AnimationStartOnRandomFrame : MonoBehaviour
{
	public string m_StateName;

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Animator), Member = "Play")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	private void OnEnable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public AnimationStartOnRandomFrame()
	{
	}
}
