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

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 3)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PersistentControllerState), Member = "RestoreState")]
	public void Update()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	public void OnDestroy()
	{
	}

	[CallerCount(Count = 36)]
	[DeduplicatedMethod]
	private void RequestRestoreState(PersistentControllerStateSaveData saveData)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PersistentControllerState), Member = "SaveStates")]
	[Calls(Type = typeof(PersistentControllerState), Member = "SaveParameters")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallsUnknownMethods(Count = 35)]
	public static string SerializeAll()
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PersistentControllerState), Member = "SerializeAll")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PersistentControllerState), Member = "SaveParameter")]
	private static void SaveParameters(Animator animator, PersistentControllerStateSaveData pcd)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(PersistentControllerState), Member = "SaveParameters")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[Calls(Type = typeof(AnimatorControllerParameter), Member = "get_nameHash")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(AnimatorControllerParameter), Member = "get_nameHash")]
	[Calls(Type = typeof(AnimatorControllerParameter), Member = "get_nameHash")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(int), Member = "ToString")]
	private static PersistentControllerStateSaveData.ParameterSaveData SaveParameter(Animator animator, AnimatorControllerParameter param)
	{
		return default(PersistentControllerStateSaveData.ParameterSaveData);
	}

	[CalledBy(Type = typeof(PersistentControllerState), Member = "SerializeAll")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private static void SaveStates(PersistentControllerState pc, Animator animator, PersistentControllerStateSaveData pcd)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(PersistentControllerState), Member = "RestoreState")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PersistentControllerState), Member = "RequestRestoreState")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 1)]
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

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PersistentControllerState), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void RequestRestoreState(PersistentControllerStateSaveData pcd, Animator animator)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Animator), Member = "PlayInFixedTime")]
	[Calls(Type = typeof(Animator), Member = "PlayInFixedTime")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CalledBy(Type = typeof(PersistentControllerState), Member = "RestoreState")]
	[CallsUnknownMethods(Count = 13)]
	private static void LoadStates(PersistentControllerStateSaveData pcd, Animator animator)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(System.SpanHelpers), Member = "SequenceEqual")]
	[Calls(Type = typeof(Animator), Member = "GetLayerName")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private static int GetLayerIndex(string layerName, Animator animator)
	{
		return default(int);
	}

	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PersistentControllerState), Member = "LoadParameter")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException_InvalidOperation_EnumFailedVersion")]
	[CalledBy(Type = typeof(PersistentControllerState), Member = "RestoreState")]
	[CallsUnknownMethods(Count = 8)]
	private static void LoadParameters(PersistentControllerStateSaveData pcd, Animator animator)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(int), Member = "TryParse")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CalledBy(Type = typeof(PersistentControllerState), Member = "LoadParameters")]
	[CallsUnknownMethods(Count = 3)]
	private static void LoadParameter(Animator animator, PersistentControllerStateSaveData.ParameterSaveData paramData)
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(int), Member = "TryParse")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private static void LoadInt(Animator animator, PersistentControllerStateSaveData.ParameterSaveData paramData)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CallsUnknownMethods(Count = 2)]
	private static void LoadFloat(Animator animator, PersistentControllerStateSaveData.ParameterSaveData paramData)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static void LoadBool(Animator animator, PersistentControllerStateSaveData.ParameterSaveData paramData)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 12)]
	public PersistentControllerState()
	{
	}
}
