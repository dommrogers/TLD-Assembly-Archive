using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FramerateMonitor : UserReportingMonitor
{
	private float duration;

	public float MaximumDurationInSeconds;

	public float MinimumFramerate;

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public FramerateMonitor()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UserReportingMonitor), Member = "Trigger")]
	[CallsUnknownMethods(Count = 1)]
	private void Update()
	{
	}
}
