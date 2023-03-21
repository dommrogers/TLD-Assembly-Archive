using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

public class CheckMouseClick : ConditionTask<Collider>
{
	public MouseClickEvent checkType;

	protected override string info
	{
		[Calls(Type = typeof(Enum), Member = "ToString")]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	public void OnMouseDown()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	public void OnMouseUp()
	{
	}

	[CallerCount(Count = 0)]
	public CheckMouseClick()
	{
		((ConditionTask<>)(object)this)._002Ector();
	}
}
