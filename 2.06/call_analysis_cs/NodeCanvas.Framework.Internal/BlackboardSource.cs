using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
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

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec__DisplayClass30_0()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Variable), Member = "GetGetConverter")]
		[CallsUnknownMethods(Count = 1)]
		internal bool _003CGetVariableNames_003Eb__0(Variable v)
		{
			return false;
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
		[DeduplicatedMethod]
		[CallerCount(Count = 27)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 53)]
		set
		{
		}
	}

	public Dictionary<string, Variable> variables
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 61)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 38)]
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
		[CalledBy(Type = typeof(Blackboard), Member = "get_Item")]
		[CallerCount(Count = 1)]
		[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
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

	[CalledBy(Type = typeof(Graph), Member = "DeserializeLocalBlackboard")]
	[CalledBy(Type = typeof(Graph), Member = "get_localBlackboard")]
	[CalledBy(Type = typeof(Blackboard), Member = "UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize")]
	[CalledBy(Type = typeof(Blackboard), Member = ".ctor")]
	[CalledBy(Type = typeof(GlobalBlackboard), Member = ".ctor")]
	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	public BlackboardSource()
	{
	}

	[CalledBy(Type = typeof(Graph), Member = "Validate")]
	[CalledBy(Type = typeof(Blackboard), Member = "Awake")]
	[CalledBy(Type = typeof(Blackboard), Member = "Deserialize")]
	[CalledBy(Type = typeof(GlobalBlackboard), Member = "Awake")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Dictionary<, >.ValueCollection.Enumerator), Member = "MoveNext")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 5)]
	public void InitializePropertiesBinding(GameObject targetGO, bool callSetter)
	{
	}

	[CalledBy(Type = typeof(Blackboard), Member = "AddVariable")]
	[CalledBy(Type = typeof(BlackboardSource), Member = "SetValue")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(BlackboardSource), Member = "AddVariable")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	public Variable AddVariable(string varName, object value)
	{
		return null;
	}

	[CalledBy(Type = typeof(Blackboard), Member = "AddVariable")]
	[CalledBy(Type = typeof(BlackboardSource), Member = "AddVariable")]
	[CalledBy(Type = typeof(BlackboardSource), Member = "AddVariable")]
	[CalledBy(Type = typeof(Action_InvokeConcurrentGraph), Member = "OnExecute")]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(BlackboardSource), Member = "GetVariable")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 6)]
	public Variable AddVariable(string varName, Type type)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Dictionary<, >), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public Variable RemoveVariable(string varName)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 9)]
	public T GetValue<T>(string varName)
	{
		return default(T);
	}

	[CalledBy(Type = typeof(BlackboardSpawner), Member = "MaybeCopyBlackboardVariables")]
	[CalledBy(Type = typeof(BehaviourTreeInteraction), Member = "PerformInteraction")]
	[CalledBy(Type = typeof(BlackboardPatch), Member = "ApplyPatch")]
	[CalledBy(Type = typeof(Blackboard), Member = "set_Item")]
	[CalledBy(Type = typeof(Blackboard), Member = "SetValue")]
	[CalledBy(Type = typeof(Blackboard), Member = "Deserialize")]
	[CalledBy(Type = typeof(BlackboardSource), Member = "set_Item")]
	[CalledBy(Type = typeof(TLDSetOtherBlackboardVariable), Member = "OnExecute")]
	[CalledBy(Type = typeof(SetOtherBlackboardVariable), Member = "OnExecute")]
	[CallerCount(Count = 10)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(TypeFullName = "System.ParamsArray", Member = ".ctor")]
	[Calls(Type = typeof(string), Member = "FormatHelper")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(BlackboardSource), Member = "AddVariable")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
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

	[CalledBy(Type = typeof(BlackboardSpawner), Member = "MaybeCopyBlackboardVariables")]
	[CalledBy(Type = typeof(BlackboardPatch), Member = "ApplyPatch")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "GetGlobalVariable")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Serialize")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "MissionCompleted")]
	[CalledBy(Type = typeof(TriggerVolumeSetBBValue), Member = "OnTriggerEnter")]
	[CalledBy(Type = typeof(Blackboard), Member = "GetVariable")]
	[CalledBy(Type = typeof(BlackboardSource), Member = "AddVariable")]
	[CalledBy(Type = typeof(BlackboardSource), Member = "GetVariable")]
	[CalledBy(TypeFullName = "NodeCanvas.DialogueTrees.Statement.<>c__DisplayClass21_0", Member = "<BlackboardReplace>b__0")]
	[CalledBy(Type = typeof(Action_StartSideMission), Member = "OnExecute")]
	[CalledBy(Type = typeof(GetOtherBlackboardVariable), Member = "OnExecute")]
	[CallerCount(Count = 13)]
	[Calls(Type = typeof(Dictionary<, >), Member = "TryGetValue")]
	[Calls(Type = typeof(Variable), Member = "GetGetConverter")]
	[CallsUnknownMethods(Count = 1)]
	public Variable GetVariable(string varName, Type ofType = null)
	{
		return null;
	}

	[CalledBy(Type = typeof(Blackboard), Member = "GetVariableByID")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(TypeFullName = "Interop", Member = "GetRandomBytes")]
	[Calls(Type = typeof(Guid), Member = "ToString")]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 5)]
	public Variable GetVariableByID(string ID)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Enumerable), Member = "ToArray")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public string[] GetVariableNames()
	{
		return null;
	}

	[CalledBy(Type = typeof(Blackboard), Member = "GetVariableNames")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Enumerable), Member = "Where")]
	[Calls(Type = typeof(Enumerable), Member = "Select")]
	[Calls(Type = typeof(Enumerable), Member = "ToArray")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 16)]
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

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(BlackboardSource), Member = "AddVariable")]
	[CallsUnknownMethods(Count = 2)]
	public Variable<T> AddVariable<T>(string varName)
	{
		return null;
	}
}
