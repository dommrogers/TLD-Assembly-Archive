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
	[CallsUnknownMethods(Count = 6)]
	private void Start()
	{
	}

	[Calls(Type = typeof(Gdk), Member = "get_Helpers")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(BinaryFormatter), Member = "Serialize")]
	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(BinaryFormatter), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor")]
	public void Save()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Gdk), Member = "get_Helpers")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(Gdk), Member = "get_Helpers")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Gdk), Member = "get_Helpers")]
	[CallsUnknownMethods(Count = 13)]
	public void Load()
	{
	}

	[CallsUnknownMethods(Count = 18)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(BinaryFormatter), Member = "Deserialize")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BinaryFormatter), Member = ".ctor")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor")]
	private void OnGameSaveLoaded(object sender, GameSaveLoadedArgs saveData)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public GameSaveSampleLogic()
	{
	}
}
