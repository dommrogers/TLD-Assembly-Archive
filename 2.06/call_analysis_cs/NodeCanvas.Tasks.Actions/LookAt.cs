using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class LookAt : ActionTask<Transform>
{
	public BBParameter<GameObject> lookTarget;

	public bool repeat;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "Concat")]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LookAt), Member = "DoLook")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LookAt), Member = "DoLook")]
	[DeduplicatedMethod]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Transform), Member = "LookAt")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CalledBy(Type = typeof(LookAt), Member = "OnExecute")]
	[CalledBy(Type = typeof(LookAt), Member = "OnUpdate")]
	[CallsUnknownMethods(Count = 5)]
	private void DoLook()
	{
	}

	[CallerCount(Count = 0)]
	public LookAt()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
