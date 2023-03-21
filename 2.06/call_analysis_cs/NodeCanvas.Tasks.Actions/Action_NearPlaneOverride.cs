using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class Action_NearPlaneOverride : ActionTask
{
	public BBParameter<float> m_NearPlane;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 2)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(vp_FPSCamera), Member = "StopNearPlaneOverride")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnStop()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private void MaybeOverrideNearPlane()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "StopNearPlaneOverride")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private void MaybeResetNearPlane()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Action_NearPlaneOverride()
	{
	}
}
