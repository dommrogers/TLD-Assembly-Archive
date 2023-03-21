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
			return 0;
		}
	}

	public event Action onOcclusionProcessed
	{
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallsUnknownMethods(Count = 1)]
		remove
		{
		}
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DynamicOcclusionAbstractBase), Member = "ProcessOcclusion")]
	public void ProcessOcclusionManually()
	{
	}

	[CalledBy(Type = typeof(DynamicOcclusionAbstractBase), Member = "ProcessOcclusionManually")]
	[CalledBy(Type = typeof(DynamicOcclusionAbstractBase), Member = "OnWillCameraRender")]
	[CalledBy(Type = typeof(DynamicOcclusionAbstractBase), Member = "<OnEnable>b__22_0")]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(Config), Member = "get_Instance")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "_INTERNAL_SetDynamicOcclusionCallback")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(TransformUtils), Member = "GetWorldPacked")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallsUnknownMethods(Count = 12)]
	protected void ProcessOcclusion(ProcessOcclusionSource source)
	{
	}

	protected abstract string GetShaderKeyword();

	protected abstract MaterialManager.DynamicOcclusion GetDynamicOcclusionMode();

	protected abstract bool OnProcessOcclusion(ProcessOcclusionSource source);

	protected abstract void OnModifyMaterialCallback(MaterialModifier.Interface owner);

	protected abstract void OnEnablePostValidate();

	[CalledBy(Type = typeof(DynamicOcclusionDepthBuffer), Member = "OnValidateProperties")]
	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "OnValidateProperties")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	protected virtual void OnValidateProperties()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void Awake()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "_INTERNAL_SetDynamicOcclusionCallback")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	protected virtual void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "CallOnBeamGeometryInitializedCallback")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 19)]
	protected virtual void OnEnable()
	{
	}

	[CalledBy(Type = typeof(DynamicOcclusionDepthBuffer), Member = "OnDisable")]
	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "OnDisable")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "_INTERNAL_SetDynamicOcclusionCallback")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	protected virtual void OnDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(TransformUtils), Member = "IsSame")]
	[Calls(Type = typeof(Time), Member = "get_frameCount")]
	[Calls(Type = typeof(DynamicOcclusionAbstractBase), Member = "ProcessOcclusion")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 5)]
	private void OnWillCameraRender(Camera cam)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "_INTERNAL_SetDynamicOcclusionCallback")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void DisableOcclusion()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	protected DynamicOcclusionAbstractBase()
	{
	}
}
