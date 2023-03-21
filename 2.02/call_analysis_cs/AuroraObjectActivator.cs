using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AuroraObjectActivator : MonoBehaviour
{
	public float m_AuroraThreshold;

	private bool m_ChildrenDisabled;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraManager), Member = "AuroraIsActive")]
	[Calls(Type = typeof(AuroraObjectActivator), Member = "EnableChildren")]
	[Calls(Type = typeof(AuroraObjectActivator), Member = "DisableChildren")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private void Start()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(AuroraObjectActivator), Member = "Start")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	private void EnableChildren()
	{
	}

	[CalledBy(Type = typeof(AuroraObjectActivator), Member = "Start")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 7)]
	private void DisableChildren()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public AuroraObjectActivator()
	{
	}
}
