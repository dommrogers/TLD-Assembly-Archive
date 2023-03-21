using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class GetComponent<T> : ActionTask<Transform> where T : Component
{
	public BBParameter<T> saveAs;

	protected override string info
	{
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public GetComponent()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
