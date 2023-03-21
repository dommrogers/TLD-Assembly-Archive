using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class AuroraObjectActivator : MonoBehaviour
{
	public float m_AuroraThreshold;

	private bool m_ChildrenDisabled;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(AuroraObjectActivator), Member = "DisableChildren")]
	[Calls(Type = typeof(AuroraObjectActivator), Member = "EnableChildren")]
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
	public AuroraObjectActivator()
	{
	}
}
