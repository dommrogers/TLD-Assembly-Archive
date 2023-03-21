using System;
using System.Collections.Generic;
using System.Linq;
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

		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Variable), Member = "GetGetConverter")]
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
		[DeduplicatedMethod]
		[CallerCount(Count = 27)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 55)]
		set
		{
		}
	}

	public Dictionary<string, Variable> variables
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 25)]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 40)]
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
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 3)]
		remove
		{
		}
	}

	public event Action<Variable> onVariableRemoved
	{
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 3)]
		remove
		{
		}
	}

	[CalledBy(Type = typeof(GlobalBlackboard), Member = ".ctor")]
	[CalledBy(Type = typeof(Blackboard), Member = ".ctor")]
	[CalledBy(Type = typeof(Blackboard), Member = "UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(Graph), Member = "DeserializeLocalBlackboard")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 5)]
	[CalledBy(Type = typeof(Graph), Member = "get_localBlackboard")]
	public BlackboardSource()
	{
	}

	[CallerCount(Count = 4)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CalledBy(Type = typeof(Graph), Member = "Validate")]
	[CalledBy(Type = typeof(Blackboard), Member = "Awake")]
	[CalledBy(Type = typeof(Blackboard), Member = "Deserialize")]
	[CalledBy(Type = typeof(GlobalBlackboard), Member = "Awake")]
	[CallsUnknownMethods(Count = 8)]
	public void InitializePropertiesBinding(GameObject targetGO, bool callSetter)
	{
	}

	[CalledBy(Type = typeof(BlackboardSource), Member = "SetValue")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BlackboardSource), Member = "AddVariable")]
	public Variable AddVariable(string varName, object value)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Action_InvokeConcurrentGraph), Member = "OnExecute")]
	[CalledBy(Type = typeof(BlackboardSource), Member = "AddVariable")]
	[CalledBy(Type = typeof(BlackboardSource), Member = "AddVariable")]
	[CalledBy(Type = typeof(Blackboard), Member = "AddVariable")]
	[CalledBy(Type = typeof(Blackboard), Member = "AddVariable")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(BlackboardSource), Member = "GetVariable")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Activator), Member = "CreateInstance")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(string), Member = "Format")]
	public Variable AddVariable(string varName, Type type)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public Variable RemoveVariable(string varName)
	{
		return null;
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CallsUnknownMethods(Count = 8)]
	public T GetValue<T>(string varName)
	{
		return (T)null;
	}

	[CalledBy(Type = typeof(Blackboard), Member = "set_Item")]
	[CalledBy(Type = typeof(Blackboard), Member = "SetValue")]
	[CalledBy(Type = typeof(Blackboard), Member = "Deserialize")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CalledBy(Type = typeof(TLDSetOtherBlackboardVariable), Member = "OnExecute")]
	[CalledBy(Type = typeof(SetOtherBlackboardVariable), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(BlackboardPatch), Member = "ApplyPatch")]
	[CalledBy(Type = typeof(BlackboardSource), Member = "set_Item")]
	[CalledBy(Type = typeof(BlackboardPatch), Member = "ApplyPatch")]
	[Calls(Type = typeof(string), Member = "Format")]
	[CalledBy(Type = typeof(BlackboardSpawner), Member = "MaybeCopyBlackboardVariables")]
	[Calls(Type = typeof(BlackboardSource), Member = "AddVariable")]
	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Format")]
	[Calls(Type = typeof(ReflectionTools), Member = "FriendlyName")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 10)]
	[CalledBy(Type = typeof(BehaviourTreeInteraction), Member = "PerformInteraction")]
	public Variable SetValue(string varName, object value)
	{
		return null;
	}

	[Calls(Type = typeof(BlackboardSource), Member = "GetVariable")]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsUnknownMethods(Count = 2)]
	public Variable<T> GetVariable<T>(string varName)
	{
		return null;
	}

	[CalledBy(Type = typeof(BlackboardSource), Member = "GetVariable")]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(BlackboardSource), Member = "AddVariable")]
	[CalledBy(Type = typeof(Statement._003C_003Ec__DisplayClass21_0), Member = "<BlackboardReplace>b__0")]
	[Calls(Type = typeof(Variable), Member = "GetGetConverter")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(Blackboard), Member = "GetVariable")]
	[CallerCount(Count = 4)]
	public Variable GetVariable(string varName, Type ofType = null)
	{
		return null;
	}

	[CalledBy(Type = typeof(Blackboard), Member = "GetVariableByID")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Interop), Member = "GetRandomBytes")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Guid), Member = "ToString")]
	public Variable GetVariableByID(string ID)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CallsUnknownMethods(Count = 6)]
	public string[] GetVariableNames()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 8)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CalledBy(Type = typeof(Blackboard), Member = "GetVariableNames")]
	public string[] GetVariableNames(Type ofType)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
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
