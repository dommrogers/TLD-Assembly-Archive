using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class RenderTextureCameraManager : MonoBehaviour
{
	public class RenderTextureManagedCamera
	{
		public readonly GameObject m_DisplayInterface;

		public readonly Camera m_Camera;

		private bool m_IsDirty;

		private bool m_WasInterfaceActive;

		private int m_Index;

		private const int LAYER_UI = 32;

		private event Action m_OnRenderCompleted
		{
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Delegate), Member = "Combine")]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			add
			{
			}
			[CompilerGenerated]
			[DeduplicatedMethod]
			[CallerCount(Count = 0)]
			[Calls(Type = typeof(Delegate), Member = "Remove")]
			[CallsDeduplicatedMethods(Count = 1)]
			[CallsUnknownMethods(Count = 1)]
			remove
			{
			}
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 2)]
		public RenderTextureManagedCamera(Camera camera, GameObject displayInterface)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public void SetDirty(bool isDirty)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public bool IsDirty()
		{
			return false;
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		public void OnEnable()
		{
		}

		[CallerCount(Count = 0)]
		[Calls(Type = typeof(RenderTextureManagedCamera), Member = "MaybeUpdateUICamera")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallsUnknownMethods(Count = 4)]
		public void Update(int index, float displayOffset)
		{
		}

		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		public void OnRenderCompleted()
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public void RegisterOnRenderCompletedAction(Action action)
		{
		}

		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		public void UnRegisterOnRenderCompletedAction(Action action)
		{
		}

		[CalledBy(Type = typeof(RenderTextureCameraManager), Member = "LateUpdate")]
		[CalledBy(Type = typeof(RenderTextureManagedCamera), Member = "Update")]
		[CallerCount(Count = 2)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
		[CallsDeduplicatedMethods(Count = 6)]
		[CallsUnknownMethods(Count = 10)]
		private void MaybeUpdateUICamera(int index, float displayOffset)
		{
		}
	}

	private List<RenderTextureManagedCamera> m_RegisteredRenderTextureManagedCamera;

	private float m_DisplayOffsetForRender;

	private bool m_HasShownRenderWarning;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void Deactivate(RenderTextureManagedCamera renderTextureManagedCamera)
	{
	}

	[CalledBy(Type = typeof(RenderTextureCameraManager), Member = "Render")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 3)]
	private void Render(RenderTextureManagedCamera renderTextureManagedCamera)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTextureManagedCamera), Member = "MaybeUpdateUICamera")]
	[Calls(TypeFullName = "System.ThrowHelper", Member = "ThrowArgumentOutOfRangeException")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 9)]
	public void LateUpdate()
	{
	}

	[CalledBy(Type = typeof(CameraGlobalRT), Member = "OnPreRender")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "Render")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 6)]
	public void Render()
	{
	}

	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "InitializeDisplayInterface")]
	[CalledBy(Type = typeof(RenderTextureGrabber), Member = "CreateRenderTexture")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(List<>), Member = "Add")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 12)]
	public void RegisterCamera(Camera camera, GameObject displayInterface)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "GetRenderTextureManagedCamera")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void RegisterOnRenderCompletedAction(Camera camera, GameObject displayInterface, Action onRenderCompletedAction)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "GetRenderTextureManagedCamera")]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void UnRegisterOnRenderCompletedAction(Camera camera, GameObject displayInterface, Action onRenderCompletedAction)
	{
	}

	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "InitializeDisplayInterface")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "SetDisplayActive")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "OnTextScrolled")]
	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "RefreshLocalization")]
	[CalledBy(Type = typeof(DialogueSequenceFP), Member = "Update")]
	[CalledBy(Type = typeof(RenderTextureCameraManager), Member = "RegisterOnRenderCompletedAction")]
	[CalledBy(Type = typeof(RenderTextureCameraManager), Member = "UnRegisterOnRenderCompletedAction")]
	[CalledBy(Type = typeof(RenderTextureCameraManager), Member = "SetDirty")]
	[CalledBy(Type = typeof(RenderTextureCameraManager), Member = "UnregisterCamera")]
	[CalledBy(Type = typeof(RenderTextureGrabber), Member = "CreateRenderTexture")]
	[CalledBy(Type = typeof(RenderTextureGrabber), Member = "SetDirty")]
	[CalledBy(Type = typeof(RenderTextureGrabber), Member = "OnDestroy")]
	[CallerCount(Count = 12)]
	[Calls(Type = typeof(List<>.Enumerator), Member = "MoveNext")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 3)]
	private RenderTextureManagedCamera GetRenderTextureManagedCamera(Camera camera, GameObject displayInterface)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "GetRenderTextureManagedCamera")]
	public void SetDirty(Camera camera, GameObject displayInterface)
	{
	}

	[CalledBy(Type = typeof(AuroraScreenDisplay), Member = "OnDestroy")]
	[CalledBy(Type = typeof(RenderTextureGrabber), Member = "OnDestroy")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(RenderTextureCameraManager), Member = "GetRenderTextureManagedCamera")]
	[Calls(Type = typeof(List<>), Member = "Remove")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void UnregisterCamera(Camera camera, GameObject displayInterface)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(List<>), Member = ".ctor")]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 7)]
	public RenderTextureCameraManager()
	{
	}
}
