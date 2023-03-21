using System;
using System.Collections.Generic;
using System.Diagnostics;
using Cpp2ILInjected.CallAnalysis;
using TLD.PDID;
using TLD.Serialization;
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
		[CallerCount(Count = 6)]
		public PlaceableInfoSaveData()
		{
		}
	}

	public static bool s_Verbose;

	private const string CATEGORY_NAME = "DesignPlaceable";

	public static bool s_IsDeserializing;

	private static Dictionary<string, PlaceableInfo> s_Placeables;

	private static GameObject s_Category;

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Placeable), Member = "Awake")]
	[CalledBy(Type = typeof(BodyCarry), Member = "Drop")]
	[CalledBy(Type = typeof(BodyCarry), Member = "Restore")]
	[CallsUnknownMethods(Count = 2)]
	public static void Add(Placeable placeable)
	{
	}

	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallsUnknownMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(PdidTable), Member = "RuntimeUnregister")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(BodyCarry), Member = "Restore")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Placeable), Member = "FindOrCreateAndDeserialize")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlaceableManager), Member = "FindOrCreateCategoryRoot")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void DeserializeAll(string serialized)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Placeable), Member = "Serialize")]
	public static string SerializeAll()
	{
		return null;
	}

	[CalledBy(Type = typeof(PlaceableManager), Member = "DeserializeAll")]
	[CalledBy(Type = typeof(Placeable), Member = "FindOrCreateAndDeserialize")]
	[CalledBy(Type = typeof(BodyCarry), Member = "Drop")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	public static GameObject FindOrCreateCategoryRoot()
	{
		return null;
	}

	[CalledBy(Type = typeof(BodyCarry), Member = "PrepareForSceneTransition")]
	[CalledBy(Type = typeof(Placeable), Member = "OnDestroy")]
	[CallsUnknownMethods(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void Remove(Placeable placeable)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[Conditional("__DEBUG")]
	[CallerCount(Count = 0)]
	public static void DebugLog(string message)
	{
	}
}
