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
using ParadoxNotion.Serialization;
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
		[CallerCount(Count = 282)]
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
		[CallerCount(Count = 28)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 50)]
		private set
		{
		}
	}

	public Component ownerAgent
	{
		[CalledBy(Type = typeof(Task), Member = "get_agent")]
		[CallerCount(Count = 1)]
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
			return 0f;
		}
	}

	public bool isActive
	{
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public string obsolete
	{
		[CalledBy(Type = typeof(Task), Member = "Internal_GetWarning")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(ReflectionTools), Member = "RTGetAttribute")]
		get
		{
			return null;
		}
	}

	public string name
	{
		[CalledBy(Type = typeof(Task), Member = "get_info")]
		[CalledBy(Type = typeof(Condition_PlayerItemIsEquipped), Member = "get_info")]
		[CalledBy(Type = typeof(Condition_CanSave), Member = "get_info")]
		[CalledBy(Type = typeof(Action_AddMissionMarkerToMap), Member = "get_info")]
		[CalledBy(Type = typeof(Action_RemoveMissionMarkerFromMap), Member = "get_info")]
		[CalledBy(Type = typeof(Action_RevealMapLocation), Member = "get_info")]
		[CalledBy(Type = typeof(Action_MissionAddNew), Member = "get_info")]
		[CalledBy(Type = typeof(Action_MissionUpdateName), Member = "get_info")]
		[CalledBy(Type = typeof(Action_MissionUpdateDesc), Member = "get_info")]
		[CalledBy(Type = typeof(Action_MissionUpdateTexture), Member = "get_info")]
		[CalledBy(Type = typeof(Action_MissionUpdateTimer), Member = "get_info")]
		[CalledBy(Type = typeof(Action_ObjectiveAddNew), Member = "get_info")]
		[CalledBy(Type = typeof(Action_ObjectiveUpdateDesc), Member = "get_info")]
		[CalledBy(Type = typeof(Action_ObjectiveUpdateTimer), Member = "get_info")]
		[CalledBy(Type = typeof(Action_ObjectiveCompleteMain), Member = "get_info")]
		[CalledBy(Type = typeof(Action_ObjectiveToggleInvisible), Member = "get_info")]
		[CallerCount(Count = 16)]
		[Calls(Type = typeof(ReflectionTools), Member = "RTGetAttribute")]
		[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
		[Calls(Type = typeof(StringUtils), Member = "SplitCamelCase")]
		get
		{
			return null;
		}
	}

	public string description
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(ReflectionTools), Member = "RTGetAttribute")]
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
		[CalledBy(Type = typeof(ActionList), Member = "get_info")]
		[CalledBy(Type = typeof(ConditionList), Member = "get_info")]
		[CalledBy(Type = typeof(Task), Member = "ToString")]
		[CallerCount(Count = 3)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsDeduplicatedMethods(Count = 2)]
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
		[CalledBy(Type = typeof(CheckProperty_Multiplatform), Member = "get_info")]
		[CalledBy(Type = typeof(CheckProperty), Member = "get_info")]
		[CalledBy(Type = typeof(GetProperty_Multiplatform), Member = "get_info")]
		[CalledBy(Type = typeof(ImplementedAction_Multiplatform), Member = "get_info")]
		[CalledBy(Type = typeof(SetProperty_Multiplatform), Member = "get_info")]
		[CalledBy(Type = typeof(GetProperty), Member = "get_info")]
		[CalledBy(Type = typeof(ImplementedAction), Member = "get_info")]
		[CalledBy(Type = typeof(SetProperty), Member = "get_info")]
		[CallerCount(Count = 8)]
		get
		{
			return null;
		}
	}

	public bool agentIsOverride
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 20)]
		get
		{
			return false;
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
		[CallerCount(Count = 56)]
		[Calls(Type = typeof(TaskAgentParameter), Member = "get_value")]
		[Calls(Type = typeof(Task), Member = "get_ownerAgent")]
		[Calls(Type = typeof(Task), Member = "TransformAgent")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
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
		[CallerCount(Count = 15)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 19)]
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

	[CalledBy(Type = typeof(ActionListPlayer), Member = "UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize")]
	[CalledBy(Type = typeof(Task), Member = "Create")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "Initialize")]
	[CalledBy(Type = typeof(ConcurrentSuperState), Member = "OnValidate")]
	[CalledBy(Type = typeof(State_DialogueSubDT), Member = "OnValidate")]
	[CalledBy(Type = typeof(ActionState), Member = "OnValidate")]
	[CalledBy(Type = typeof(ConcurrentState), Member = "OnValidate")]
	[CalledBy(Type = typeof(SuperActionState), Member = "OnValidate")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[Calls(Type = typeof(Task), Member = "SetOwnerSystem")]
	[Calls(Type = typeof(BBParameter), Member = "SetBBFields")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public static Task Create(Type type, ITaskSystem newOwnerSystem)
	{
		return null;
	}

	[CalledBy(Type = typeof(ActionList), Member = "Duplicate")]
	[CalledBy(Type = typeof(ConditionList), Member = "Duplicate")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(JSONSerializer), Member = "Clone")]
	[Calls(Type = typeof(Task), Member = "SetOwnerSystem")]
	[Calls(Type = typeof(BBParameter), Member = "SetBBFields")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
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

	[CalledBy(Type = typeof(ActionListPlayer), Member = "SendTaskOwnerDefaults")]
	[CalledBy(Type = typeof(ActionList), Member = "AddAction")]
	[CalledBy(Type = typeof(ConditionList), Member = "AddCondition")]
	[CalledBy(Type = typeof(Task), Member = "Create")]
	[CalledBy(Type = typeof(Task), Member = "Duplicate")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogError")]
	public void SetOwnerSystem(ITaskSystem newOwnerSystem)
	{
	}

	[CalledBy(Type = typeof(ConditionTask), Member = "YieldReturn")]
	[CalledBy(Type = typeof(TriggerBoolean), Member = "OnExecute")]
	[CalledBy(Type = typeof(ExecuteFunction), Member = "OnExecute")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(MonoManager), Member = "get_current")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsUnknownMethods(Count = 1)]
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

	[CalledBy(Type = typeof(ActionTask), Member = "ExecuteAction")]
	[CalledBy(Type = typeof(ConditionList), Member = "OnEnable")]
	[CalledBy(Type = typeof(ConditionTask), Member = "Enable")]
	[CalledBy(Type = typeof(ConditionTask), Member = "CheckCondition")]
	[CalledBy(Type = typeof(FSMState), Member = "OnExecute")]
	[CalledBy(Type = typeof(ConcurrentState), Member = "OnEnter")]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(BBParameter), Member = "SetBBFields")]
	[Calls(Type = typeof(BBParameter), Member = "set_bb")]
	[Calls(Type = typeof(TaskAgentParameter), Member = "get_value")]
	[Calls(Type = typeof(Task), Member = "Initialize")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	protected bool Set(Component newAgent, IBlackboard newBB)
	{
		return false;
	}

	[CalledBy(Type = typeof(Task), Member = "get_agent")]
	[CalledBy(Type = typeof(Task), Member = "Initialize")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "get_IsInterface")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 2)]
	private static Component TransformAgent(Component input, Type type)
	{
		return null;
	}

	[CalledBy(Type = typeof(Task), Member = "Set")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Task), Member = "UnRegisterAllEvents")]
	[Calls(Type = typeof(Task), Member = "TransformAgent")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetAttribute")]
	[Calls(Type = typeof(Task), Member = "RegisterEvents")]
	[Calls(Type = typeof(Task), Member = "InitializeAttributes")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Task), Member = "Error")]
	[CallsDeduplicatedMethods(Count = 5)]
	private bool Initialize(Component newAgent)
	{
		return false;
	}

	[CalledBy(Type = typeof(Task), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetFields")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTIsDefined")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(FieldInfo), Member = "SetValue")]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Task), Member = "Error")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 2)]
	private bool InitializeAttributes(Component newAgent)
	{
		return false;
	}

	[CalledBy(Type = typeof(Task), Member = "Initialize")]
	[CalledBy(Type = typeof(Task), Member = "InitializeAttributes")]
	[CalledBy(Type = typeof(CheckFunction_Multiplatform), Member = "OnValidate")]
	[CalledBy(Type = typeof(CheckProperty_Multiplatform), Member = "OnValidate")]
	[CalledBy(Type = typeof(CheckFunction), Member = "OnValidate")]
	[CalledBy(Type = typeof(CheckProperty), Member = "OnValidate")]
	[CalledBy(Type = typeof(ExecuteFunction_Multiplatform), Member = "OnValidate")]
	[CalledBy(Type = typeof(GetProperty_Multiplatform), Member = "OnValidate")]
	[CalledBy(Type = typeof(ImplementedAction_Multiplatform), Member = "OnValidate")]
	[CalledBy(Type = typeof(SetProperty_Multiplatform), Member = "OnValidate")]
	[CalledBy(Type = typeof(ExecuteFunction), Member = "OnValidate")]
	[CalledBy(Type = typeof(GetProperty), Member = "OnValidate")]
	[CalledBy(Type = typeof(ImplementedAction), Member = "OnValidate")]
	[CalledBy(Type = typeof(SetProperty), Member = "OnValidate")]
	[CalledBy(Type = typeof(ExecuteStaticFunction), Member = "OnValidate")]
	[CalledBy(Type = typeof(ExecuteStaticFunction_Multiplatform), Member = "OnValidate")]
	[CallerCount(Count = 16)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogError")]
	[CallsUnknownMethods(Count = 1)]
	protected bool Error(string error)
	{
		return false;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void RegisterEvent(string eventName)
	{
	}

	[CalledBy(Type = typeof(Task), Member = "Initialize")]
	[CalledBy(Type = typeof(InterceptEvent), Member = "OnInit")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[Calls(Type = typeof(MessageRouter), Member = "Register")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void RegisterEvents(string[] eventNames)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void UnRegisterEvent(string eventName)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(MessageRouter), Member = "UnRegister")]
	[CallsUnknownMethods(Count = 1)]
	public void UnRegisterEvents(string[] eventNames)
	{
	}

	[CalledBy(Type = typeof(Task), Member = "Initialize")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(MessageRouter), Member = "UnRegister")]
	[CallsUnknownMethods(Count = 1)]
	public void UnRegisterAllEvents()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task), Member = "Internal_GetWarning")]
	public string GetWarning()
	{
		return null;
	}

	[CalledBy(Type = typeof(Task), Member = "GetWarning")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Task), Member = "get_obsolete")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetFields")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTIsDefined")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(BBParameter), Member = "get_isNull")]
	[Calls(Type = typeof(StringUtils), Member = "SplitCamelCase")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CallsUnknownMethods(Count = 3)]
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
