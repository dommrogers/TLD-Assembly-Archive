using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

public class CheckCollision2D : ConditionTask<Collider2D>
{
	public CollisionTypes checkType;

	public bool specifiedTagOnly;

	public string objectTag;

	public BBParameter<GameObject> saveGameObjectAs;

	public BBParameter<Vector3> saveContactPoint;

	public BBParameter<Vector3> saveContactNormal;

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
		return default(bool);
	}

	[Calls(Type = typeof(Collision2D), Member = "get_contacts")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	[Calls(Type = typeof(Collision2D), Member = "get_contacts")]
	[Calls(Type = typeof(Collision2D), Member = "get_gameObject")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Collision2D), Member = "get_gameObject")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public void OnCollisionEnter2D(Collision2D info)
	{
	}

	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	[Calls(Type = typeof(Collision2D), Member = "get_gameObject")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Collision2D), Member = "get_gameObject")]
	public void OnCollisionExit2D(Collision2D info)
	{
	}

	[CallerCount(Count = 0)]
	public CheckCollision2D()
	{
		((ConditionTask<>)(object)this)._002Ector();
	}
}
