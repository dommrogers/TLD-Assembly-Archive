using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_RemoveMissionLayer : ActionTask
{
	public List<string> m_Layers;

	protected override string info
	{
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Format")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(SceneManager), Member = "RemoveLayer")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public Action_RemoveMissionLayer()
	{
	}
}
