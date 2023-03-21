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
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Combine")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(Delegate), Member = "Remove")]
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

	[CalledBy(Type = typeof(DynamicOcclusionAbstractBase), Member = "<OnEnable>b__22_0")]
	[CallsUnknownMethods(Count = 12)]
	[CalledBy(Type = typeof(DynamicOcclusionAbstractBase), Member = "ProcessOcclusionManually")]
	[Calls(Type = typeof(TransformUtils), Member = "GetWorldPacked")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[CalledBy(Type = typeof(DynamicOcclusionAbstractBase), Member = "OnWillCameraRender")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Config), Member = "get_Instance")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 3)]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "_INTERNAL_SetDynamicOcclusionCallback")]
	protected void ProcessOcclusion(ProcessOcclusionSource source)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	protected abstract string GetShaderKeyword();

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	protected abstract MaterialManager.DynamicOcclusion GetDynamicOcclusionMode();

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	protected abstract bool OnProcessOcclusion(ProcessOcclusionSource source);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	protected abstract void OnModifyMaterialCallback(MaterialModifier.Interface owner);

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	protected abstract void OnEnablePostValidate();

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(DynamicOcclusionDepthBuffer), Member = "OnValidateProperties")]
	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "OnValidateProperties")]
	protected virtual void OnValidateProperties()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
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

	[CallsUnknownMethods(Count = 19)]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "CallOnBeamGeometryInitializedCallback")]
	[Calls(Type = typeof(Delegate), Member = "Combine")]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[CallerCount(Count = 0)]
	protected virtual void OnEnable()
	{
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(Delegate), Member = "Remove")]
	[Calls(Type = typeof(VolumetricLightBeam), Member = "_INTERNAL_SetDynamicOcclusionCallback")]
	[CalledBy(Type = typeof(DynamicOcclusionDepthBuffer), Member = "OnDisable")]
	[CalledBy(Type = typeof(DynamicOcclusionRaycasting), Member = "OnDisable")]
	[CallsUnknownMethods(Count = 10)]
	protected virtual void OnDisable()
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(DynamicOcclusionAbstractBase), Member = "ProcessOcclusion")]
	[Calls(Type = typeof(Time), Member = "get_frameCount")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(Enum), Member = "HasFlag")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(TransformUtils), Member = "IsSame")]
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
	[Calls(Type = typeof(Component), Member = ".ctor")]
	protected DynamicOcclusionAbstractBase()
	{
	}
}
