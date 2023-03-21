using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_IsCameraFadeActive : ConditionTask
{
	public enum FadeOptions
	{
		Any,
		In,
		Out
	}

	public FadeOptions FadeType;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enum), Member = "ToString")]
		[Calls(Type = typeof(string), Member = "Concat")]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(CameraFade), Member = "IsFadingOut")]
	[Calls(Type = typeof(CameraFade), Member = "IsFadingIn")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraFade), Member = "IsFadingIn")]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Condition_IsCameraFadeActive()
	{
	}
}
