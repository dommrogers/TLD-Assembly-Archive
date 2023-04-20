using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.BehaviourTrees;
using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework.Internal;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using ParadoxNotion;
using ParadoxNotion.Services;

namespace NodeCanvas.Framework;

[Serializable]
public abstract class BBParameter
{
	protected struct VariableBBInfo
	{
		public string m_VarName;

		public IBlackboard m_Blackboard;
	}

	private string _name;

	private string _targetVariableID;

	[NonSerialized]
	private IBlackboard _bb;

	[NonSerialized]
	private Variable _varRef;

	protected static Dictionary<string, VariableBBInfo> s_VariableBBInfoCache;

	private string targetVariableID
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 32)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 86)]
		set
		{
		}
	}

	public Variable varRef
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 28)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(PrioritySelector), Member = "OnChildConnected")]
		[CalledBy(Type = typeof(NodeCanvas.BehaviourTrees.ProbabilitySelector), Member = "OnChildConnected")]
		[CalledBy(Type = typeof(BBParameter), Member = "set_bb")]
		[CalledBy(Type = typeof(BBParameter), Member = "set_name")]
		[CalledBy(Type = typeof(BBParameter), Member = "set_useBlackboard")]
		[CalledBy(Type = typeof(BBParameter), Member = "PromoteToVariable")]
		[CalledBy(Type = typeof(BBParameter<>), Member = "get_value")]
		[CalledBy(Type = typeof(BBParameter<>), Member = "set_value")]
		[CalledBy(Type = typeof(BBParameter<>), Member = "CheckForPromotedVariable")]
		[CalledBy(Type = typeof(Dialogue_VoiceOverNode), Member = "OnExecute")]
		[CalledBy(Type = typeof(NodeCanvas.DialogueTrees.ProbabilitySelector.Option), Member = ".ctor")]
		[CallerCount(Count = 13)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public IBlackboard bb
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 27)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(Task), Member = "set_agentIsOverride")]
		[CalledBy(Type = typeof(Task), Member = "set_blackboard")]
		[CalledBy(Type = typeof(Task), Member = "Set")]
		[CalledBy(Type = typeof(BBParameter), Member = "CreateInstance")]
		[CalledBy(Type = typeof(BBParameter), Member = "SetBBFields")]
		[CalledBy(Type = typeof(Dialogue_MultipleChoiceNode), Member = "OnExecute")]
		[CalledBy(Type = typeof(TLDSetOtherBlackboardVariable), Member = "OnExecute")]
		[CalledBy(Type = typeof(ExecuteFunction_Multiplatform), Member = "SetMethod")]
		[CallerCount(Count = 9)]
		[Calls(Type = typeof(BBParameter), Member = "ResolveReference")]
		[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
		set
		{
		}
	}

	public string name
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 92)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(BBParameter), Member = "set_useBlackboard")]
		[CallerCount(Count = 1)]
		[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
		[Calls(Type = typeof(BBParameter), Member = "ResolveReference")]
		[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
		set
		{
		}
	}

	public bool useBlackboard
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
		[Calls(Type = typeof(BBParameter), Member = "set_name")]
		set
		{
		}
	}

	public bool isNone
	{
		[CalledBy(Type = typeof(BBParameter), Member = "ToString")]
		[CalledBy(Type = typeof(BBParameter<>), Member = "set_value")]
		[CalledBy(Type = typeof(CheckMousePick2D), Member = "get_info")]
		[CalledBy(Type = typeof(ExecuteFunction), Member = "get_info")]
		[CalledBy(Type = typeof(ExecuteStaticFunction), Member = "get_info")]
		[CallerCount(Count = 6)]
		[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
		get
		{
			return false;
		}
	}

	public bool isDefined
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return false;
		}
	}

	public bool isNull
	{
		[CalledBy(Type = typeof(Task), Member = "Internal_GetWarning")]
		[CalledBy(Type = typeof(BBParameter), Member = "ToString")]
		[CalledBy(Type = typeof(TLD_GearInsideTrigger), Member = "get_info")]
		[CalledBy(Type = typeof(TLD_GearInsideTrigger), Member = "OnCheck")]
		[CalledBy(Type = typeof(Condition_CheckContainerLiquid), Member = "get_info")]
		[CalledBy(Type = typeof(Condition_CheckContainerLiquid), Member = "OnCheck")]
		[CalledBy(Type = typeof(Condition_CheckContainerPowder), Member = "get_info")]
		[CalledBy(Type = typeof(Condition_CheckContainerPowder), Member = "OnCheck")]
		[CalledBy(Type = typeof(Condition_TransmitterCheckBase), Member = "get_info")]
		[CalledBy(Type = typeof(Condition_TransmitterCheckBase), Member = "OnCheck")]
		[CalledBy(Type = typeof(Condition_TransmitterCheckBase), Member = "GetState")]
		[CalledBy(Type = typeof(Action_NPCEnableConditionUpdate), Member = "OnExecute")]
		[CalledBy(Type = typeof(Action_NPCSetCondition), Member = "OnExecute")]
		[CalledBy(Type = typeof(Action_NPCSetFreezing), Member = "OnExecute")]
		[CalledBy(Type = typeof(Action_TrackStat), Member = "OnIncrementStat")]
		[CalledBy(Type = typeof(Action_TrackStat), Member = "OnSetStat")]
		[CalledBy(Type = typeof(GetToString), Member = "OnExecute")]
		[CalledBy(Type = typeof(SendMessage<>), Member = "OnExecute")]
		[CallerCount(Count = 18)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return false;
		}
	}

	public Type refType
	{
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public object value
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	protected abstract object objectValue { get; set; }

	public abstract Type varType { get; }

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public BBParameter()
	{
	}

	[CalledBy(Type = typeof(CheckFunction), Member = "OnValidate")]
	[CalledBy(Type = typeof(CheckFunction), Member = "SetMethod")]
	[CalledBy(Type = typeof(CheckProperty), Member = "OnValidate")]
	[CalledBy(Type = typeof(CheckProperty), Member = "SetMethod")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[Calls(Type = typeof(BBParameter), Member = "set_bb")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public static BBParameter CreateInstance(Type t, IBlackboard bb)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void ResetVariableNamesCache()
	{
	}

	[CalledBy(Type = typeof(Graph), Member = "UpdateReferences")]
	[CalledBy(Type = typeof(Graph), Member = "UpdateNodeBBFields")]
	[CalledBy(Type = typeof(Node), Member = "Create")]
	[CalledBy(Type = typeof(Node), Member = "Duplicate")]
	[CalledBy(Type = typeof(Task), Member = "Create")]
	[CalledBy(Type = typeof(Task), Member = "Duplicate")]
	[CalledBy(Type = typeof(Task), Member = "set_blackboard")]
	[CalledBy(Type = typeof(Task), Member = "Set")]
	[CalledBy(Type = typeof(ReflectedActionWrapper), Member = "Create")]
	[CalledBy(Type = typeof(ReflectedFunctionWrapper), Member = "Create")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(BBParameter), Member = "GetObjectBBParameters")]
	[Calls(Type = typeof(BBParameter), Member = "set_bb")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 2)]
	public static void SetBBFields(object o, IBlackboard bb)
	{
	}

	[CalledBy(Type = typeof(Graph), Member = "GetTaskAndParametersStructureInTarget")]
	[CalledBy(Type = typeof(BBParameter), Member = "SetBBFields")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetFields")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[Calls(Type = typeof(FieldInfo), Member = "SetValue")]
	[CallsDeduplicatedMethods(Count = 19)]
	[CallsUnknownMethods(Count = 14)]
	public static List<BBParameter> GetObjectBBParameters(object o)
	{
		return null;
	}

	protected abstract void Bind(Variable data);

	[CalledBy(Type = typeof(PrioritySelector), Member = "OnChildConnected")]
	[CalledBy(Type = typeof(NodeCanvas.BehaviourTrees.ProbabilitySelector), Member = "OnChildConnected")]
	[CalledBy(Type = typeof(BBParameter), Member = "set_bb")]
	[CalledBy(Type = typeof(BBParameter), Member = "set_name")]
	[CalledBy(Type = typeof(ReflectedWrapper), Member = "SetVariablesBB")]
	[CalledBy(Type = typeof(Dialogue_VoiceOverNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(Dialogue_VoiceOverNodeSequence), Member = "OnExecute")]
	[CalledBy(Type = typeof(Dialogue_MultipleChoiceNode), Member = "OnExecute")]
	[CalledBy(Type = typeof(NodeCanvas.DialogueTrees.ProbabilitySelector.Option), Member = ".ctor")]
	[CalledBy(Type = typeof(CheckFunction_Multiplatform), Member = "SetMethod")]
	[CalledBy(Type = typeof(ExecuteFunction_Multiplatform), Member = "SetMethod")]
	[CalledBy(Type = typeof(ImplementedAction_Multiplatform), Member = "SetMethod")]
	[CalledBy(Type = typeof(ExecuteStaticFunction_Multiplatform), Member = "SetMethod")]
	[CallerCount(Count = 15)]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(GlobalBlackboard), Member = "Find")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	private Variable ResolveReference(IBlackboard targetBlackboard, bool useID)
	{
		return null;
	}

	[CalledBy(Type = typeof(Graph), Member = "PromoteDefinedParametersToVariables")]
	[CalledBy(Type = typeof(BBParameter<>), Member = "set_value")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(GlobalBlackboard), Member = "Find")]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Logger), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public Variable PromoteToVariable(IBlackboard targetBB)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	[Calls(Type = typeof(BBParameter), Member = "get_isNull")]
	[Calls(Type = typeof(StringUtils), Member = "ToStringAdvanced")]
	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 2)]
	public sealed override string ToString()
	{
		return null;
	}
}
[Serializable]
public class BBParameter<T> : BBParameter
{
	private sealed class _003C_003Ec__DisplayClass15_0
	{
		public Func<object> convertFunc;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass15_0()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		internal T _003CBindGetter_003Eb__0()
		{
			return default(T);
		}
	}

