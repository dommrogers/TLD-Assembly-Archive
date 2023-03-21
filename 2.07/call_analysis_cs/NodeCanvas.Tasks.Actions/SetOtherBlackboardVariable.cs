using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using NodeCanvas.Framework.Internal;

namespace NodeCanvas.Tasks.Actions;

public class SetOtherBlackboardVariable : ActionTask<Blackboard>
{
	public BBParameter<string> targetVariableName;

	public BBObjectParameter newValue;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Format")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(BlackboardSource), Member = "SetValue")]
	[Calls(Type = typeof(ActionTask), Member = "EndAction")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected override void OnExecute()
	{
	}

	[CallerCount(Count = 0)]
	public SetOtherBlackboardVariable()
	{
		((ActionTask<>)(object)this)._002Ector();
	}
}
