using System;
using System.Collections;
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
		[CallerCount(Count = 101)]
		public EventReceiverAttribute(string[] args)
		{
		}
	}

	protected class GetFromAgentAttribute : Attribute
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
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
		[CallerCount(Count = 12)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 20)]
		private set
		{
		}
	}

	public Component ownerAgent
	{
		[CallerCount(Count = 2)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(Task), Member = "get_agent")]
		[CalledBy(Type = typeof(GraphOwnerControl), Member = "OnExecute")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public IBlackboard ownerBlackboard
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	protected float ownerElapsedTime
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
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
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(Task), Member = "Internal_GetWarning")]
		[CalledBy(Type = typeof(Task), Member = "Internal_GetWarning")]
		get
		{
			return null;
		}
	}

	public string name
	{
		[CalledBy(Type = typeof(Action_ObjectiveToggleInvisible), Member = "get_info")]
		[CalledBy(Type = typeof(Action_ObjectiveCompleteMain), Member = "get_info")]
		[CalledBy(Type = typeof(Action_ObjectiveUpdateTimer), Member = "get_info")]
		[CalledBy(Type = typeof(Action_ObjectiveUpdateDesc), Member = "get_info")]
		[CalledBy(Type = typeof(Action_ObjectiveAddNew), Member = "get_info")]
		[CalledBy(Type = typeof(Action_MissionUpdateTimer), Member = "get_info")]
		[CalledBy(Type = typeof(Action_MissionUpdateTexture), Member = "get_info")]
		[CalledBy(Type = typeof(Action_MissionUpdateDesc), Member = "get_info")]
		[CalledBy(Type = typeof(Action_MissionUpdateName), Member = "get_info")]
		[CalledBy(Type = typeof(Action_MissionAddNew), Member = "get_info")]
		[CalledBy(Type = typeof(Action_RevealMapLocation), Member = "get_info")]
		[CalledBy(Type = typeof(Action_RemoveMissionMarkerFromMap), Member = "get_info")]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
		[Calls(Type = typeof(StringUtils), Member = "SplitCamelCase")]
		[CallerCount(Count = 16)]
		[CalledBy(Type = typeof(Condition_PlayerItemIsEquipped), Member = "get_info")]
		[CalledBy(Type = typeof(Condition_CanSave), Member = "get_info")]
		[CalledBy(Type = typeof(Action_AddMissionMarkerToMap), Member = "get_info")]
		[CalledBy(Type = typeof(Task), Member = "get_info")]
		get
		{
			return null;
		}
	}

	public string description
	{
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
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
		[CalledBy(Type = typeof(ConditionList), Member = "get_info")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(Task), Member = "ToString")]
		[CalledBy(Type = typeof(ActionList), Member = "get_info")]
		[CallsDeduplicatedMethods(Count = 4)]
		[Calls(Type = typeof(string), Member = "Concat")]
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
		[CallerCount(Count = 23)]
		[CallsDeduplicatedMethods(Count = 2)]
		get
		{
			return null;
		}
	}

	public bool agentIsOverride
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
		[CallsUnknownMethods(Count = 10)]
		[Calls(Type = typeof(BBParameter), Member = "set_bb")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
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
		[CallerCount(Count = 53)]
		[CallsDeduplicatedMethods(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[Calls(Type = typeof(TaskAgentParameter), Member = "get_value")]
		[Calls(Type = typeof(Task), Member = "get_ownerAgent")]
		[Calls(Type = typeof(Task), Member = "TransformAgent")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public IBlackboard blackboard
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 5)]
		get
		{
			return null;
		}
		[Calls(Type = typeof(BBParameter), Member = "SetBBFields")]
		[Calls(Type = typeof(BBParameter), Member = "set_bb")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
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
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 5)]
	private BBParameter[] NodeCanvas_002EFramework_002EISubParametersContainer_002EGetSubParameters()
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public Task()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Task), Member = "Create")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 1)]
	public static T Create<T>(ITaskSystem newOwnerSystem) where T : Task
	{
		return null;
	}

	[CalledBy(Type = typeof(ConcurrentState), Member = "OnValidate")]
	[CalledBy(Type = typeof(ActionState), Member = "OnValidate")]
	[CalledBy(Type = typeof(ConcurrentState), Member = "OnValidate")]
	[CalledBy(Type = typeof(State_TLDBaseFSM), Member = "Initialize")]
	[CalledBy(Type = typeof(SuperActionState), Member = "OnValidate")]
	[CalledBy(Type = typeof(SuperActionState), Member = "OnValidate")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(State_DialogueSubDT), Member = "OnValidate")]
	[CalledBy(Type = typeof(SuperActionState), Member = "OnValidate")]
	[CalledBy(Type = typeof(ConcurrentSuperState), Member = "OnValidate")]
	[CalledBy(Type = typeof(Task), Member = "Create")]
	[CalledBy(Type = typeof(ConcurrentSuperState), Member = "OnValidate")]
	[CalledBy(Type = typeof(ActionListPlayer), Member = "UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize")]
	[Calls(Type = typeof(BBParameter), Member = "SetBBFields")]
	[Calls(Type = typeof(Task), Member = "SetOwnerSystem")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 13)]
	[CalledBy(Type = typeof(ConcurrentSuperState), Member = "OnValidate")]
	public static Task Create(Type type, ITaskSystem newOwnerSystem)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(ConditionList), Member = "Duplicate")]
	[CalledBy(Type = typeof(ActionList), Member = "Duplicate")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Task), Member = "SetOwnerSystem")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BBParameter), Member = "SetBBFields")]
	public virtual Task Duplicate(ITaskSystem newOwnerSystem)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public virtual void OnCreate(ITaskSystem ownerSystem)
	{
	}

	[CallerCount(Count = 2)]
	[DeduplicatedMethod]
	public virtual void OnValidate(ITaskSystem ownerSystem)
	{
	}

	[CalledBy(Type = typeof(ActionList), Member = "AddAction")]
	[CalledBy(Type = typeof(Graph), Member = "SendTaskOwnerDefaults")]
	[CalledBy(Type = typeof(ConditionList), Member = "AddCondition")]
	[CalledBy(Type = typeof(Graph), Member = "UpdateReferences")]
	[CalledBy(Type = typeof(Task), Member = "Create")]
	[CalledBy(Type = typeof(ActionListPlayer), Member = "SendTaskOwnerDefaults")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 8)]
	[CalledBy(Type = typeof(ActionListPlayer), Member = "SendTaskOwnerDefaults")]
	[CalledBy(Type = typeof(Task), Member = "Duplicate")]
	public void SetOwnerSystem(ITaskSystem newOwnerSystem)
	{
	}

	[CallerCount(Count = 60)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(MonoManager), Member = "get_current")]
	[Calls(Type = typeof(MonoBehaviour), Member = "StartCoroutine")]
	[CallsUnknownMethods(Count = 1)]
	protected Coroutine StartCoroutine(IEnumerator routine)
	{
		return null;
	}

	[Calls(Type = typeof(MonoBehaviour), Member = "StopCoroutine")]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(MonoManager), Member = "get_current")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected void StopCoroutine(Coroutine routine)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
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

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(ConcurrentState), Member = "OnEnter")]
	[CalledBy(Type = typeof(FSMState), Member = "OnExecute")]
	[CalledBy(Type = typeof(ConditionTask), Member = "CheckCondition")]
	[CalledBy(Type = typeof(ConditionTask), Member = "Enable")]
	[CalledBy(Type = typeof(ConditionList), Member = "OnEnable")]
	[CalledBy(Type = typeof(ActionTask), Member = "ExecuteAction")]
	[Calls(Type = typeof(Task), Member = "Initialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(TaskAgentParameter), Member = "get_value")]
	[Calls(Type = typeof(BBParameter), Member = "set_bb")]
	[Calls(Type = typeof(BBParameter), Member = "SetBBFields")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 6)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	protected bool Set(Component newAgent, IBlackboard newBB)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(Task), Member = "get_agent")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Task), Member = "Initialize")]
	[Calls(Type = typeof(Type), Member = "get_IsInterface")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	private static Component TransformAgent(Component input, Type type)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Task), Member = "Set")]
	[Calls(Type = typeof(Task), Member = "InitializeAttributes")]
	[Calls(Type = typeof(Task), Member = "RegisterEvents")]
	[Calls(Type = typeof(Task), Member = "Error")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Task), Member = "TransformAgent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(MessageRouter), Member = "UnRegister")]
	private bool Initialize(Component newAgent)
	{
		return default(bool);
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
	[CalledBy(Type = typeof(Task), Member = "Initialize")]
	[Calls(Type = typeof(Task), Member = "Error")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetFields")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	private bool InitializeAttributes(Component newAgent)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ExecuteStaticFunction_Multiplatform), Member = "OnValidate")]
	[CalledBy(Type = typeof(ExecuteStaticFunction), Member = "OnValidate")]
	[CalledBy(Type = typeof(SetProperty), Member = "OnValidate")]
	[CalledBy(Type = typeof(ImplementedAction), Member = "OnValidate")]
	[CalledBy(Type = typeof(GetProperty), Member = "OnValidate")]
	[CalledBy(Type = typeof(ExecuteFunction), Member = "OnValidate")]
	[CalledBy(Type = typeof(SetProperty_Multiplatform), Member = "OnValidate")]
	[CalledBy(Type = typeof(ImplementedAction_Multiplatform), Member = "OnValidate")]
	[CalledBy(Type = typeof(GetProperty_Multiplatform), Member = "OnValidate")]
	[CalledBy(Type = typeof(ExecuteFunction_Multiplatform), Member = "OnValidate")]
	[CalledBy(Type = typeof(CheckFunction), Member = "OnValidate")]
	[CallerCount(Count = 16)]
	[CalledBy(Type = typeof(CheckProperty), Member = "OnValidate")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Task), Member = "Initialize")]
	[CalledBy(Type = typeof(Task), Member = "InitializeAttributes")]
	[CalledBy(Type = typeof(CheckFunction_Multiplatform), Member = "OnValidate")]
	[CalledBy(Type = typeof(CheckProperty_Multiplatform), Member = "OnValidate")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogError")]
	protected bool Error(string error)
	{
		return default(bool);
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public void RegisterEvent(string eventName)
	{
	}

	[Calls(Type = typeof(MessageRouter), Member = "Register")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(InterceptEvent), Member = "OnInit")]
	[CalledBy(Type = typeof(Task), Member = "Initialize")]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	public void RegisterEvents(string[] eventNames)
	{
	}

	[CallsUnknownMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[Calls(Type = typeof(MessageRouter), Member = "UnRegister")]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public void UnRegisterEvent(string eventName)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(MessageRouter), Member = "UnRegister")]
	[CallsUnknownMethods(Count = 2)]
	public void UnRegisterEvents(string[] eventNames)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[Calls(Type = typeof(MessageRouter), Member = "UnRegister")]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	public void UnRegisterAllEvents()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Task), Member = "Internal_GetWarning")]
	public string GetWarning()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(Task), Member = "GetWarning")]
	[Calls(Type = typeof(StringUtils), Member = "SplitCamelCase")]
	[Calls(Type = typeof(StringUtils), Member = "SplitCamelCase")]
	[Calls(Type = typeof(StringUtils), Member = "SplitCamelCase")]
	[Calls(Type = typeof(StringUtils), Member = "SplitCamelCase")]
	[Calls(Type = typeof(BBParameter), Member = "get_isNull")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetFields")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(Task), Member = "get_agent")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(Task), Member = "get_obsolete")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(Task), Member = "get_obsolete")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Format")]
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
	[CallerCount(Count = 2)]
	public virtual void OnDrawGizmos()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public virtual void OnDrawGizmosSelected()
	{
	}
}
