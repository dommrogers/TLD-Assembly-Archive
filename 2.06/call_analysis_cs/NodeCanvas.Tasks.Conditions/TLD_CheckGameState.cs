using System;
using Cpp2ILInjected.CallAnalysis;
using MissionTypes;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Conditions;

public class TLD_CheckGameState : ConditionTask
{
	public BBParameter<string> stateName;

	public string compareAgainstVar;

	private MissionGameState gameState;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	protected override void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(NCUtils), Member = "GetGameState")]
	[Calls(Type = typeof(string), Member = "Substring")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Panel_Loading), Member = "IsLoading")]
	[Calls(Type = typeof(Enum), Member = "Parse")]
	[CallerCount(Count = 0)]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 7)]
	public TLD_CheckGameState()
	{
	}
}
