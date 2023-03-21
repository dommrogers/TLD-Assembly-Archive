using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class FramerateMonitor : UserReportingMonitor
{
	private float duration;

	public float MaximumDurationInSeconds;

	public float MinimumFramerate;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public FramerateMonitor()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UserReportingMonitor), Member = "Trigger")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void Update()
	{
	}
}
