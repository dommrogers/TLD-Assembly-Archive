using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xbox;
using UnityEngine;
using UnityEngine.UI;

public class GameSaveSampleLogic : MonoBehaviour
{
	[Serializable]
	private class PlayerSaveData
	{
		public string name;

		public int level;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public PlayerSaveData()
		{
		}
	}

	public Text output;

	private PlayerSaveData playerSaveData;

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinaryFormatter), Member = ".ctor")]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor")]
	[Calls(Type = typeof(BinaryFormatter), Member = "Serialize")]
	[Calls(Type = typeof(Gdk), Member = "get_Helpers")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 8)]
	public void Save()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Gdk), Member = "get_Helpers")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void Load()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(BinaryFormatter), Member = ".ctor")]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor")]
	[Calls(Type = typeof(BinaryFormatter), Member = "Deserialize")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 6)]
	private void OnGameSaveLoaded(object sender, GameSaveLoadedArgs saveData)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public GameSaveSampleLogic()
	{
	}
}
