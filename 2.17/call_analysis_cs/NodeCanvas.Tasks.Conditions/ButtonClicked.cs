using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using UnityEngine.Events;
using UnityEngine.UI;

namespace NodeCanvas.Tasks.Conditions;

public class ButtonClicked : ConditionTask
{
	public BBParameter<Button> button;

	protected override string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(string), Member = "Format")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(UnityEvent), Member = "AddListener")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected override string OnInit()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 3)]
	protected override bool OnCheck()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	private void OnClick()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ButtonClicked()
	{
	}
}
