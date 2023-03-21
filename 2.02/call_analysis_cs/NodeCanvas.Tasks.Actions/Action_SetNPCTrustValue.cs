using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class Action_SetNPCTrustValue : ActionTask
{
	public BBParameter<string> npcTrustID;

	public BBParameter<int> trustValue;

	protected override string info
	{
		[CallsUnknownMethods(Count = 5)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(TrustManager), Member = "SetTrustValue")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsUnknownMethods(Count = 6)]
	protected override void OnExecute()
	{
	}

	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[CallsUnknownMethods(Count = 16)]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	public Action_SetNPCTrustValue()
	{
	}
}
