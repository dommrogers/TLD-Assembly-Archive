using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AnimatedAlpha : MonoBehaviour
{
	public float alpha;

	private UIWidget mWidget;

	private UIPanel mPanel;

	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	private void LateUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public AnimatedAlpha()
	{
	}
}