	private sealed class _003C_003Ec__DisplayClass16_0
	{
		public Action<object> convertFunc;

		public Variable variable;

		public BBParameter<T> _003C_003E4__this;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass16_0()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 2)]
		internal void _003CBindSetter_003Eb__0(T value)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
		[Calls(Type = typeof(string), Member = "Format")]
		[Calls(Type = typeof(Logger), Member = "LogWarning")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		internal void _003CBindSetter_003Eb__1(T value)
		{
		}
	}

	private Func<T> getter;

	private Action<T> setter;

	protected T _value;

	public new T value
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 110)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return default(T);
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
		[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
		[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	protected override object objectValue
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		set
		{
		}
	}

	public override Type varType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		get
		{
			return null;
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public BBParameter()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public BBParameter(T value)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Contains")]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(GlobalBlackboard), Member = "Find")]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	protected void CheckForPromotedVariable(string name)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	protected override void Bind(Variable variable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Variable), Member = "GetGetConverter")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	private bool BindGetter(Variable variable)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Variable), Member = "GetSetConverter")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 7)]
	private bool BindSetter(Variable variable)
	{
		return false;
	}

	[DeduplicatedMethod]
	[CalledBy(Type = typeof(CheckButtonInput), Member = ".ctor")]
	[CalledBy(Type = typeof(Action_SetBaseAIStateFollowWaypoint), Member = ".ctor")]
	[CalledBy(Type = typeof(Action_PlayTimelineOnPlayer), Member = ".ctor")]
	[CalledBy(Type = typeof(FindAllWithName), Member = ".ctor")]
	[CalledBy(Type = typeof(GetInputAxis), Member = ".ctor")]
	[CalledBy(Type = typeof(CurveTransformTween), Member = ".ctor")]
	[CalledBy(Type = typeof(Patrol), Member = ".ctor")]
	[CalledBy(Type = typeof(DebugLogText), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	public static implicit operator BBParameter<T>(T value)
	{
		return null;
	}
}
