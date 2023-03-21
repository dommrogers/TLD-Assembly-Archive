using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class GetCloserGameObjectInList : ActionTask<Transform>
{
	public BBParameter<List<GameObject>> list;

	public BBParameter<GameObject> saveAs;

	protected override string info
	{
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Concat")]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	public GetCloserGameObjectInList()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
