using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework;
using ParadoxNotion;

namespace NodeCanvas.Tasks.Conditions;

public class CheckEventValue<T> : ConditionTask<GraphOwner>
{
	public BBParameter<string> eventName;

	public BBParameter<T> value;

	protected override string info
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected override bool OnCheck()
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "ToUpper")]
	[Calls(Type = typeof(BBParameter<>), Member = "get_value")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(ConditionTask), Member = "Flip")]
	[Calls(Type = typeof(Task), Member = "StartCoroutine")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 7)]
	public void OnCustomEvent(EventData receivedEvent)
	{
	}

	[DeduplicatedMethod]
	[CalledBy(TypeFullName = "ParadoxNotion.Internal.AOTDummy.NodeCanvas_Tasks_Conditions_CheckEventValue_Collision", Member = ".ctor")]
	[CalledBy(TypeFullName = "ParadoxNotion.Internal.AOTDummy.NodeCanvas_Tasks_Conditions_CheckEventValue_Collision2D", Member = ".ctor")]
	[CalledBy(TypeFullName = "ParadoxNotion.Internal.AOTDummy.NodeCanvas_Tasks_Conditions_CheckEventValue_Space", Member = ".ctor")]
	[CalledBy(TypeFullName = "ParadoxNotion.Internal.AOTDummy.NodeCanvas_Tasks_Conditions_CheckEventValue_SpawnLocation", Member = ".ctor")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public CheckEventValue()
	{
		((ConditionTask<>)(object)this)._002Ector();
	}
}
