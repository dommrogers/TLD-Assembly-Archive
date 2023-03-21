using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace VLB;

public abstract class DynamicOcclusionAbstractBase : MonoBehaviour
{
	protected enum ProcessOcclusionSource
	{
		RenderLoop,
		OnEnable,
		EditorUpdate,
		User
	}

	public DynamicOcclusionUpdateRate updateRate;

	public int waitXFrames;

	public static bool _INTERNAL_ApplyRandomFrameOffset;

	private TransformUtils.Packed m_TransformPacked;

	private int m_LastFrameRendered;

	protected VolumetricLightBeam m_Master;

	public int _INTERNAL_LastFrameRendered
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 0)]
		get
		{
			return default(int);
		}
	}

	public event Action onOcclusionProcessed
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	[Calls(Type = typeof(DynamicOcclusionAbstractBase), Member = "ProcessOcclusion")]
	[CallerCount(Count = 0)]
	public void ProcessOcclusionManually()
	{
	}

	[CalledBy(Type = typeof(DynamicOcclusionAbstractBase), Member = "ProcessOcclusionManually")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(DynamicOcclusionAbstractBase), Member = "<OnEnable>b__22_0")]
	[CalledBy(Type = typeof(DynamicOcclusionAbstractBase), Member = "OnWillCameraRender")]
	[Calls(Type = typeof(TransformUtils), Member = "GetWorldPacked")]
	[CallsDeduplicatedMethods(Count = 7)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Config), Member = "GetInstance")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "_INTERNAL_SetDynamicOcclusionCallback")]
	[CallerCount(Count = 3)]
	protected void ProcessOcclusion(ProcessOcclusionSource source)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	protected abstract string GetShaderKeyword();

	[CallerCount(Count = 101224)]
	[DeduplicatedMethod]
	protected abstract MaterialManager.DynamicOcclusion GetDynamicOcclusionMode();

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	protected abstract bool OnProcessOcclusion(ProcessOcclusionSource source);

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	protected abstract void OnModifyMaterialCallback(MaterialModifier.Interface owner);

	[DeduplicatedMethod]
	[CallerCount(Count = 101224)]
	protected abstract void OnEnablePostValidate();

	[CallerCount(Count = 0)]
	protected virtual void OnValidateProperties()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected virtual void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "_INTERNAL_SetDynamicOcclusionCallback")]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnDestroy()
	{
	}

	[CallsUnknownMethods(Count = 14)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "CallOnBeamGeometryInitializedCallback")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	protected virtual void OnEnable()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "_INTERNAL_SetDynamicOcclusionCallback")]
	[CalledBy(Type = typeof(DynamicOcclusionDepthBuffer), Member = "OnDisable")]
	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "OnDisable")]
	[CallsUnknownMethods(Count = 7)]
	protected virtual void OnDisable()
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(DynamicOcclusionAbstractBase), Member = "ProcessOcclusion")]
	[Calls(Type = typeof(TransformUtils), Member = "IsSame")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	private void OnWillCameraRender(Camera cam)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "_INTERNAL_SetDynamicOcclusionCallback")]
	[CallsUnknownMethods(Count = 1)]
	private void DisableOcclusion()
	{
	}

	[CallerCount(Count = 0)]
	protected DynamicOcclusionAbstractBase()
	{
	}
}
