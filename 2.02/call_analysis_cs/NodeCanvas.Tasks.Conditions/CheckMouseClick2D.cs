using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

public class CheckMouseClick2D : ConditionTask<Collider2D>
{
	public MouseClickEvent checkType;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
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

	[Calls(Type = typeof(Task), Member = "StartCoroutine")]
	[Calls(Type = typeof(ConditionTask), Member = "Flip")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void OnMouseDown()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConditionTask), Member = "Flip")]
	[Calls(Type = typeof(Task), Member = "StartCoroutine")]
	public void OnMouseUp()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public CheckMouseClick2D()
	{
		((ConditionTask<>)(object)this)._002Ector();
	}
}
