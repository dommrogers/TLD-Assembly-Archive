using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class LoadingAnimation : MonoBehaviour
{
	private UISpriteAnimation m_SpriteAnimation;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponentInChildren")]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UISpriteAnimation), Member = "RebuildSpriteList")]
	[Calls(Type = typeof(UISpriteAnimation), Member = "ResetToBeginning")]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public LoadingAnimation()
	{
	}
}
