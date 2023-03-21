using System;
using System.Collections.Generic;
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
		[CallerCount(Count = 29)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 71)]
		set
		{
		}
	}

	public Variable varRef
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 12)]
		get
		{
			return null;
		}
		[CallerCount(Count = 90)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public IBlackboard bb
	{
		[CallerCount(Count = 5)]
		[DeduplicatedMethod]
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
		[CallerCount(Count = 52)]
		get
		{
			return null;
		}
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		[Calls(Type = typeof(BBParameter), Member = "ResolveReference")]
		[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
		[CalledBy(Type = typeof(BBParameter), Member = "set_useBlackboard")]
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
		[Calls(Type = typeof(BBParameter), Member = "set_name")]
		[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public bool isNone
	{
		[CallerCount(Count = 88)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(string), Member = "EqualsHelper")]
		get
		{
			return default(bool);
		}
	}

	public bool isDefined
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
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
		[CalledBy(Type = typeof(Action_TrackStat), Member = "OnIncrementStat")]
		[CalledBy(Type = typeof(Action_NPCSetFreezing), Member = "OnExecute")]
		[CalledBy(Type = typeof(Action_NPCSetCondition), Member = "OnExecute")]
		[CalledBy(Type = typeof(Action_NPCEnableConditionUpdate), Member = "OnExecute")]
		[CalledBy(Type = typeof(Condition_CheckContainerPowder), Member = "OnCheck")]
		[CalledBy(Type = typeof(Condition_CheckContainerPowder), Member = "get_info")]
		[CalledBy(Type = typeof(Condition_CheckContainerLiquid), Member = "get_info")]
		[CalledBy(Type = typeof(TLD_GearInsideTrigger), Member = "OnCheck")]
		[CalledBy(Type = typeof(TLD_GearInsideTrigger), Member = "get_info")]
		[CalledBy(Type = typeof(BBParameter), Member = "ToString")]
		[CalledBy(Type = typeof(Task), Member = "Internal_GetWarning")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 15)]
		[CalledBy(Type = typeof(Condition_CheckContainerLiquid), Member = "OnCheck")]
		get
		{
			return default(bool);
		}
	}

	public Type refType
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public object value
	{
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 26)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	protected abstract object objectValue
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		get;
		[DeduplicatedMethod]
		[CallerCount(Count = 121780)]
		set;
	}

	public abstract Type varType
	{
		[CallerCount(Count = 121780)]
		[DeduplicatedMethod]
		get;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	public BBParameter()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(CheckProperty), Member = "SetMethod")]
	[Calls(Type = typeof(BBParameter), Member = "set_bb")]
	[CalledBy(Type = typeof(CheckFunction), Member = "SetMethod")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	public static BBParameter CreateInstance(Type t, IBlackboard bb)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 5)]
	public static void ResetVariableNamesCache()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(ReflectedFunctionWrapper), Member = "Create")]
	[CalledBy(Type = typeof(ReflectedActionWrapper), Member = "Create")]
	[CalledBy(Type = typeof(Task), Member = "Set")]
	[CalledBy(Type = typeof(Task), Member = "set_blackboard")]
	[CalledBy(Type = typeof(Task), Member = "Duplicate")]
	[CalledBy(Type = typeof(Task), Member = "Create")]
	[CalledBy(Type = typeof(Node), Member = "Duplicate")]
	[CalledBy(Type = typeof(Graph), Member = "UpdateNodeBBFields")]
	[CalledBy(Type = typeof(Graph), Member = "UpdateReferences")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(BBParameter), Member = "set_bb")]
	[Calls(Type = typeof(BBParameter), Member = "GetObjectBBParameters")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(Node), Member = "Create")]
	public static void SetBBFields(object o, IBlackboard bb)
	{
	}

	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[CallsUnknownMethods(Count = 35)]
	[CalledBy(Type = typeof(BBParameter), Member = "SetBBFields")]
	[CalledBy(Type = typeof(Graph), Member = "GetTaskAndParametersStructureInTarget")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ReflectionTools), Member = "RTGetFields")]
	[CallsDeduplicatedMethods(Count = 23)]
	[CallerCount(Count = 2)]
	public static List<BBParameter> GetObjectBBParameters(object o)
	{
		return null;
	}

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	protected abstract void Bind(Variable data);

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(GlobalBlackboard), Member = "Find")]
	[CalledBy(Type = typeof(BBParameter), Member = "set_bb")]
	[CalledBy(Type = typeof(BBParameter), Member = "set_name")]
	[CallsUnknownMethods(Count = 10)]
	private Variable ResolveReference(IBlackboard targetBlackboard, bool useID)
	{
		return null;
	}

	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[CallsUnknownMethods(Count = 12)]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogError")]
	[Calls(Type = typeof(ParadoxNotion.Services.Logger), Member = "LogError")]
	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[Calls(Type = typeof(GlobalBlackboard), Member = "Find")]
	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 83)]
	public Variable PromoteToVariable(IBlackboard targetBB)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[Calls(Type = typeof(StringUtils), Member = "ToStringAdvanced")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(BBParameter), Member = "get_isNone")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BBParameter), Member = "get_isNull")]
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
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public _003C_003Ec__DisplayClass15_0()
		{
		}

		[CallsUnknownMethods(Count = 4)]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
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
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		public _003C_003Ec__DisplayClass16_0()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 2)]
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
		[CallsDeduplicatedMethods(Count = 2)]
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
		[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[CallerCount(Count = 36)]
		[DeduplicatedMethod]
		[CallsDeduplicatedMethods(Count = 4)]
		get
		{
			return (T)null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 3)]
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
		[CallsUnknownMethods(Count = 2)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 3)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public override Type varType
	{
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[DeduplicatedMethod]
	public BBParameter()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public BBParameter(T value)
	{
	}

	[Calls(Type = typeof(string), Member = "SplitInternal")]
	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(BBParameter), Member = "set_varRef")]
	[Calls(Type = typeof(GlobalBlackboard), Member = "Find")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[Calls(Type = typeof(string), Member = "IndexOf")]
	protected void CheckForPromotedVariable(string name)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected override void Bind(Variable variable)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Variable), Member = "GetGetConverter")]
	[CallsUnknownMethods(Count = 30)]
	private bool BindGetter(Variable variable)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Variable), Member = "GetSetConverter")]
	[CallsUnknownMethods(Count = 39)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	[CallsDeduplicatedMethods(Count = 5)]
	private bool BindSetter(Variable variable)
	{
		return default(bool);
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 7)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 14)]
	public static implicit operator BBParameter<T>(T value)
	{
		return null;
	}
}
