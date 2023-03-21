using System;
using System.Collections.Generic;
using System.Reflection;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class CameraSyncPostFX : MonoBehaviour
{
	private const BindingFlags m_FieldFlags = (BindingFlags)84;

	private const BindingFlags m_MethodFlags = (BindingFlags)116;

	private Camera m_Camera;

	private CameraGlobalRT m_GlobalCamera;

	private List<MonoBehaviour> m_SourceImageEffects;

	private List<MonoBehaviour> m_SynchronizedImageEffects;

	private bool m_ForceFirstPersonCamera;

	[Calls(Type = typeof(CameraSyncPostFX), Member = "Initialize")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[Calls(Type = typeof(CameraSyncPostFX), Member = "CopyDataFromSourceImageEffects")]
	[CallsUnknownMethods(Count = 3)]
	private void OnEnable()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraSyncPostFX), Member = "CopyDataFromSourceImageEffects")]
	private void Update()
	{
	}

	[CallsUnknownMethods(Count = 26)]
	[CalledBy(Type = typeof(CameraSyncPostFX), Member = "OnEnable")]
	[Calls(Type = typeof(CameraSyncPostFX), Member = "CopyDataFromSourceImageEffects")]
	[Calls(Type = typeof(CameraSyncPostFX), Member = "AddImageEffectsFromCamera")]
	[Calls(Type = typeof(CameraSyncPostFX), Member = "AddImageEffectsFromCamera")]
	[Calls(Type = typeof(CameraSyncPostFX), Member = "AddImageEffectsFromCamera")]
	[Calls(Type = typeof(Camera), Member = "set_farClipPlane")]
	[Calls(Type = typeof(Camera), Member = "get_farClipPlane")]
	[Calls(Type = typeof(CameraSyncPostFX), Member = "AddImageEffectsFromCamera")]
	[Calls(Type = typeof(Camera), Member = "set_useOcclusionCulling")]
	[Calls(Type = typeof(Camera), Member = "set_renderingPath")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	public void Initialize()
	{
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void SetFirstPerson()
	{
	}

	[CallsUnknownMethods(Count = 21)]
	[CalledBy(Type = typeof(CameraSyncPostFX), Member = "Initialize")]
	[CalledBy(Type = typeof(CameraSyncPostFX), Member = "Initialize")]
	[CalledBy(Type = typeof(CameraSyncPostFX), Member = "Initialize")]
	[CalledBy(Type = typeof(CameraSyncPostFX), Member = "Initialize")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(MethodInfo), Member = "op_Equality")]
	[Calls(Type = typeof(MethodInfo), Member = "op_Equality")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetMethod")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Type), Member = "GetMethod")]
	private void AddImageEffectsFromCamera(Camera destinationCamera, Camera sourceCamera)
	{
	}

	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(CameraSyncPostFX), Member = "Initialize")]
	[CalledBy(Type = typeof(CameraSyncPostFX), Member = "Update")]
	[CalledBy(Type = typeof(CameraSyncPostFX), Member = "OnEnable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException")]
	[Calls(Type = typeof(MethodInfo), Member = "op_Equality")]
	[Calls(Type = typeof(Type), Member = "GetMethod")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	private void CopyDataFromSourceImageEffects()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsUnknownMethods(Count = 14)]
	public CameraSyncPostFX()
	{
	}
}
