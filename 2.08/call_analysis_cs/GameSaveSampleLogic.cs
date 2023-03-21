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

	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void Start()
	{
	}

	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Gdk), Member = "get_Helpers")]
	[CallsUnknownMethods(Count = 8)]
	[Calls(Type = typeof(BinaryFormatter), Member = "Serialize")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(BinaryFormatter), Member = ".ctor")]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void Save()
	{
	}

	[Calls(Type = typeof(Gdk), Member = "get_Helpers")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Gdk), Member = "get_Helpers")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Gdk), Member = "get_Helpers")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	public void Load()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(BinaryFormatter), Member = ".ctor")]
	[Calls(Type = typeof(MemoryStream), Member = ".ctor")]
	[Calls(Type = typeof(BinaryFormatter), Member = "Deserialize")]
	[Calls(Type = typeof(int), Member = "ToString")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsUnknownMethods(Count = 6)]
	private void OnGameSaveLoaded(object sender, GameSaveLoadedArgs saveData)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public GameSaveSampleLogic()
	{
	}
}
