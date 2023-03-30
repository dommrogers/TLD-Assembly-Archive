using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AnimatedAlpha : MonoBehaviour
{
	public float alpha;

	private UIWidget mWidget;

	private UIPanel mPanel;

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void LateUpdate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public AnimatedAlpha()
	{
	}
}
