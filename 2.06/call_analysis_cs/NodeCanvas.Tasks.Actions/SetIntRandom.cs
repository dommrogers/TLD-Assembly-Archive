using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;

namespace NodeCanvas.Tasks.Actions;

public class SetIntRandom : ActionTask
{
	public BBParameter<int> minValue;

	public BBParameter<int> maxValue;

	public BBParameter<int> intVariable;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsUnknownMethods(Count = 29)]
		get
		{
			return null;
		}
	}

	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	protected override void OnExecute()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public SetIntRandom()
	{
	}
}
