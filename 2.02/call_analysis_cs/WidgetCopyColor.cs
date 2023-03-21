using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class WidgetCopyColor : MonoBehaviour
{
	public UIWidget m_WidgetToCopy;

	private UIWidget m_Widget;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	private void Awake()
	{
	}

	[Calls(Type = typeof(WidgetCopyColor), Member = "Update")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Color), Member = "op_Equality")]
	[CalledBy(Type = typeof(WidgetCopyColor), Member = "OnEnable")]
	private void Update()
	{
	}

	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public WidgetCopyColor()
	{
	}
}
