using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LoadingAnimation : MonoBehaviour
{
	private UISpriteAnimation m_SpriteAnimation;

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(UISpriteAnimation), Member = "get_frames")]
	[Calls(Type = typeof(UISpriteAnimation), Member = "RebuildSpriteList")]
	[Calls(Type = typeof(UISpriteAnimation), Member = "ResetToBeginning")]
	[CallsUnknownMethods(Count = 3)]
	private void OnEnable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public LoadingAnimation()
	{
	}
}
