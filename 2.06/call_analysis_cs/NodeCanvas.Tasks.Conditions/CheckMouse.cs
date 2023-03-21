using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

public class CheckMouse : ConditionTask<Collider>
{
	public MouseInteractionTypes checkType;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enum), Member = "ToString")]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	public void OnMouseEnter()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	public void OnMouseExit()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	public void OnMouseOver()
	{
	}

	[CallerCount(Count = 0)]
	public CheckMouse()
	{
		((ConditionTask<>)(object)this)._002Ector();
	}
}
