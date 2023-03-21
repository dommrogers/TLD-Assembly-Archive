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
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "Format")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEvent), Member = "AddListener")]
	[CallsUnknownMethods(Count = 2)]
	protected override string OnInit()
	{
		return null;
	}

	[CallerCount(Count = 3)]
	[DeduplicatedMethod]
	protected override bool OnCheck()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(ConditionTask), Member = "YieldReturn")]
	[DeduplicatedMethod]
	private void OnClick()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public ButtonClicked()
	{
	}
}
