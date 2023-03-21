using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions;

public class SendEventToObjects : ActionTask
{
	public BBParameter<List<GameObject>> targetObjects;

	public BBParameter<string> eventName;

	protected override string info
	{
		[Calls(Type = typeof(string), Member = "Format")]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 7)]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public SendEventToObjects()
	{
	}
}
public class SendEventToObjects<T> : ActionTask
{
	public BBParameter<List<GameObject>> targetObjects;

	public BBParameter<string> eventName;

	public BBParameter<T> eventValue;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Format")]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(GraphOwner), Member = "SendEvent")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 10)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public SendEventToObjects()
	{
	}
}
