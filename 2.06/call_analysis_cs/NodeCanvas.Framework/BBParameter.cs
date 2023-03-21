using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework.Internal;
using NodeCanvas.Tasks.Actions;
using NodeCanvas.Tasks.Conditions;
using ParadoxNotion;
using ParadoxNotion.Services;
using UnityEngine;

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
		[CallerCount(Count = 44)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 85)]
		set
		{
		}
	}

	public Variable varRef
	{
		[CallerCount(Count = 58)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallerCount(Count = 92)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public IBlackboard bb
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 23)]
		get
		{
			return null;
		}
		[CallerCount(Count = 22)]
		[Calls(Type = typeof(BBParameter), Member = "ResolveReference")]
		[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
		set
		{
		}
	}

	public string name
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 98)]
		get
		{
			return null;
		}
		[CalledBy(Type = typeof(BBParameter), Member = "set_useBlackboard")]
		[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		[Calls(Type = typeof(BBParameter), Member = "ResolveReference")]
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
			return default(bool);
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
		[CallerCount(Count = 89)]
		[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
		get
		{
			return default(bool);
		}
	}

	public bool isDefined
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
	}

	public bool isNull
	{
		[CalledBy(Type = typeof(SendMessage<>), Member = "OnExecute")]
		[CalledBy(Type = typeof(GetToString), Member = "OnExecute")]
		[CalledBy(Type = typeof(Action_TrackStat), Member = "OnSetStat")]
		[CalledBy(Type = typeof(Action_NPCSetFreezing), Member = "OnExecute")]
		[CalledBy(Type = typeof(Action_NPCSetCondition), Member = "OnExecute")]
		[CalledBy(Type = typeof(Action_NPCEnableConditionUpdate), Member = "OnExecute")]
		[CalledBy(Type = typeof(Condition_CheckContainerPowder), Member = "OnCheck")]
		[CalledBy(Type = typeof(Condition_CheckContainerPowder), Member = "get_info")]
		[CalledBy(Type = typeof(Action_TrackStat), Member = "OnIncrementStat")]
		[CalledBy(Type = typeof(Condition_CheckContainerLiquid), Member = "get_info")]
		[CallerCount(Count = 15)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CalledBy(Type = typeof(Condition_CheckContainerLiquid), Member = "OnCheck")]
		[CalledBy(Type = typeof(BBParameter), Member = "ToString")]
		[CalledBy(Type = typeof(TLD_GearInsideTrigger), Member = "get_info")]
		[CalledBy(Type = typeof(TLD_GearInsideTrigger), Member = "OnCheck")]
		[CalledBy(Type = typeof(Task), Member = "Internal_GetWarning")]
		get
		{
			return default(bool);
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
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	protected abstract object objectValue
	{
		[CallerCount(Count = 101224)]
		[DeduplicatedMethod]
		get;
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		set;
	}

	public abstract Type varType
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 101224)]
		get;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public BBParameter()
	{
	}

	[CalledBy(Type = typeof(CheckFunction), Member = "SetMethod")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(CheckProperty), Member = "OnValidate")]
	[CalledBy(Type = typeof(CheckFunction), Member = "OnValidate")]
	[CalledBy(Type = typeof(CheckProperty), Member = "SetMethod")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(BBParameter), Member = "set_bb")]
	public static BBParameter CreateInstance(Type t, IBlackboard bb)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void ResetVariableNamesCache()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(ReflectedFunctionWrapper), Member = "Create")]
	[CalledBy(Type = typeof(ReflectedActionWrapper), Member = "Create")]
	[CalledBy(Type = typeof(Task), Member = "Set")]
	[CalledBy(Type = typeof(Task), Member = "set_blackboard")]
	[CalledBy(Type = typeof(Task), Member = "Duplicate")]
	[CalledBy(Type = typeof(Task), Member = "Create")]
	[CalledBy(Type = typeof(Graph), Member = "UpdateNodeBBFields")]
	[CalledBy(Type = typeof(Node), Member = "Create")]
	[CalledBy(Type = typeof(Graph), Member = "UpdateReferences")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(BBParameter), Member = "set_bb")]
	[Calls(Type = typeof(BBParameter), Member = "GetObjectBBParameters")]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(Node), Member = "Duplicate")]
	public static void SetBBFields(object o, IBlackboard bb)
	{
	}

	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(BBParameter), Member = "SetBBFields")]
	[CalledBy(Type = typeof(Graph), Member = "GetTaskAndParametersStructureInTarget")]
	[Calls(Type = typeof(FieldInfo), Member = "SetValue")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetFields")]
	[CallsDeduplicatedMethods(Count = 21)]
	[CallerCount(Count = 2)]
	public static List<BBParameter> GetObjectBBParameters(object o)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	protected abstract void Bind(Variable data);

	[CalledBy(Type = typeof(BBParameter), Member = "set_name")]
	[CalledBy(Type = typeof(BBParameter), Member = "set_bb")]
	[Calls(Type = typeof(GlobalBlackboard), Member = "Find")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(string), Member = "Split")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	private Variable ResolveReference(IBlackboard targetBlackboard, bool useID)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[Calls(Type = typeof(GlobalBlackboard), Member = "Find")]
	[Calls(Type = typeof(string), Member = "Split")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 85)]
	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	public Variable PromoteToVariable(IBlackboard targetBB)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	[Calls(Type = typeof(BBParameter), Member = "get_isNull")]
	[Calls(Type = typeof(StringUtils), Member = "ToStringAdvanced")]
	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
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

		[CallsUnknownMethods(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		internal T _003CBindGetter_003Eb__0()
		{
			return (T)null;
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

		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogWarning")]
		[Calls(Type = typeof(string), Member = "FormatHelper")]
		[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
		[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
		internal void _003CBindSetter_003Eb__1(T value)
		{
		}
	}

	private Func<T> getter;

	private Action<T> setter;

	protected T _value;

	public new T value
	{
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
		[CallerCount(Count = 110)]
		[DeduplicatedMethod]
		[CallsDeduplicatedMethods(Count = 3)]
		get
		{
			return (T)null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
		[Calls(Type = typeof(BBParameter), Member = "PromoteToVariable")]
		[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
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
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(GlobalBlackboard), Member = "Find")]
	[Calls(Type = typeof(string), Member = "Split")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	protected void CheckForPromotedVariable(string name)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected override void Bind(Variable variable)
	{
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Variable), Member = "GetGetConverter")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 21)]
	private bool BindGetter(Variable variable)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 27)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Variable), Member = "GetSetConverter")]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	private bool BindSetter(Variable variable)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 13)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	public static implicit operator BBParameter<T>(T value)
	{
		return null;
	}
}
