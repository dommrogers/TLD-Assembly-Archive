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

		[CallerCount(Count = 263)]
		[DeduplicatedMethod]
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
		[CalledBy(Type = typeof(GlobalBlackboard._003C_003Ec__DisplayClass6_0), Member = "<Find>b__2")]
		[CalledBy(Type = typeof(GlobalBlackboard), Member = "<IsUnique>b__9_0")]
		[CalledBy(Type = typeof(GlobalBlackboard), Member = "Awake")]
		[CalledBy(Type = typeof(GlobalBlackboard), Member = "Awake")]
		[CalledBy(Type = typeof(GlobalBlackboard), Member = "set_name")]
		[CalledBy(Type = typeof(GlobalBlackboard), Member = "get_name")]
		[CalledBy(Type = typeof(GlobalBlackboard._003C_003Ec__DisplayClass6_0), Member = "<Find>b__1")]
		[CalledBy(Type = typeof(GlobalBlackboard._003C_003Ec__DisplayClass6_0), Member = "<Find>b__0")]
		[CalledBy(Type = typeof(Blackboard), Member = "Save")]
		[Calls(Type = typeof(string), Member = "Concat")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 10)]
		[CalledBy(Type = typeof(GlobalBlackboard), Member = "<IsUnique>b__9_0")]
		[CallsUnknownMethods(Count = 2)]
		get
		{
			return null;
		}
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(string), Member = "Concat")]
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
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(BlackboardSource), Member = "SetValue")]
		set
		{
		}
	}

	public Dictionary<string, Variable> variables
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
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
		[CallsUnknownMethods(Count = 1)]
		[DeduplicatedMethod]
		[CallerCount(Count = 1299)]
		get
		{
			return null;
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
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 3)]
		add
		{
		}
		[CallsUnknownMethods(Count = 3)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		remove
		{
		}
	}

	[CallerCount(Count = 6)]
	[DeduplicatedMethod]
	private void UnityEngine_002EISerializationCallbackReceiver_002EOnBeforeSerialize()
	{
	}

	[Calls(Type = typeof(BlackboardSource), Member = ".ctor")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private void UnityEngine_002EISerializationCallbackReceiver_002EOnAfterDeserialize()
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(BlackboardSource), Member = "InitializePropertiesBinding")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void Awake()
	{
	}

	[Calls(Type = typeof(BlackboardSource), Member = "AddVariable")]
	[CalledBy(Type = typeof(BlackboardSpawner), Member = "MaybeCopyBlackboardVariables")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
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
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
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

	[Calls(Type = typeof(Blackboard), Member = "Serialize")]
	[CallerCount(Count = 0)]
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

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Blackboard), Member = "Deserialize")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PlayerPrefs), Member = "GetString")]
	[CalledBy(Type = typeof(LoadBlackboard), Member = "OnExecute")]
	public bool Load(string saveKey)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Blackboard), Member = "ExtractInternalVars")]
	[CallerCount(Count = 0)]
	public void TLD_PreSerialize()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Blackboard), Member = "RestoreInternalVars")]
	public void TLD_PostSerialize()
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "Serialize")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(Blackboard), Member = "Deserialize")]
	[CalledBy(Type = typeof(Blackboard), Member = "TLD_PreSerialize")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetSerializedBlackboard")]
	[CalledBy(Type = typeof(TLDBehaviourTreeManager), Member = "Serialize")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Serialize")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Serialize")]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "Serialize")]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "Serialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(string), Member = "StartsWith")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 9)]
	public void ExtractInternalVars()
	{
	}

	[CalledBy(Type = typeof(TLDBehaviourTreeManager), Member = "Serialize")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetSerializedBlackboard")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Serialize")]
	[CalledBy(Type = typeof(Blackboard), Member = "Deserialize")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Blackboard), Member = "TLD_PostSerialize")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Serialize")]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "Serialize")]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "Serialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Serialize")]
	public void RestoreInternalVars()
	{
	}

	[CalledBy(Type = typeof(MissionServicesManager), Member = "Serialize")]
	[CalledBy(Type = typeof(Blackboard), Member = "Save")]
	[CalledBy(Type = typeof(Blackboard), Member = "Save")]
	[CalledBy(Type = typeof(NCUtils), Member = "GetSerializedBlackboard")]
	[CalledBy(Type = typeof(TLDBehaviourTreeManager), Member = "Serialize")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Serialize")]
	[CalledBy(Type = typeof(SaveBlackboard), Member = "OnExecute")]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "Serialize")]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "Serialize")]
	[CalledBy(Type = typeof(GameManager), Member = "SetupTransferData")]
	[Calls(Type = typeof(JSONSerializer), Member = "Serialize")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallerCount(Count = 11)]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Serialize")]
	public string Serialize()
	{
		return null;
	}

	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(JSONSerializer), Member = "Serialize")]
	[CallerCount(Count = 0)]
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

	[CalledBy(Type = typeof(Blackboard), Member = "Deserialize")]
	[CalledBy(Type = typeof(Blackboard), Member = "Load")]
	[CalledBy(Type = typeof(TLDBehaviourTreeManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "DeserializeGlobalBB")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "RegisterConcurrentGraph")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "RegisterConcurrentGraph")]
	[CalledBy(Type = typeof(MissionServicesManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(MissionServicesManager._003CJumpCo_003Ed__130), Member = "MoveNext")]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "PreRegisterChildGraph")]
	[CalledBy(Type = typeof(MissionManagerBase), Member = "PreRegisterGraphOwner")]
	[CalledBy(Type = typeof(GameManager), Member = "ApplyTransferData")]
	[CalledBy(Type = typeof(GameManager), Member = "InstantiateStoryManager")]
	[Calls(Type = typeof(Blackboard), Member = "RestoreInternalVars")]
	[Calls(Type = typeof(BlackboardSource), Member = "InitializePropertiesBinding")]
	[Calls(Type = typeof(BlackboardSource), Member = "SetValue")]
	[Calls(Type = typeof(Blackboard), Member = "ExtractInternalVars")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 12)]
	[CallsUnknownMethods(Count = 16)]
	public bool Deserialize(string json, List<UnityEngine.Object> storedObjectReferences, bool removeMissing = true)
	{
		return default(bool);
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(BlackboardSource), Member = ".ctor")]
	[CallerCount(Count = 0)]
	public Blackboard()
	{
	}
}
