using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class WidgetCopyColor : MonoBehaviour
{
	public UIWidget m_WidgetToCopy;

	private UIWidget m_Widget;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(WidgetCopyColor), Member = "Update")]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CalledBy(Type = typeof(WidgetCopyColor), Member = "OnEnable")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public WidgetCopyColor()
	{
	}
}
