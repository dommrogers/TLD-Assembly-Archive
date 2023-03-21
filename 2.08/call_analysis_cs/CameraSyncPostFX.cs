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

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraSyncPostFX), Member = "CopyDataFromSourceImageEffects")]
	[Calls(Type = typeof(CameraSyncPostFX), Member = "Initialize")]
	[CallsUnknownMethods(Count = 2)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(CameraSyncPostFX), Member = "CopyDataFromSourceImageEffects")]
	private void Update()
	{
	}

	[CalledBy(Type = typeof(CameraSyncPostFX), Member = "OnEnable")]
	[CallsUnknownMethods(Count = 6)]
	[Calls(Type = typeof(CameraSyncPostFX), Member = "AddImageEffectsFromCamera")]
	[Calls(Type = typeof(CameraSyncPostFX), Member = "AddImageEffectsFromCamera")]
	[Calls(Type = typeof(CameraSyncPostFX), Member = "AddImageEffectsFromCamera")]
	[Calls(Type = typeof(CameraSyncPostFX), Member = "AddImageEffectsFromCamera")]
	[Calls(Type = typeof(Camera), Member = "set_farClipPlane")]
	[Calls(Type = typeof(CameraSyncPostFX), Member = "CopyDataFromSourceImageEffects")]
	[Calls(Type = typeof(Utils), Member = "Approximately")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Camera), Member = "get_farClipPlane")]
	[Calls(Type = typeof(Camera), Member = "set_renderingPath")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "Destroy")]
	[Calls(Type = typeof(Camera), Member = "set_useOcclusionCulling")]
	public void Initialize()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public void SetFirstPerson()
	{
	}

	[CalledBy(Type = typeof(CameraSyncPostFX), Member = "Initialize")]
	[CallsUnknownMethods(Count = 14)]
	[CalledBy(Type = typeof(CameraSyncPostFX), Member = "Initialize")]
	[CalledBy(Type = typeof(CameraSyncPostFX), Member = "Initialize")]
	[CalledBy(Type = typeof(CameraSyncPostFX), Member = "Initialize")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 4)]
	private void AddImageEffectsFromCamera(Camera destinationCamera, Camera sourceCamera)
	{
	}

	[CalledBy(Type = typeof(CameraSyncPostFX), Member = "Initialize")]
	[CalledBy(Type = typeof(CameraSyncPostFX), Member = "Update")]
	[CalledBy(Type = typeof(CameraSyncPostFX), Member = "OnEnable")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 11)]
	[Calls(Type = typeof(ArgumentNullException), Member = ".ctor")]
	[Calls(Type = typeof(FieldInfo), Member = "SetValue")]
	[CallsDeduplicatedMethods(Count = 6)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	private void CopyDataFromSourceImageEffects()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	public CameraSyncPostFX()
	{
	}
}
