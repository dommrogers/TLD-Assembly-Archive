using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LoadingAnimation : MonoBehaviour
{
	private UISpriteAnimation m_SpriteAnimation;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(UISpriteAnimation), Member = "ResetToBeginning")]
	[Calls(Type = typeof(UISpriteAnimation), Member = "RebuildSpriteList")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	private void OnEnable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public LoadingAnimation()
	{
	}
}
