using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public static class PlaceableManager
{
	public enum State
	{
		Active,
		Removed
	}

	public enum SerializationFlags
	{
		None,
		Carried
	}

	private struct PlaceableInfo
	{
		public Placeable m_Handle;

		public State m_State;
	}

	public class PlaceableInfoSaveData
	{
		public SerializationFlags m_Flags;

		public string m_Guid;

		public string m_Serialized;

		public State m_State;

		[DeduplicatedMethod]
		[CallerCount(Count = 2)]
		public PlaceableInfoSaveData()
		{
		}
	}

	public static bool s_Verbose;

	private const string CATEGORY_NAME = "DesignPlaceable";

	public static bool s_IsDeserializing;

	private static Dictionary<string, PlaceableInfo> s_Placeables;

	private static GameObject s_Category;

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(BodyCarry), Member = "Restore")]
	[CalledBy(Type = typeof(BodyCarry), Member = "Drop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(Placeable), Member = "Awake")]
	public static void Add(Placeable placeable)
	{
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(ObjectGuidManager), Member = "UnRegisterGuid")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(ObjectGuidManager), Member = "Lookup")]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(BodyCarry), Member = "Restore")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(Placeable), Member = "FindOrCreateAndDeserialize")]
	[Calls(Type = typeof(Utils), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlaceableManager), Member = "FindOrCreateCategoryRoot")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	public static void DeserializeAll(string serialized)
	{
	}

	[CallsUnknownMethods(Count = 24)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(Placeable), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	public static string SerializeAll()
	{
		return null;
	}

	[CalledBy(Type = typeof(BodyCarry), Member = "Drop")]
	[CalledBy(Type = typeof(PlaceableManager), Member = "DeserializeAll")]
	[CalledBy(Type = typeof(Placeable), Member = "FindOrCreateAndDeserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	public static GameObject FindOrCreateCategoryRoot()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(Placeable), Member = "OnDestroy")]
	[CalledBy(Type = typeof(BodyCarry), Member = "PrepareForSceneTransition")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void Remove(Placeable placeable)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(GameManager), Member = "ResetLists")]
	[CallsUnknownMethods(Count = 5)]
	public static void Reset()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Conditional(/*Could not decode attribute arguments.*/)]
	[CallerCount(Count = 0)]
	public static void DebugLog(string message)
	{
	}
}
