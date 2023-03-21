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
		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
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
		[CallerCount(Count = 1)]
		[CalledBy(Type = typeof(Task), Member = "get_agent")]
		[CallsUnknownMethods(Count = 1)]
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
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CalledBy(Type = typeof(Task), Member = "Internal_GetWarning")]
		[CalledBy(Type = typeof(Task), Member = "Internal_GetWarning")]
		get
		{
			return null;
		}
	}

	public string name
	{
		[CalledBy(Type = typeof(Action_ObjectiveCompleteMain), Member = "get_info")]
		[CalledBy(Type = typeof(Action_ObjectiveUpdateTimer), Member = "get_info")]
		[CalledBy(Type = typeof(Action_ObjectiveToggleInvisible), Member = "get_info")]
		[CalledBy(Type = typeof(Action_ObjectiveUpdateDesc), Member = "get_info")]
		[CalledBy(Type = typeof(Action_ObjectiveAddNew), Member = "get_info")]
		[CalledBy(Type = typeof(Action_MissionUpdateTimer), Member = "get_info")]
		[CalledBy(Type = typeof(Action_MissionUpdateTexture), Member = "get_info")]
		[CalledBy(Type = typeof(Action_MissionUpdateDesc), Member = "get_info")]
		[CalledBy(Type = typeof(Action_MissionUpdateName), Member = "get_info")]
		[CalledBy(Type = typeof(Action_MissionAddNew), Member = "get_info")]
		[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
		[CalledBy(Type = typeof(Action_RemoveMissionMarkerFromMap), Member = "get_info")]
		[CalledBy(Type = typeof(Action_AddMissionMarkerToMap), Member = "get_info")]
		[CalledBy(Type = typeof(Condition_CanSave), Member = "get_info")]
		[CalledBy(Type = typeof(Condition_PlayerItemIsEquipped), Member = "get_info")]
		[CalledBy(Type = typeof(Task), Member = "get_info")]
		[Calls(Type = typeof(StringUtils), Member = "SplitCamelCase")]
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
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public string summaryInfo
	{
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(Task), Member = "ToString")]
		[CalledBy(Type = typeof(ActionList), Member = "get_info")]
		[CalledBy(Type = typeof(ConditionList), Member = "get_info")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(string), Member = "Concat")]
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
		[CalledBy(Type = typeof(SetProperty), Member = "get_info")]
		[CalledBy(Type = typeof(ImplementedAction), Member = "get_info")]
		[CalledBy(Type = typeof(GetProperty), Member = "get_info")]
		[CalledBy(Type = typeof(SetProperty_Multiplatform), Member = "get_info")]
		[CalledBy(Type = typeof(ImplementedAction_Multiplatform), Member = "get_info")]
		[CalledBy(Type = typeof(CheckProperty), Member = "get_info")]
		[CalledBy(Type = typeof(CheckProperty_Multiplatform), Member = "get_info")]
		[CallerCount(Count = 8)]
		[CalledBy(Type = typeof(GetProperty_Multiplatform), Member = "get_info")]
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
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BBParameter), Member = "set_bb")]
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
		[Calls(Type = typeof(Task), Member = "TransformAgent")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Task), Member = "get_ownerAgent")]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(TaskAgentParameter), Member = "get_value")]
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
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 14)]
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

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
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
	[CalledBy(Type = typeof(State_DialogueSubDT), Member = "OnValidate")]
	[CalledBy(Type = typeof(SuperActionState), Member = "OnValidate")]
	[CalledBy(Type = typeof(SuperActionState), Member = "OnValidate")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(ConcurrentSuperState), Member = "OnValidate")]
	[CalledBy(Type = typeof(SuperActionState), Member = "OnValidate")]
	[CalledBy(Type = typeof(ConcurrentSuperState), Member = "OnValidate")]
	[CalledBy(Type = typeof(ConcurrentState), Member = "OnValidate")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "Initialize")]
	[CalledBy(Type = typeof(Task), Member = "Create")]
	[CalledBy(Type = typeof(ActionListPlayer), Member = "UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize")]
	[Calls(Type = typeof(BBParameter), Member = "SetBBFields")]
	[CalledBy(Type = typeof(ConcurrentSuperState), Member = "OnValidate")]
	[Calls(Type = typeof(Task), Member = "SetOwnerSystem")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 13)]
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

	[CalledBy(Type = typeof(ConditionList), Member = "AddCondition")]
	[CalledBy(Type = typeof(Task), Member = "Create")]
	[CalledBy(Type = typeof(ActionList), Member = "AddAction")]
	[CalledBy(Type = typeof(Task), Member = "Duplicate")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogError")]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(ActionListPlayer), Member = "SendTaskOwnerDefaults")]
	public void SetOwnerSystem(ITaskSystem newOwnerSystem)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ExecuteFunction), Member = "OnExecute")]
	[CalledBy(Type = typeof(ConditionTask), Member = "YieldReturn")]
	[CalledBy(Type = typeof(TriggerBoolean), Member = "OnExecute")]
	[Calls(Type = typeof(MonoManager), Member = "get_current")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	protected Coroutine StartCoroutine(IEnumerator routine)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MonoManager), Member = "get_current")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StopCoroutine")]
	[CallsUnknownMethods(Count = 1)]
	protected void StopCoroutine(Coroutine routine)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
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

	[CalledBy(Type = typeof(ConditionTask), Member = "Enable")]
	[CalledBy(Type = typeof(ConditionTask), Member = "CheckCondition")]
	[CalledBy(Type = typeof(ConditionList), Member = "OnEnable")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(ConcurrentState), Member = "OnEnter")]
	[CalledBy(Type = typeof(ActionTask), Member = "ExecuteAction")]
	[CalledBy(Type = typeof(FSMState), Member = "OnExecute")]
	[Calls(Type = typeof(TaskAgentParameter), Member = "get_value")]
	[Calls(Type = typeof(BBParameter), Member = "set_bb")]
	[Calls(Type = typeof(BBParameter), Member = "SetBBFields")]
	[Calls(Type = typeof(Task), Member = "Initialize")]
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
	[CalledBy(Type = typeof(ExecuteStaticFunction_Multiplatform), Member = "OnValidate")]
	[CalledBy(Type = typeof(ExecuteStaticFunction), Member = "OnValidate")]
	[CalledBy(Type = typeof(SetProperty), Member = "OnValidate")]
	[CalledBy(Type = typeof(ImplementedAction), Member = "OnValidate")]
	[CalledBy(Type = typeof(GetProperty), Member = "OnValidate")]
	[CalledBy(Type = typeof(ExecuteFunction), Member = "OnValidate")]
	[CalledBy(Type = typeof(SetProperty_Multiplatform), Member = "OnValidate")]
	[CalledBy(Type = typeof(GetProperty_Multiplatform), Member = "OnValidate")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(CheckProperty), Member = "OnValidate")]
	[CalledBy(Type = typeof(CheckFunction), Member = "OnValidate")]
	[CalledBy(Type = typeof(CheckProperty_Multiplatform), Member = "OnValidate")]
	[CalledBy(Type = typeof(CheckFunction_Multiplatform), Member = "OnValidate")]
	[CalledBy(Type = typeof(Task), Member = "InitializeAttributes")]
	[CalledBy(Type = typeof(Task), Member = "Initialize")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallerCount(Count = 16)]
	[CalledBy(Type = typeof(ExecuteFunction_Multiplatform), Member = "OnValidate")]
	protected bool Error(string error)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public void RegisterEvent(string eventName)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[Calls(Type = typeof(MessageRouter), Member = "Register")]
	[CalledBy(Type = typeof(Task), Member = "Initialize")]
	[CalledBy(Type = typeof(InterceptEvent), Member = "OnInit")]
	[CallsUnknownMethods(Count = 2)]
	public void RegisterEvents(string[] eventNames)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public void UnRegisterEvent(string eventName)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[Calls(Type = typeof(MessageRouter), Member = "UnRegister")]
	[CallsUnknownMethods(Count = 1)]
	public void UnRegisterEvents(string[] eventNames)
	{
	}

	[Calls(Type = typeof(MessageRouter), Member = "UnRegister")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Task), Member = "Initialize")]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	public void UnRegisterAllEvents()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task), Member = "Internal_GetWarning")]
	public string GetWarning()
	{
		return null;
	}

	[Calls(Type = typeof(string), Member = "Format")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(StringUtils), Member = "SplitCamelCase")]
	[Calls(Type = typeof(BBParameter), Member = "get_isNull")]
	[Calls(Type = typeof(StringUtils), Member = "SplitCamelCase")]
	[CalledBy(Type = typeof(Task), Member = "GetWarning")]
	[Calls(Type = typeof(StringUtils), Member = "SplitCamelCase")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(StringUtils), Member = "SplitCamelCase")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetFields")]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Task), Member = "get_obsolete")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Task), Member = "get_obsolete")]
	[CallsDeduplicatedMethods(Count = 13)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	private string Internal_GetWarning()
	{
		return null;
	}

	[Calls(Type = typeof(Task), Member = "get_summaryInfo")]
	[CallerCount(Count = 0)]
	public override string ToString()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void OnDrawGizmos()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void OnDrawGizmosSelected()
	{
	}
}
