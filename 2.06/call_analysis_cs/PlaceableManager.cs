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

	[CalledBy(Type = typeof(BodyCarry), Member = "Drop")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(Placeable), Member = "Awake")]
	[CalledBy(Type = typeof(BodyCarry), Member = "Restore")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void Add(Placeable placeable)
	{
	}

	[CallsUnknownMethods(Count = 11)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(PdidTable), Member = "RuntimeUnregister")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PdidTable), Member = "GetGameObject")]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(BodyCarry), Member = "Restore")]
	[Calls(Type = typeof(Placeable), Member = "FindOrCreateAndDeserialize")]
	[Calls(Type = typeof(ObjectGuid), Member = "GetGuidFromGameObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PlaceableManager), Member = "FindOrCreateCategoryRoot")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static void DeserializeAll(string serialized)
	{
	}

	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsUnknownMethods(Count = 24)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Placeable), Member = "Serialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static string SerializeAll()
	{
		return null;
	}

	[CalledBy(Type = typeof(PlaceableManager), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 7)]
	[CalledBy(Type = typeof(BodyCarry), Member = "Drop")]
	[CalledBy(Type = typeof(Placeable), Member = "FindOrCreateAndDeserialize")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "set_name")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	public static GameObject FindOrCreateCategoryRoot()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(Placeable), Member = "OnDestroy")]
	[CalledBy(Type = typeof(BodyCarry), Member = "PrepareForSceneTransition")]
	public static void Remove(Placeable placeable)
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CallerCount(Count = 0)]
	[Conditional("__DEBUG")]
	public static void DebugLog(string message)
	{
	}
}
