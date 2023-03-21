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
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
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
	[Calls(Type = typeof(Task), Member = "StartCoroutine")]
	[Calls(Type = typeof(ConditionTask), Member = "Flip")]
	[Calls(Type = typeof(Collision2D), Member = "get_contacts")]
	[CallsUnknownMethods(Count = 15)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Collision2D), Member = "get_gameObject")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Collision2D), Member = "get_gameObject")]
	public void OnCollisionEnter2D(Collision2D info)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Collision2D), Member = "get_gameObject")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Collision2D), Member = "get_gameObject")]
	[Calls(Type = typeof(ConditionTask), Member = "Flip")]
	[Calls(Type = typeof(Task), Member = "StartCoroutine")]
	[CallsUnknownMethods(Count = 5)]
	public void OnCollisionExit2D(Collision2D info)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public CheckCollision2D()
	{
		((ConditionTask<>)(object)this)._002Ector();
	}
}
