using System;
using Cpp2ILInjected.CallAnalysis;
using DigitalOpus.MB.Core;
using UnityEngine;

public class MB3_BatchPrefabBaker : MonoBehaviour
{
	[Serializable]
	public class MB3_PrefabBakerRow
	{
		public GameObject sourcePrefab;

		public GameObject resultPrefab;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public MB3_PrefabBakerRow()
		{
		}
	}

	public MB2_LogLevel LOG_LEVEL;

	public MB3_PrefabBakerRow[] prefabRows;

	public string outputPrefabFolder;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public MB3_BatchPrefabBaker()
	{
	}
}
