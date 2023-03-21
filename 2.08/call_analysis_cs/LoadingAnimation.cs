using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LoadingAnimation : MonoBehaviour
{
	private UISpriteAnimation m_SpriteAnimation;

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(UISpriteAnimation), Member = "ResetToBeginning")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UISpriteAnimation), Member = "RebuildSpriteList")]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public LoadingAnimation()
	{
	}
}
