using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class WidgetCopyColor : MonoBehaviour
{
	public UIWidget m_WidgetToCopy;

	private UIWidget m_Widget;

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(WidgetCopyColor), Member = "Update")]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CalledBy(Type = typeof(WidgetCopyColor), Member = "OnEnable")]
	[CallsUnknownMethods(Count = 5)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public WidgetCopyColor()
	{
	}
}
