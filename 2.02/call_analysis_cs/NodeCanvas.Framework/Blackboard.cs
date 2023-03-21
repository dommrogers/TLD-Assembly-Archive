using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using NodeCanvas.Framework.Internal;
using NodeCanvas.Tasks.Actions;
using ParadoxNotion.Serialization;
using UnityEngine;

namespace NodeCanvas.Framework;

public class Blackboard : MonoBehaviour, ISerializationCallbackReceiver, IBlackboard
{
	private class BBKeyVar
	{
		public string key;

		public Variable variable;

		[DeduplicatedMethod]
		[CallerCount(Count = 83)]
		public BBKeyVar(string _key, Variable _variable)
		{
		}
	}

	private string _serializedBlackboard;

	private List<UnityEngine.Object> _objectReferences;

	[NonSerialized]
	private BlackboardSource _blackboard;

	[NonSerialized]
	private bool hasDeserialized;

	private static List<BBKeyVar> internalVarsTempList;

	public new string name
	{
		[CalledBy(Type = typeof(GlobalBlackboard), Member = "<IsUnique>b__9_0")]
		[CalledBy(Type = typeof(GlobalBlackboard), Member = "<IsUnique>b__9_0")]
		[CalledBy(Type = typeof(GlobalBlackboard), Member = "Awake")]
		[CalledBy(Type = typeof(GlobalBlackboard._003C_003Ec__DisplayClass6_0), Member = "<Find>b__1")]
		[CallsUnknownMethods(Count = 4)]
		[CalledBy(Type = typeof(GlobalBlackboard._003C_003Ec__DisplayClass6_0), Member = "<Find>b__0")]
		[CalledBy(Type = typeof(GlobalBlackboard), Member = "Awake")]
		[CalledBy(Type = typeof(GlobalBlackboard._003C_003Ec__DisplayClass6_0), Member = "<Find>b__2")]
		[CalledBy(Type = typeof(GlobalBlackboard), Member = "get_name")]
		[CalledBy(Type = typeof(Blackboard), Member = "Save")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CalledBy(Type = typeof(GlobalBlackboard), Member = "set_name")]
		[CallerCount(Count = 10)]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(string), Member = "Concat")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		set
		{
		}
	}

	public object Item
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BlackboardSource), Member = "get_Item")]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(BlackboardSource), Member = "SetValue")]
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		set
		{
		}
	}

	public Dictionary<string, Variable> variables
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public GameObject propertiesBindTarget
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 1542)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return null;
		}
	}

	public event Action<Variable> onVariableAdded
	{
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CompilerGenerated]
		[CallsDeduplicatedMethods(Count = 1)]
		remove
		{
		}
	}

	public event Action<Variable> onVariableRemoved
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		remove
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 2)]
	private void UnityEngine_002EISerializationCallbackReceiver_002EOnBeforeSerialize()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BlackboardSource), Member = ".ctor")]
	[CallsUnknownMethods(Count = 9)]
	private void UnityEngine_002EISerializationCallbackReceiver_002EOnAfterDeserialize()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BlackboardSource), Member = "InitializePropertiesBinding")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	protected virtual void Awake()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(BlackboardSource), Member = "AddVariable")]
	[CalledBy(Type = typeof(BlackboardSpawner), Member = "MaybeCopyBlackboardVariables")]
	[CalledBy(Type = typeof(Action_InvokeConcurrentGraph), Member = "OnExecute")]
	[CallsUnknownMethods(Count = 1)]
	public Variable AddVariable(string name, Type type)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BlackboardSource), Member = "AddVariable")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public Variable AddVariable(string name, object value)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallsUnknownMethods(Count = 3)]
	public Variable RemoveVariable(string name)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BlackboardSource), Member = "GetVariable")]
	[CallsUnknownMethods(Count = 1)]
	public Variable GetVariable(string name, Type ofType = null)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BlackboardSource), Member = "GetVariableByID")]
	[CallsUnknownMethods(Count = 1)]
	public Variable GetVariableByID(string ID)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public Variable<T> GetVariable<T>(string name)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public T GetValue<T>(string name)
	{
		return (T)null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BlackboardSource), Member = "SetValue")]
	[CallsUnknownMethods(Count = 1)]
	public Variable SetValue(string name, object value)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	public string[] GetVariableNames()
	{
		return null;
	}

	[Calls(Type = typeof(BlackboardSource), Member = "GetVariableNames")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public string[] GetVariableNames(Type ofType)
	{
		return null;
	}

	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[Calls(Type = typeof(Blackboard), Member = "Serialize")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Blackboard), Member = "get_name")]
	public string Save()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Blackboard), Member = "Serialize")]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	public string Save(string saveKey)
	{
		return null;
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public bool Load()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	[Calls(Type = typeof(Blackboard), Member = "Deserialize")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CalledBy(Type = typeof(LoadBlackboard), Member = "OnExecute")]
	public bool Load(string saveKey)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Blackboard), Member = "ExtractInternalVars")]
	public void TLD_PreSerialize()
	{
	}

	[Calls(Type = typeof(Blackboard), Member = "RestoreInternalVars")]
	[CallerCount(Count = 0)]
	public void TLD_PostSerialize()
	{
	}

	[CallerCount(Count = 5)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "Serialize")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Serialize")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetSerializedBlackboard")]
	[CalledBy(Type = typeof(Blackboard), Member = "TLD_PreSerialize")]
	[CalledBy(Type = typeof(Blackboard), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 23)]
	public void ExtractInternalVars()
	{
	}

	[CalledBy(Type = typeof(Blackboard), Member = "TLD_PostSerialize")]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "Serialize")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Blackboard), Member = "Deserialize")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetSerializedBlackboard")]
	[CallerCount(Count = 5)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Serialize")]
	public void RestoreInternalVars()
	{
	}

	[CalledBy(Type = typeof(SaveBlackboard), Member = "OnExecute")]
	[CalledBy(Type = typeof(Blackboard), Member = "Save")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetSerializedBlackboard")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Serialize")]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "Serialize")]
	[CalledBy(Type = typeof(Blackboard), Member = "Save")]
	[Calls(Type = typeof(JSONSerializer), Member = "Serialize")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 7)]
	[CalledBy(Type = typeof(GameManager), Member = "SetupTransferData")]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(JSONSerializer), Member = "Serialize")]
	public string Serialize(List<UnityEngine.Object> storedObjectReferences)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Blackboard), Member = "Deserialize")]
	public bool Deserialize(string json)
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "DeserializeGlobalBB")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "RegisterConcurrentGraph")]
	[CalledBy(Type = typeof(MissionServicesManager._003CJumpCo_003Ed__136), Member = "MoveNext")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "RegisterConcurrentGraph")]
	[CalledBy(Type = typeof(Blackboard), Member = "Load")]
	[CallsUnknownMethods(Count = 25)]
	[CalledBy(Type = typeof(Blackboard), Member = "Deserialize")]
	[CalledBy(Type = typeof(TLDBehaviourTreeManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 12)]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "PreRegisterGraphOwner")]
	[CalledBy(Type = typeof(GameManager), Member = "ApplyTransferData")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateStoryManager")]
	[Calls(Type = typeof(Blackboard), Member = "RestoreInternalVars")]
	[Calls(Type = typeof(BlackboardSource), Member = "InitializePropertiesBinding")]
	[Calls(Type = typeof(BlackboardSource), Member = "SetValue")]
	[Calls(Type = typeof(Blackboard), Member = "ExtractInternalVars")]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "PreRegisterChildGraph")]
	public bool Deserialize(string json, List<UnityEngine.Object> storedObjectReferences, bool removeMissing = true)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(GlobalBlackboard), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(BlackboardSource), Member = ".ctor")]
	public Blackboard()
	{
	}
}
