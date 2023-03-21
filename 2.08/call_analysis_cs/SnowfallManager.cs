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
			return default(float);
		}
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(SnowfallManager), Member = "RegisterRecord")]
	[CalledBy(Type = typeof(SnowPatchManager), Member = "Start")]
	[Calls(Type = typeof(SnowfallManager), Member = "RegisterRecord")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(SnowfallManager), Member = "RegisterRecord")]
	[Calls(Type = typeof(SnowfallManager), Member = "RegisterRecord")]
	[Calls(Type = typeof(SnowfallManager), Member = "RegisterRecord")]
	[Calls(Type = typeof(SnowfallManager), Member = "RegisterRecord")]
	[Calls(Type = typeof(SnowfallManager), Member = "RegisterRecord")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SnowfallManager), Member = "RegisterRecord")]
	public SnowfallManager()
	{
	}

	[CalledBy(Type = typeof(SnowfallManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(SnowfallManager), Member = ".ctor")]
	[CalledBy(Type = typeof(SnowfallManager), Member = ".ctor")]
	[CalledBy(Type = typeof(SnowfallManager), Member = ".ctor")]
	[CalledBy(Type = typeof(SnowfallManager), Member = ".ctor")]
	[CalledBy(Type = typeof(SnowfallManager), Member = ".ctor")]
	[CalledBy(Type = typeof(SnowfallManager), Member = ".ctor")]
	[CalledBy(Type = typeof(SnowfallManager), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 9)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(SnowfallManager), Member = ".ctor")]
	private SnowfallRecord RegisterRecord(string scene, float outOfSceneRateScalar)
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SnowPatchManager), Member = "SerializeGlobal")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	public string Serialize()
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(SnowPatchManager), Member = "DeserializeGlobal")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(SnowfallManager), Member = "RegisterRecord")]
	[Calls(Type = typeof(SnowfallRecord), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void AdjustSnowDepthRecord(float baseDepth)
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public void Update(float snowAdd)
	{
	}
}
