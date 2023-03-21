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
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(LookAt), Member = "DoLook")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(LookAt), Member = "DoLook")]
	protected override void OnUpdate()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(LookAt), Member = "OnUpdate")]
	[CalledBy(Type = typeof(LookAt), Member = "OnExecute")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(Transform), Member = "LookAt")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	private void DoLook()
	{
	}

	[CallerCount(Count = 0)]
	public LookAt()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
