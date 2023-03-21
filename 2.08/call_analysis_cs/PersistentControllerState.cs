using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using TLD.Serialization;
using UnityEngine;

public class PersistentControllerState : MonoBehaviour
{
	private Animator m_Animator;

	private static List<PersistentControllerState> s_PersistentControllerStates;

	private string m_Id;

	private const int INVALIDLAYERINDEX = -1;

	private PersistentControllerStateSaveData m_RestoreData;

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PersistentControllerState), Member = "RestoreState")]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void OnDestroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 40)]
	private void RequestRestoreState(PersistentControllerStateSaveData saveData)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PersistentControllerState), Member = "SaveStates")]
	[Calls(Type = typeof(PersistentControllerState), Member = "SaveParameters")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsUnknownMethods(Count = 13)]
	public static string SerializeAll()
	{
		return null;
	}

	[CalledBy(Type = typeof(PersistentControllerState), Member = "SerializeAll")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PersistentControllerState), Member = "SaveParameter")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	private static void SaveParameters(Animator animator, PersistentControllerStateSaveData pcd)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PersistentControllerState), Member = "SaveParameters")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(AnimatorControllerParameter), Member = "get_nameHash")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(AnimatorControllerParameter), Member = "get_nameHash")]
	[Calls(Type = typeof(AnimatorControllerParameter), Member = "get_nameHash")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	private static PersistentControllerStateSaveData.ParameterSaveData SaveParameter(Animator animator, AnimatorControllerParameter param)
	{
		return default(PersistentControllerStateSaveData.ParameterSaveData);
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CalledBy(Type = typeof(PersistentControllerState), Member = "SerializeAll")]
	[CallsUnknownMethods(Count = 5)]
	private static void SaveStates(PersistentControllerState pc, Animator animator, PersistentControllerStateSaveData pcd)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[Calls(Type = typeof(PersistentControllerState), Member = "RestoreState")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PersistentControllerState), Member = "RequestRestoreState")]
	public static void DeserializeAll(string text)
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PersistentControllerState), Member = "LoadStates")]
	[Calls(Type = typeof(PersistentControllerState), Member = "LoadParameters")]
	[CalledBy(Type = typeof(PersistentControllerState), Member = "Update")]
	[CalledBy(Type = typeof(PersistentControllerState), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 2)]
	private static void RestoreState(PersistentControllerStateSaveData pcd, Animator animator)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PersistentControllerState), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 1)]
	private static void RequestRestoreState(PersistentControllerStateSaveData pcd, Animator animator)
	{
	}

	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public static void Reset()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Animator), Member = "PlayInFixedTime")]
	[Calls(Type = typeof(Animator), Member = "PlayInFixedTime")]
	[CalledBy(Type = typeof(PersistentControllerState), Member = "RestoreState")]
	[CallsUnknownMethods(Count = 7)]
	private static void LoadStates(PersistentControllerStateSaveData pcd, Animator animator)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[CallsUnknownMethods(Count = 3)]
	private static int GetLayerIndex(string layerName, Animator animator)
	{
		return default(int);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PersistentControllerState), Member = "LoadParameter")]
	[CalledBy(Type = typeof(PersistentControllerState), Member = "RestoreState")]
	[CallsUnknownMethods(Count = 3)]
	private static void LoadParameters(PersistentControllerStateSaveData pcd, Animator animator)
	{
	}

	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(System.Number), Member = "TryParseInt32")]
	[CalledBy(Type = typeof(PersistentControllerState), Member = "LoadParameters")]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallerCount(Count = 1)]
	private static void LoadParameter(Animator animator, PersistentControllerStateSaveData.ParameterSaveData paramData)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "TryParseInt32")]
	[CallsUnknownMethods(Count = 1)]
	private static void LoadInt(Animator animator, PersistentControllerStateSaveData.ParameterSaveData paramData)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void LoadFloat(Animator animator, PersistentControllerStateSaveData.ParameterSaveData paramData)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static void LoadBool(Animator animator, PersistentControllerStateSaveData.ParameterSaveData paramData)
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public PersistentControllerState()
	{
	}
}
