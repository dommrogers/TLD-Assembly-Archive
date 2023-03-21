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

	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(CameraSyncPostFX), Member = "CopyDataFromSourceImageEffects")]
	[Calls(Type = typeof(CameraSyncPostFX), Member = "Initialize")]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraSyncPostFX), Member = "CopyDataFromSourceImageEffects")]
	private void Update()
	{
	}

	[Calls(Type = typeof(CameraSyncPostFX), Member = "AddImageEffectsFromCamera")]
	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(CameraSyncPostFX), Member = "OnEnable")]
	[Calls(Type = typeof(CameraSyncPostFX), Member = "CopyDataFromSourceImageEffects")]
	[Calls(Type = typeof(CameraSyncPostFX), Member = "AddImageEffectsFromCamera")]
	[Calls(Type = typeof(CameraSyncPostFX), Member = "AddImageEffectsFromCamera")]
	[Calls(Type = typeof(CameraSyncPostFX), Member = "AddImageEffectsFromCamera")]
	[Calls(Type = typeof(Camera), Member = "set_farClipPlane")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[Calls(Type = typeof(Camera), Member = "set_useOcclusionCulling")]
	[Calls(Type = typeof(Camera), Member = "set_renderingPath")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 9)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Camera), Member = "get_farClipPlane")]
	public void Initialize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetFirstPerson()
	{
	}

	[Calls(Type = typeof(Type), Member = "GetMethod")]
	[CalledBy(Type = typeof(CameraSyncPostFX), Member = "Initialize")]
	[CalledBy(Type = typeof(CameraSyncPostFX), Member = "Initialize")]
	[CalledBy(Type = typeof(CameraSyncPostFX), Member = "Initialize")]
	[CalledBy(Type = typeof(CameraSyncPostFX), Member = "Initialize")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsUnknownMethods(Count = 5)]
	[CallerCount(Count = 4)]
	[Calls(Type = typeof(Type), Member = "GetMethod")]
	private void AddImageEffectsFromCamera(Camera destinationCamera, Camera sourceCamera)
	{
	}

	[CalledBy(Type = typeof(CameraSyncPostFX), Member = "Update")]
	[CalledBy(Type = typeof(CameraSyncPostFX), Member = "OnEnable")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(CameraSyncPostFX), Member = "Initialize")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Type), Member = "GetMethod")]
	[Calls(Type = typeof(FieldInfo), Member = "SetValue")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	private void CopyDataFromSourceImageEffects()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 11)]
	public CameraSyncPostFX()
	{
	}
}
