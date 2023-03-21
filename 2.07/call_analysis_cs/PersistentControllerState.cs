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
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Utils), Member = "GetComponentOnSelfOrParent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	public void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PersistentControllerState), Member = "RestoreState")]
	public void Update()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsUnknownMethods(Count = 1)]
	public void OnDestroy()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 50)]
	private void RequestRestoreState(PersistentControllerStateSaveData saveData)
	{
	}

	[CalledBy(Type = typeof(SaveGameSystem), Member = "SaveSceneData")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(PersistentControllerState), Member = "SaveStates")]
	[Calls(Type = typeof(PersistentControllerState), Member = "SaveParameters")]
	[Calls(Type = typeof(SerializationUtils), Member = "SerializeObject")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 12)]
	public static string SerializeAll()
	{
		return null;
	}

	[CalledBy(Type = typeof(PersistentControllerState), Member = "SerializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PersistentControllerState), Member = "SaveParameter")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private static void SaveParameters(Animator animator, PersistentControllerStateSaveData pcd)
	{
	}

	[CalledBy(Type = typeof(PersistentControllerState), Member = "SaveParameters")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(AnimatorControllerParameter), Member = "get_nameHash")]
	[Calls(TypeFullName = "System.Number", Member = "FormatInt32")]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "FormatSingle")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 3)]
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
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "DeserializeObject")]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(MissionServicesManager), Member = "GetComponentForMissionObject")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(PersistentControllerState), Member = "RequestRestoreState")]
	[Calls(Type = typeof(PersistentControllerState), Member = "RestoreState")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 4)]
	public static void DeserializeAll(string text)
	{
	}

	[CalledBy(Type = typeof(PersistentControllerState), Member = "Update")]
	[CalledBy(Type = typeof(PersistentControllerState), Member = "DeserializeAll")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(PersistentControllerState), Member = "LoadStates")]
	[Calls(Type = typeof(PersistentControllerState), Member = "LoadParameters")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 2)]
	private static void RestoreState(PersistentControllerStateSaveData pcd, Animator animator)
	{
	}

	[CalledBy(Type = typeof(PersistentControllerState), Member = "DeserializeAll")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsUnknownMethods(Count = 1)]
	private static void RequestRestoreState(PersistentControllerStateSaveData pcd, Animator animator)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 1)]
	public static void Reset()
	{
	}

	[CalledBy(Type = typeof(PersistentControllerState), Member = "RestoreState")]
	[CallerCount(Count = 1)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[Calls(Type = typeof(Animator), Member = "PlayInFixedTime")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 7)]
	private static void LoadStates(PersistentControllerStateSaveData pcd, Animator animator)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(TypeFullName = "System.SpanHelpers", Member = "SequenceEqual")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private static int GetLayerIndex(string layerName, Animator animator)
	{
		return 0;
	}

	[CalledBy(Type = typeof(PersistentControllerState), Member = "RestoreState")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PersistentControllerState), Member = "LoadParameter")]
	[CallsUnknownMethods(Count = 3)]
	private static void LoadParameters(PersistentControllerStateSaveData pcd, Animator animator)
	{
	}

	[CalledBy(Type = typeof(PersistentControllerState), Member = "LoadParameters")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "TryParseInt32")]
	[Calls(Type = typeof(float), Member = "TryParse")]
	[Calls(Type = typeof(bool), Member = "TryParse")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 2)]
	private static void LoadParameter(Animator animator, PersistentControllerStateSaveData.ParameterSaveData paramData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(TypeFullName = "System.Number", Member = "TryParseInt32")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static void LoadInt(Animator animator, PersistentControllerStateSaveData.ParameterSaveData paramData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NumberFormatInfo), Member = "get_CurrentInfo")]
	[Calls(Type = typeof(float), Member = "TryParse")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static void LoadFloat(Animator animator, PersistentControllerStateSaveData.ParameterSaveData paramData)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(bool), Member = "TryParse")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private static void LoadBool(Animator animator, PersistentControllerStateSaveData.ParameterSaveData paramData)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public PersistentControllerState()
	{
	}
}
