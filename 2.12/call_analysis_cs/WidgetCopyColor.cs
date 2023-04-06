using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class WidgetCopyColor : MonoBehaviour
{
	public UIWidget m_WidgetToCopy;

	private UIWidget m_Widget;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(WidgetCopyColor), Member = "Update")]
	private void OnEnable()
	{
	}

	[CalledBy(Type = typeof(WidgetCopyColor), Member = "OnEnable")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 5)]
	private void Update()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public WidgetCopyColor()
	{
	}
}
