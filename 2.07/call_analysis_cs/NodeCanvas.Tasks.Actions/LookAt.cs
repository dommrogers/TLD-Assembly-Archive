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
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(LookAt), Member = "DoLook")]
	protected override void OnUpdate()
	{
	}

	[CalledBy(Type = typeof(LookAt), Member = "OnExecute")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CalledBy(Type = typeof(LookAt), Member = "OnUpdate")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Transform), Member = "LookAt")]
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
