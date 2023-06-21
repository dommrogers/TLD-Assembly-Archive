using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

public class CheckTrigger2D : ConditionTask<Collider2D>
{
	public TriggerTypes CheckType;

	public bool specifiedTagOnly;

	public string objectTag;

	public BBParameter<GameObject> saveGameObjectAs;

	private bool stay;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Enum), Member = "ToString")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "Concat")]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected override bool OnCheck()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(BBParameter<>), Member = "set_value")]
	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void OnTriggerEnter2D(Collider2D other)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(BBParameter<>), Member = "set_value")]
	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	public void OnTriggerExit2D(Collider2D other)
	{
	}

	[CallerCount(Count = 0)]
	public CheckTrigger2D()
	{
		((ConditionTask<>)(object)this)._002Ector();
	}
}
