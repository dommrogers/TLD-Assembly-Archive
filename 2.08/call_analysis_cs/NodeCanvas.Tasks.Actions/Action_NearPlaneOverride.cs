using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_NearPlaneOverride : ActionTask
{
	public BBParameter<float> m_NearPlane;

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	protected override void OnExecute()
	{
	}

	[Calls(Type = typeof(vp_FPSCamera), Member = "StopNearPlaneOverride")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected override void OnStop()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	private void MaybeOverrideNearPlane()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(vp_FPSCamera), Member = "StopNearPlaneOverride")]
	private void MaybeResetNearPlane()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public Action_NearPlaneOverride()
	{
	}
}
