using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;
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

	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(SnowPatchManager), Member = "Start")]
	[Calls(Type = typeof(SnowfallManager), Member = "RegisterRecord")]
	[Calls(Type = typeof(UnityEngine.SceneManagement.SceneManager), Member = "GetActiveScene")]
	[Calls(Type = typeof(SnowfallManager), Member = "RegisterRecord")]
	[Calls(Type = typeof(SnowfallManager), Member = "RegisterRecord")]
	[Calls(Type = typeof(SnowfallManager), Member = "RegisterRecord")]
	[Calls(Type = typeof(SnowfallManager), Member = "RegisterRecord")]
	[Calls(Type = typeof(SnowfallManager), Member = "RegisterRecord")]
	[Calls(Type = typeof(SnowfallManager), Member = "RegisterRecord")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SnowfallManager), Member = "RegisterRecord")]
	public SnowfallManager()
	{
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(SnowfallManager), Member = ".ctor")]
	[CalledBy(Type = typeof(SnowfallManager), Member = ".ctor")]
	[CalledBy(Type = typeof(SnowfallManager), Member = ".ctor")]
	[CalledBy(Type = typeof(SnowfallManager), Member = ".ctor")]
	[CalledBy(Type = typeof(SnowfallManager), Member = "Deserialize")]
	[CalledBy(Type = typeof(SnowfallManager), Member = ".ctor")]
	[CalledBy(Type = typeof(SnowfallManager), Member = ".ctor")]
	[CalledBy(Type = typeof(SnowfallManager), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 9)]
	[CalledBy(Type = typeof(SnowfallManager), Member = ".ctor")]
	private SnowfallRecord RegisterRecord(string scene, float outOfSceneRateScalar)
	{
		return null;
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveGlobalData")]
	[CalledBy(Type = typeof(SnowPatchManager), Member = "SerializeGlobal")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SnowfallRecord), Member = "Serialize")]
	public string Serialize()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 10)]
	[CalledBy(Type = typeof(SnowPatchManager), Member = "DeserializeGlobal")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "RestoreGlobalData")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(SnowfallRecord), Member = "Deserialize")]
	[Calls(Type = typeof(SnowfallManager), Member = "RegisterRecord")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	public void Deserialize(string text)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	public void AdjustSnowDepthRecord(float baseDepth)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(SnowPatchManager), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	public void Update(float snowAdd)
	{
	}
}
