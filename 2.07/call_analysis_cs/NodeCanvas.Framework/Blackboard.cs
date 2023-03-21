using System;
using System.Collections.Generic;
using System.Linq;
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
		[CallerCount(Count = 263)]
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
		[CallsUnknownMethods(Count = 2)]
		[CalledBy(Type = typeof(GlobalBlackboard), Member = "<IsUnique>b__9_0")]
		[CalledBy(Type = typeof(GlobalBlackboard), Member = "<IsUnique>b__9_0")]
		[CalledBy(Type = typeof(GlobalBlackboard), Member = "Awake")]
		[CalledBy(Type = typeof(GlobalBlackboard), Member = "set_name")]
		[CalledBy(Type = typeof(GlobalBlackboard), Member = "get_name")]
		[CalledBy(Type = typeof(GlobalBlackboard._003C_003Ec__DisplayClass6_0), Member = "<Find>b__2")]
		[CalledBy(Type = typeof(GlobalBlackboard), Member = "Awake")]
		[CalledBy(Type = typeof(GlobalBlackboard._003C_003Ec__DisplayClass6_0), Member = "<Find>b__0")]
		[CalledBy(Type = typeof(Blackboard), Member = "Save")]
		[CalledBy(Type = typeof(GlobalBlackboard._003C_003Ec__DisplayClass6_0), Member = "<Find>b__1")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 10)]
		get
		{
			return null;
		}
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
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
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BlackboardSource), Member = "SetValue")]
		[CallsUnknownMethods(Count = 1)]
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
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public GameObject propertiesBindTarget
	{
		[CallerCount(Count = 1299)]
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
	}

	public event Action<Variable> onVariableAdded
	{
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 3)]
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
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 3)]
		add
		{
		}
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		remove
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	private void UnityEngine_002EISerializationCallbackReceiver_002EOnBeforeSerialize()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BlackboardSource), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	private void UnityEngine_002EISerializationCallbackReceiver_002EOnAfterDeserialize()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BlackboardSource), Member = "InitializePropertiesBinding")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	protected virtual void Awake()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BlackboardSource), Member = "AddVariable")]
	[CalledBy(Type = typeof(BlackboardSpawner), Member = "MaybeCopyBlackboardVariables")]
	[CallsUnknownMethods(Count = 1)]
	public Variable AddVariable(string name, Type type)
	{
		return null;
	}

	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(BlackboardSource), Member = "AddVariable")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	public Variable AddVariable(string name, object value)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BlackboardSource), Member = "GetVariableByID")]
	public Variable GetVariableByID(string ID)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[DeduplicatedMethod]
	public Variable<T> GetVariable<T>(string name)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
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

	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(System.Linq.Error), Member = "ArgumentNull")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public string[] GetVariableNames()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BlackboardSource), Member = "GetVariableNames")]
	[CallsUnknownMethods(Count = 1)]
	public string[] GetVariableNames(Type ofType)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Blackboard), Member = "get_name")]
	[Calls(Type = typeof(Blackboard), Member = "Serialize")]
	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	public string Save()
	{
		return null;
	}

	[Calls(Type = typeof(PlayerPrefs), Member = "SetString")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Blackboard), Member = "Serialize")]
	public string Save(string saveKey)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public bool Load()
	{
		return default(bool);
	}

	[CallerCount(Count = 1)]
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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Blackboard), Member = "RestoreInternalVars")]
	public void TLD_PostSerialize()
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Blackboard), Member = "Deserialize")]
	[CalledBy(Type = typeof(Blackboard), Member = "TLD_PreSerialize")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetSerializedBlackboard")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Serialize")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Serialize")]
	[CalledBy(Type = typeof(TLDBehaviourTreeManager), Member = "Serialize")]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "Serialize")]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "Serialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Serialize")]
	public void ExtractInternalVars()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Blackboard), Member = "Deserialize")]
	[CalledBy(Type = typeof(Blackboard), Member = "TLD_PostSerialize")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetSerializedBlackboard")]
	[CalledBy(Type = typeof(TLDBehaviourTreeManager), Member = "Serialize")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Serialize")]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "Serialize")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Serialize")]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "Serialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Serialize")]
	public void RestoreInternalVars()
	{
	}

	[CalledBy(Type = typeof(TLDBehaviourTreeManager), Member = "Serialize")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetSerializedBlackboard")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Serialize")]
	[CalledBy(Type = typeof(Blackboard), Member = "Save")]
	[CalledBy(Type = typeof(SaveBlackboard), Member = "OnExecute")]
	[CalledBy(Type = typeof(Blackboard), Member = "Save")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Serialize")]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "Serialize")]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "Serialize")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Serialize")]
	[CalledBy(Type = typeof(GameManager), Member = "SetupTransferData")]
	[Calls(Type = typeof(JSONSerializer), Member = "Serialize")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 11)]
	public string Serialize()
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(JSONSerializer), Member = "Serialize")]
	public string Serialize(List<UnityEngine.Object> storedObjectReferences)
	{
		return null;
	}

	[Calls(Type = typeof(Blackboard), Member = "Deserialize")]
	[CallerCount(Count = 0)]
	public bool Deserialize(string json)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(Blackboard), Member = "Deserialize")]
	[CalledBy(Type = typeof(Blackboard), Member = "Load")]
	[CalledBy(Type = typeof(TLDBehaviourTreeManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "DeserializeGlobalBB")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "RegisterConcurrentGraph")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "RegisterConcurrentGraph")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(MissionServicesManager._003CJumpCo_003Ed__130), Member = "MoveNext")]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "PreRegisterGraphOwner")]
	[CalledBy(Type = typeof(GameManager), Member = "ApplyTransferData")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateStoryManager")]
	[Calls(Type = typeof(Blackboard), Member = "RestoreInternalVars")]
	[Calls(Type = typeof(BlackboardSource), Member = "InitializePropertiesBinding")]
	[Calls(Type = typeof(BlackboardSource), Member = "SetValue")]
	[Calls(Type = typeof(Blackboard), Member = "ExtractInternalVars")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 12)]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "PreRegisterChildGraph")]
	public bool Deserialize(string json, List<UnityEngine.Object> storedObjectReferences, bool removeMissing = true)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BlackboardSource), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	public Blackboard()
	{
	}
}
