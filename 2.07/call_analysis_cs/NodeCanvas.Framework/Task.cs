using System;
using System.Collections;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework.Internal;
using NodeCanvas.StateMachines;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using ParadoxNotion;
using ParadoxNotion.Services;
using UnityEngine;

namespace NodeCanvas.Framework;

[Serializable]
public abstract class Task : ISubParametersContainer
{
	protected class EventReceiverAttribute : Attribute
	{
		public readonly string[] eventMessages;

		[DeduplicatedMethod]
		[CallerCount(Count = 279)]
		public EventReceiverAttribute(string[] args)
		{
		}
	}

	protected class GetFromAgentAttribute : Attribute
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public GetFromAgentAttribute()
		{
		}
	}

	private bool _isDisabled;

	private TaskAgentParameter overrideAgent;

	[NonSerialized]
	private IBlackboard _blackboard;

	[NonSerialized]
	private ITaskSystem _ownerSystem;

	[NonSerialized]
	private Component current;

	[NonSerialized]
	private string _taskName;

	[NonSerialized]
	private string _taskDescription;

	[NonSerialized]
	private string _obsoleteInfo;

	private string _003CfirstWarningMessage_003Ek__BackingField;

	public ITaskSystem ownerSystem
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 25)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 40)]
		private set
		{
		}
	}

	public Component ownerAgent
	{
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(Task), Member = "get_agent")]
		[CallerCount(Count = 1)]
		get
		{
			return null;
		}
	}

	public IBlackboard ownerBlackboard
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	protected float ownerElapsedTime
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(float);
		}
	}

	public bool isActive
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string obsolete
	{
		[CalledBy(Type = typeof(Task), Member = "Internal_GetWarning")]
		[CalledBy(Type = typeof(Task), Member = "Internal_GetWarning")]
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public string name
	{
		[CalledBy(Type = typeof(Action_ObjectiveCompleteMain), Member = "get_info")]
		[CalledBy(Type = typeof(Action_ObjectiveToggleInvisible), Member = "get_info")]
		[CalledBy(Type = typeof(Action_ObjectiveUpdateTimer), Member = "get_info")]
		[CalledBy(Type = typeof(Action_ObjectiveAddNew), Member = "get_info")]
		[CalledBy(Type = typeof(Action_MissionUpdateTimer), Member = "get_info")]
		[CalledBy(Type = typeof(Action_MissionUpdateTexture), Member = "get_info")]
		[CalledBy(Type = typeof(Action_MissionUpdateDesc), Member = "get_info")]
		[CalledBy(Type = typeof(Action_MissionUpdateName), Member = "get_info")]
		[CalledBy(Type = typeof(Action_MissionAddNew), Member = "get_info")]
		[CalledBy(Type = typeof(Action_ObjectiveUpdateDesc), Member = "get_info")]
		[CalledBy(Type = typeof(Action_RemoveMissionMarkerFromMap), Member = "get_info")]
		[CalledBy(Type = typeof(Action_AddMissionMarkerToMap), Member = "get_info")]
		[CalledBy(Type = typeof(Condition_CanSave), Member = "get_info")]
		[CalledBy(Type = typeof(Condition_PlayerItemIsEquipped), Member = "get_info")]
		[CalledBy(Type = typeof(Task), Member = "get_info")]
		[Calls(Type = typeof(StringUtils), Member = "SplitCamelCase")]
		[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 16)]
		[CalledBy(Type = typeof(Action_RevealMapLocation), Member = "get_info")]
		get
		{
			return null;
		}
	}

	public string description
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public virtual Type agentType
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	public string summaryInfo
	{
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CalledBy(Type = typeof(ActionList), Member = "get_info")]
		[CalledBy(Type = typeof(ConditionList), Member = "get_info")]
		[CalledBy(Type = typeof(Task), Member = "ToString")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	protected virtual string info
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Task), Member = "get_name")]
		get
		{
			return null;
		}
	}

	public string agentInfo
	{
		[CalledBy(Type = typeof(GetProperty), Member = "get_info")]
		[CalledBy(Type = typeof(SetProperty_Multiplatform), Member = "get_info")]
		[CalledBy(Type = typeof(SetProperty), Member = "get_info")]
		[CalledBy(Type = typeof(ImplementedAction_Multiplatform), Member = "get_info")]
		[CalledBy(Type = typeof(ImplementedAction), Member = "get_info")]
		[CalledBy(Type = typeof(CheckProperty), Member = "get_info")]
		[CalledBy(Type = typeof(CheckProperty_Multiplatform), Member = "get_info")]
		[CalledBy(Type = typeof(GetProperty_Multiplatform), Member = "get_info")]
		[CallerCount(Count = 8)]
		get
		{
			return null;
		}
	}

	public bool agentIsOverride
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 10)]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BBParameter), Member = "set_bb")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public string overrideAgentParameterName
	{
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public Component agent
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Task), Member = "TransformAgent")]
		[Calls(Type = typeof(Task), Member = "get_ownerAgent")]
		[Calls(Type = typeof(TaskAgentParameter), Member = "get_value")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 56)]
		get
		{
			return null;
		}
	}

	public IBlackboard blackboard
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 27)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BBParameter), Member = "SetBBFields")]
		[Calls(Type = typeof(BBParameter), Member = "set_bb")]
		private set
		{
		}
	}

	public string firstWarningMessage
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		get
		{
			return null;
		}
		[CallerCount(Count = 14)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set
		{
		}
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 5)]
	private BBParameter[] NodeCanvas_002EFramework_002EISubParametersContainer_002EGetSubParameters()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public Task()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Task), Member = "Create")]
	[CallsUnknownMethods(Count = 3)]
	public static T Create<T>(ITaskSystem newOwnerSystem) where T : Task
	{
		return null;
	}

	[CalledBy(Type = typeof(ActionState), Member = "OnValidate")]
	[CalledBy(Type = typeof(ConcurrentState), Member = "OnValidate")]
	[CalledBy(Type = typeof(ConcurrentState), Member = "OnValidate")]
	[CalledBy(Type = typeof(State_DialogueSubDT), Member = "OnValidate")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(SuperActionState), Member = "OnValidate")]
	[CalledBy(Type = typeof(SuperActionState), Member = "OnValidate")]
	[CalledBy(Type = typeof(SuperActionState), Member = "OnValidate")]
	[CalledBy(Type = typeof(ConcurrentSuperState), Member = "OnValidate")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[CalledBy(Type = typeof(ConcurrentSuperState), Member = "OnValidate")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "Initialize")]
	[CalledBy(Type = typeof(Task), Member = "Create")]
	[CalledBy(Type = typeof(ActionListPlayer), Member = "UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize")]
	[Calls(Type = typeof(BBParameter), Member = "SetBBFields")]
	[Calls(Type = typeof(Task), Member = "SetOwnerSystem")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 13)]
	[CalledBy(Type = typeof(ConcurrentSuperState), Member = "OnValidate")]
	public static Task Create(Type type, ITaskSystem newOwnerSystem)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(ConditionList), Member = "Duplicate")]
	[CalledBy(Type = typeof(ActionList), Member = "Duplicate")]
	[Calls(Type = typeof(Task), Member = "SetOwnerSystem")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BBParameter), Member = "SetBBFields")]
	public virtual Task Duplicate(ITaskSystem newOwnerSystem)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void OnCreate(ITaskSystem ownerSystem)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void OnValidate(ITaskSystem ownerSystem)
	{
	}

	[CalledBy(Type = typeof(Task), Member = "Create")]
	[CalledBy(Type = typeof(Task), Member = "Duplicate")]
	[CalledBy(Type = typeof(ConditionList), Member = "AddCondition")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(ActionListPlayer), Member = "SendTaskOwnerDefaults")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogError")]
	[CalledBy(Type = typeof(ActionList), Member = "AddAction")]
	public void SetOwnerSystem(ITaskSystem newOwnerSystem)
	{
	}

	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MonoManager), Member = "get_current")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CalledBy(Type = typeof(ConditionTask), Member = "YieldReturn")]
	[CalledBy(Type = typeof(TriggerBoolean), Member = "OnExecute")]
	[CalledBy(Type = typeof(ExecuteFunction), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 1)]
	protected Coroutine StartCoroutine(IEnumerator routine)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StopCoroutine")]
	[Calls(Type = typeof(MonoManager), Member = "get_current")]
	[CallerCount(Count = 0)]
	protected void StopCoroutine(Coroutine routine)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected void SendEvent(EventData eventData)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected virtual string OnInit()
	{
		return null;
	}

	[CalledBy(Type = typeof(ConditionTask), Member = "CheckCondition")]
	[CalledBy(Type = typeof(FSMState), Member = "OnExecute")]
	[CalledBy(Type = typeof(ConditionTask), Member = "Enable")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(ConcurrentState), Member = "OnEnter")]
	[CalledBy(Type = typeof(ConditionList), Member = "OnEnable")]
	[Calls(Type = typeof(BBParameter), Member = "set_bb")]
	[Calls(Type = typeof(Task), Member = "Initialize")]
	[Calls(Type = typeof(TaskAgentParameter), Member = "get_value")]
	[CalledBy(Type = typeof(ActionTask), Member = "ExecuteAction")]
	[Calls(Type = typeof(BBParameter), Member = "SetBBFields")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 6)]
	protected bool Set(Component newAgent, IBlackboard newBB)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Task), Member = "Initialize")]
	[CalledBy(Type = typeof(Task), Member = "get_agent")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "get_IsInterface")]
	private static Component TransformAgent(Component input, Type type)
	{
		return null;
	}

	[Calls(Type = typeof(Task), Member = "InitializeAttributes")]
	[Calls(Type = typeof(Task), Member = "Error")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Task), Member = "RegisterEvents")]
	[CalledBy(Type = typeof(Task), Member = "Set")]
	[Calls(Type = typeof(Task), Member = "UnRegisterAllEvents")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Task), Member = "TransformAgent")]
	private bool Initialize(Component newAgent)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Task), Member = "Initialize")]
	[Calls(Type = typeof(Task), Member = "Error")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetFields")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(FieldInfo), Member = "SetValue")]
	private bool InitializeAttributes(Component newAgent)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(ImplementedAction_Multiplatform), Member = "OnValidate")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ExecuteStaticFunction_Multiplatform), Member = "OnValidate")]
	[CalledBy(Type = typeof(ExecuteStaticFunction), Member = "OnValidate")]
	[CalledBy(Type = typeof(SetProperty), Member = "OnValidate")]
	[CalledBy(Type = typeof(ImplementedAction), Member = "OnValidate")]
	[CalledBy(Type = typeof(GetProperty), Member = "OnValidate")]
	[CalledBy(Type = typeof(ExecuteFunction), Member = "OnValidate")]
	[CalledBy(Type = typeof(SetProperty_Multiplatform), Member = "OnValidate")]
	[CalledBy(Type = typeof(GetProperty_Multiplatform), Member = "OnValidate")]
	[CalledBy(Type = typeof(CheckFunction_Multiplatform), Member = "OnValidate")]
	[CalledBy(Type = typeof(CheckProperty), Member = "OnValidate")]
	[CalledBy(Type = typeof(CheckFunction), Member = "OnValidate")]
	[CalledBy(Type = typeof(CheckProperty_Multiplatform), Member = "OnValidate")]
	[CalledBy(Type = typeof(ExecuteFunction_Multiplatform), Member = "OnValidate")]
	[CalledBy(Type = typeof(Task), Member = "InitializeAttributes")]
	[CalledBy(Type = typeof(Task), Member = "Initialize")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallerCount(Count = 16)]
	protected bool Error(string error)
	{
		return default(bool);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void RegisterEvent(string eventName)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(InterceptEvent), Member = "OnInit")]
	[CalledBy(Type = typeof(Task), Member = "Initialize")]
	[Calls(Type = typeof(MessageRouter), Member = "Register")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	public void RegisterEvents(string[] eventNames)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void UnRegisterEvent(string eventName)
	{
	}

	[Calls(Type = typeof(MessageRouter), Member = "UnRegister")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	public void UnRegisterEvents(string[] eventNames)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[Calls(Type = typeof(MessageRouter), Member = "UnRegister")]
	[CalledBy(Type = typeof(Task), Member = "Initialize")]
	[CallsUnknownMethods(Count = 1)]
	public void UnRegisterAllEvents()
	{
	}

	[Calls(Type = typeof(Task), Member = "Internal_GetWarning")]
	[CallerCount(Count = 0)]
	public string GetWarning()
	{
		return null;
	}

	[CalledBy(Type = typeof(Task), Member = "GetWarning")]
	[Calls(Type = typeof(StringUtils), Member = "SplitCamelCase")]
	[Calls(Type = typeof(StringUtils), Member = "SplitCamelCase")]
	[Calls(Type = typeof(StringUtils), Member = "SplitCamelCase")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(StringUtils), Member = "SplitCamelCase")]
	[Calls(Type = typeof(BBParameter), Member = "get_isNull")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Task), Member = "get_obsolete")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetFields")]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Task), Member = "get_obsolete")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	private string Internal_GetWarning()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task), Member = "get_summaryInfo")]
	public override string ToString()
	{
		return null;
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	public virtual void OnDrawGizmos()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void OnDrawGizmosSelected()
	{
	}
}
