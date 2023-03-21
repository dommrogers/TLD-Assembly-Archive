using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

public class IsInFront : ConditionTask<Transform>
{
	public BBParameter<GameObject> checkTarget;

	public BBParameter<float> viewAngle;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(Vector3), Member = "Angle")]
	[CallsUnknownMethods(Count = 10)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Vector3), Member = "get_one")]
	[Calls(Type = typeof(Vector3), Member = "get_zero")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	public override void OnDrawGizmosSelected()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public IsInFront()
	{
		((ConditionTask<>)(object)this)._002Ector();
	}
}
