using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using UnityEngine.SceneManagement;

public class SnowfallManager
{
	private static SnowfallManagerSaveDataProxy m_SnowfallManagerSaveDataProxy;

	private Dictionary<string, SnowfallRecord> m_SnowfallRecords;

	private SnowfallRecord m_LocalSceneRecord;

	public float LocalSnowDepth
	{
		[CallerCount(Count = 0)]
		get
		{
			return 0f;
		}
	}

	[CalledBy(Type = typeof(SnowPatchManager), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SnowfallManager), Member = "RegisterRecord")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 7)]
	public SnowfallManager()
	{
	}

	[CalledBy(Type = typeof(SnowfallManager), Member = ".ctor")]
	[CalledBy(Type = typeof(SnowfallManager), Member = "Deserialize")]
	[CallerCount(Count = 9)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private SnowfallRecord RegisterRecord(string scene, float outOfSceneRateScalar)
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CalledBy(Type = typeof(SnowPatchManager), Member = "SerializeGlobal")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CalledBy(Type = typeof(SnowPatchManager), Member = "DeserializeGlobal")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(SnowfallManager), Member = "RegisterRecord")]
	[Calls(Type = typeof(Dictionary<, >), Member = "get_Item")]
	[Calls(Type = typeof(SnowfallRecord), Member = "Deserialize")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void AdjustSnowDepthRecord(float baseDepth)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Dictionary<, >.Enumerator), Member = "MoveNext")]
	[CallsUnknownMethods(Count = 1)]
	public void Update(float snowAdd)
	{
	}
}
