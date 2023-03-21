using System.Collections.Generic;
using System.Linq;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class SortGameObjectListByDistance : ActionTask<Transform>
{
	public BBParameter<List<GameObject>> targetList;

	public BBParameter<List<GameObject>> saveAs;

	public bool reverse;

	protected override string info
	{
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	public SortGameObjectListByDistance()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
