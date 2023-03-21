using System;
using System.Collections.Generic;
using System.Globalization;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class PersistentControllerState : MonoBehaviour
{
	private Animator m_Animator;

	private static List<PersistentControllerState> s_PersistentControllerStates;

	private string m_Id;

	private const int INVALIDLAYERINDEX = -1;

	private PersistentControllerStateSaveData m_RestoreData;

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	public void Awake()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PersistentControllerState), Member = "RestoreState")]
	[CallerCount(Count = 0)]
	public void Update()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	public void OnDestroy()
	{
	}

	[CallerCount(Count = 20)]
	[DeduplicatedMethod]
	private void RequestRestoreState(PersistentControllerStateSaveData saveData)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(PersistentControllerState), Member = "SaveStates")]
	[CallsUnknownMethods(Count = 43)]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[Calls(Type = typeof(Utils), Member = "SerializeObject")]
	[Calls(Type = typeof(PersistentControllerState), Member = "SaveParameters")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	public static string SerializeAll()
	{
		return null;
	}

	[CalledBy(Type = typeof(PersistentControllerState), Member = "SerializeAll")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PersistentControllerState), Member = "SaveParameter")]
	[CallsUnknownMethods(Count = 8)]
	private static void SaveParameters(Animator animator, PersistentControllerStateSaveData pcd)
	{
	}

	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatInt32")]
	[Calls(Type = typeof(AnimatorControllerParameter), Member = "get_nameHash")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "FormatSingle")]
	[CalledBy(Type = typeof(PersistentControllerState), Member = "SaveParameters")]
	[Calls(Type = typeof(AnimatorControllerParameter), Member = "get_nameHash")]
	[CallsUnknownMethods(Count = 5)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(AnimatorControllerParameter), Member = "get_nameHash")]
	[CallerCount(Count = 1)]
	private static PersistentControllerStateSaveData.ParameterSaveData SaveParameter(Animator animator, AnimatorControllerParameter param)
	{
		return default(PersistentControllerStateSaveData.ParameterSaveData);
	}

	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(PersistentControllerState), Member = "SerializeAll")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	private static void SaveStates(PersistentControllerState pc, Animator animator, PersistentControllerStateSaveData pcd)
	{
	}

	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(SaveGameSystem), Member = "LoadSceneData")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(PersistentControllerState), Member = "RequestRestoreState")]
	[Calls(Type = typeof(PersistentControllerState), Member = "RestoreState")]
	public static void DeserializeAll(string text)
	{
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PersistentControllerState), Member = "LoadStates")]
	[Calls(Type = typeof(PersistentControllerState), Member = "LoadParameters")]
	[CalledBy(Type = typeof(PersistentControllerState), Member = "Update")]
	[CalledBy(Type = typeof(PersistentControllerState), Member = "DeserializeAll")]
	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 2)]
	private static void RestoreState(PersistentControllerStateSaveData pcd, Animator animator)
	{
	}

	[CallsUnknownMethods(Count = 2)]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CalledBy(Type = typeof(PersistentControllerState), Member = "DeserializeAll")]
	private static void RequestRestoreState(PersistentControllerStateSaveData pcd, Animator animator)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PersistentControllerState), Member = "GetLayerIndex")]
	[CalledBy(Type = typeof(PersistentControllerState), Member = "RestoreState")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[CallsUnknownMethods(Count = 10)]
	[Calls(Type = typeof(Animator), Member = "PlayInFixedTime")]
	[Calls(Type = typeof(Animator), Member = "PlayInFixedTime")]
	private static void LoadStates(PersistentControllerStateSaveData pcd, Animator animator)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Animator), Member = "GetLayerName")]
	[CalledBy(Type = typeof(PersistentControllerState), Member = "LoadStates")]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	private static int GetLayerIndex(string layerName, Animator animator)
	{
		return default(int);
	}

	[CallerCount(Count = 1)]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(PersistentControllerState), Member = "RestoreState")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowInvalidOperationException")]
	[Calls(Type = typeof(PersistentControllerState), Member = "LoadParameter")]
	[CallsDeduplicatedMethods(Count = 1)]
	private static void LoadParameters(PersistentControllerStateSaveData pcd, Animator animator)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[CalledBy(Type = typeof(PersistentControllerState), Member = "LoadParameters")]
	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "TryParseInt32")]
	private static void LoadParameter(Animator animator, PersistentControllerStateSaveData.ParameterSaveData paramData)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(System.Number), Member = "TryParseInt32")]
	[CallsUnknownMethods(Count = 1)]
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
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private static void LoadBool(Animator animator, PersistentControllerStateSaveData.ParameterSaveData paramData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[DeduplicatedMethod]
	public PersistentControllerState()
	{
	}
}
