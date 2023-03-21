using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.DialogueTrees;
using NodeCanvas.Tasks.Actions;
using ParadoxNotion;
using UnityEngine;

namespace NodeCanvas.Framework.Internal;

[Serializable]
public sealed class BlackboardSource : IBlackboard
{
	private sealed class _003C_003Ec__DisplayClass30_0
	{
		public Type ofType;

		[CallerCount(Count = 6)]
		[DeduplicatedMethod]
		public _003C_003Ec__DisplayClass30_0()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Variable), Member = "GetGetConverter")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CGetVariableNames_003Eb__0(Variable v)
		{
			return default(bool);
		}
	}

	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<Variable, string> _003C_003E9__30_1;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		internal string _003CGetVariableNames_003Eb__30_1(Variable v)
		{
			return null;
		}
	}

	private string _name;

	private Dictionary<string, Variable> _variables;

	public string name
	{
		[CallerCount(Count = 23)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 51)]
		set
		{
		}
	}

	public Dictionary<string, Variable> variables
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 58)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 36)]
		set
		{
		}
	}

	public GameObject propertiesBindTarget
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return null;
		}
	}

	public object Item
	{
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(Blackboard), Member = "get_Item")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BlackboardSource), Member = "SetValue")]
		set
		{
		}
	}

	public event Action<Variable> onVariableAdded
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CompilerGenerated]
		[CallsUnknownMethods(Count = 2)]
		add
		{
		}
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		remove
		{
		}
	}

	public event Action<Variable> onVariableRemoved
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 2)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 2)]
		remove
		{
		}
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Blackboard), Member = ".ctor")]
	[CalledBy(Type = typeof(Blackboard), Member = "UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize")]
	[CalledBy(Type = typeof(GlobalBlackboard), Member = ".ctor")]
	[CalledBy(Type = typeof(Graph), Member = "DeserializeLocalBlackboard")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Graph), Member = "get_localBlackboard")]
	public BlackboardSource()
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Graph), Member = "Validate")]
	[CalledBy(Type = typeof(Blackboard), Member = "Awake")]
	[CalledBy(Type = typeof(Blackboard), Member = "Deserialize")]
	[CalledBy(Type = typeof(GlobalBlackboard), Member = "Awake")]
	[CallsUnknownMethods(Count = 5)]
	public void InitializePropertiesBinding(GameObject targetGO, bool callSetter)
	{
	}

	[CalledBy(Type = typeof(BlackboardSource), Member = "SetValue")]
	[CalledBy(Type = typeof(Blackboard), Member = "AddVariable")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(BlackboardSource), Member = "AddVariable")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	public Variable AddVariable(string varName, object value)
	{
		return null;
	}

	[CalledBy(Type = typeof(BlackboardSource), Member = "AddVariable")]
	[CalledBy(Type = typeof(BlackboardSource), Member = "AddVariable")]
	[CalledBy(Type = typeof(Blackboard), Member = "AddVariable")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(BlackboardSource), Member = "GetVariable")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 4)]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Action_InvokeConcurrentGraph), Member = "OnExecute")]
	public Variable AddVariable(string varName, Type type)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public Variable RemoveVariable(string varName)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsUnknownMethods(Count = 9)]
	public T GetValue<T>(string varName)
	{
		return (T)null;
	}

	[CalledBy(Type = typeof(Blackboard), Member = "set_Item")]
	[CalledBy(Type = typeof(BlackboardPatch), Member = "ApplyPatch")]
	[CalledBy(Type = typeof(BlackboardPatch), Member = "ApplyPatch")]
	[CalledBy(Type = typeof(Blackboard), Member = "SetValue")]
	[CalledBy(Type = typeof(BehaviourTreeInteraction), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(BlackboardSource), Member = "set_Item")]
	[CalledBy(Type = typeof(SetOtherBlackboardVariable), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Blackboard), Member = "Deserialize")]
	[CalledBy(Type = typeof(BlackboardSpawner), Member = "MaybeCopyBlackboardVariables")]
	[CalledBy(Type = typeof(TLDSetOtherBlackboardVariable), Member = "OnExecute")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallerCount(Count = 10)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(BlackboardSource), Member = "AddVariable")]
	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[Calls(Type = typeof(System.ParamsArray), Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	public Variable SetValue(string varName, object value)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(BlackboardSource), Member = "GetVariable")]
	[CallsUnknownMethods(Count = 2)]
	public Variable<T> GetVariable<T>(string varName)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(GetOtherBlackboardVariable), Member = "OnExecute")]
	[CalledBy(Type = typeof(Action_StartSideMission), Member = "OnExecute")]
	[CalledBy(Type = typeof(BlackboardSource), Member = "GetVariable")]
	[CalledBy(Type = typeof(BlackboardSource), Member = "AddVariable")]
	[CalledBy(Type = typeof(TriggerVolumeSetBBValue), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(TriggerVolumeSetBBValue), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(Statement._003C_003Ec__DisplayClass21_0), Member = "<BlackboardReplace>b__0")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Serialize")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "MissionCompleted")]
	[CallerCount(Count = 13)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Variable), Member = "GetGetConverter")]
	[CalledBy(Type = typeof(Blackboard), Member = "GetVariable")]
	[CalledBy(Type = typeof(BlackboardPatch), Member = "ApplyPatch")]
	[CalledBy(Type = typeof(BlackboardSpawner), Member = "MaybeCopyBlackboardVariables")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetGlobalVariable")]
	public Variable GetVariable(string varName, Type ofType = null)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(Blackboard), Member = "GetVariableByID")]
	[Calls(Type = typeof(Interop), Member = "GetRandomBytes")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Guid), Member = "ToString")]
	public Variable GetVariableByID(string ID)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	public string[] GetVariableNames()
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(Blackboard), Member = "GetVariableNames")]
	[CallsUnknownMethods(Count = 19)]
	public string[] GetVariableNames(Type ofType)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public Variable<T> AddVariable<T>(string varName, T value)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BlackboardSource), Member = "AddVariable")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public Variable<T> AddVariable<T>(string varName)
	{
		return null;
	}
}
