using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Conditions;

public class Condition_IsEnteringRegion : ConditionTask
{
	public BBParameter<GameRegion> regionName;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(InterfaceManager), Member = "TryGetPanel")]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(string), Member = "Equals")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	protected override bool OnCheck()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = ".ctor")]
	[Calls(Type = typeof(BBParameter<>), Member = "set_value")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	public Condition_IsEnteringRegion()
	{
	}
}
