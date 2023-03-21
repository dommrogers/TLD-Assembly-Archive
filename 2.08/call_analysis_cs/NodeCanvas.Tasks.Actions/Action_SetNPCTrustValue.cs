using System;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_SetNPCTrustValue : ActionTask
{
	public BBParameter<string> npcTrustID;

	public BBParameter<int> trustValue;

	protected override string info
	{
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
		[CallsUnknownMethods(Count = 5)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(TrustManager), Member = "SetTrustValue")]
	[CallerCount(Count = 0)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public Action_SetNPCTrustValue()
	{
	}
}
