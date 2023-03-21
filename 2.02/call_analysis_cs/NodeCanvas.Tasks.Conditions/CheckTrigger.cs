using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions;

public class CheckTrigger : ConditionTask<Collider>
{
	public TriggerTypes checkType;

	public bool specifiedTagOnly;

	public string objectTag;

	public BBParameter<GameObject> saveGameObjectAs;

	private bool stay;

	protected override string info
	{
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[Calls(Type = typeof(Task), Member = "StartCoroutine")]
	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(ConditionTask), Member = "Flip")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	public void OnTriggerEnter(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(ConditionTask), Member = "Flip")]
	[Calls(Type = typeof(Task), Member = "StartCoroutine")]
	[CallsUnknownMethods(Count = 7)]
	public void OnTriggerExit(Collider other)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public CheckTrigger()
	{
		((ConditionTask<>)(object)this)._002Ector();
	}
}
