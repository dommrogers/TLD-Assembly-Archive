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
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 13)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	public GetCloserGameObjectInList()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
