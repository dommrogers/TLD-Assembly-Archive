using System;
using System.Collections.Generic;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

public sealed class PostProcessManager
{
	[Serializable]
	private sealed class _003C_003Ec
	{
		public static readonly _003C_003Ec _003C_003E9;

		public static Func<Type, bool> _003C_003E9__18_0;

		[DeduplicatedMethod]
		[CallerCount(Count = 6)]
		public _003C_003Ec()
		{
		}

		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 3)]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		internal bool _003CReloadBaseTypes_003Eb__18_0(Type t)
		{
			return default(bool);
		}
	}

	private static PostProcessManager s_Instance;

	public static bool s_GlobalVolumesOptimizationEnabled;

	private static int s_SettingsHasChangedFrameCount;

	private static bool s_SettingsHasChanged;

	private static int s_LastUpdatedFrameCount;

	private const int k_MaxLayerCount = 32;

	private readonly Dictionary<int, List<PostProcessVolume>> m_SortedVolumes;

	private readonly List<PostProcessVolume> m_Volumes;

	private readonly Dictionary<int, bool> m_SortNeeded;

	private readonly List<PostProcessEffectSettings> m_BaseSettings;

	private readonly List<Collider> m_TempColliders;

	public readonly Dictionary<Type, PostProcessAttribute> settingsTypes;

	public static PostProcessManager instance
	{
		[CallerCount(Count = 8)]
		[Calls(Type = typeof(PostProcessManager), Member = ".ctor")]
		[CalledBy(Type = typeof(CameraEffects), Member = "ConfigureSSAO")]
		[CalledBy(Type = typeof(ColorGrading), Member = "ApplyTempLut")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "InitBundles")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "UpdateVolumeSystem")]
		[CalledBy(Type = typeof(PostProcessVolume), Member = "OnEnable")]
		[CalledBy(Type = typeof(PostProcessVolume), Member = "OnDisable")]
		[CalledBy(Type = typeof(PostProcessVolume), Member = "Update")]
		[CalledBy(Type = typeof(PostProcessVolume), Member = "Update")]
		[CallsUnknownMethods(Count = 6)]
		get
		{
			return null;
		}
	}

	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 107)]
	public static void MarkSettingsChanged()
	{
	}

	[CallerCount(Count = 0)]
	public static void PostLateUpdate()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(PostProcessManager), Member = "get_instance")]
	private PostProcessManager()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CalledBy(Type = typeof(PostProcessManager), Member = "ReloadBaseTypes")]
	[CallsUnknownMethods(Count = 4)]
	private void CleanBaseTypes()
	{
	}

	[CallsUnknownMethods(Count = 31)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "SetAllOverridesTo")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "GetAllAssemblyTypes")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(PostProcessManager), Member = "CleanBaseTypes")]
	private void ReloadBaseTypes()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 8)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(PostProcessManager), Member = "GrabVolumes")]
	[Calls(Type = typeof(PostProcessVolume), Member = "get_profileRef")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Collider), Member = "get_enabled")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 21)]
	public void GetActiveVolumes(PostProcessLayer layer, List<PostProcessVolume> results, bool skipDisabled = true, bool skipZeroWeight = true)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public PostProcessVolume GetHighestPriorityVolume(PostProcessLayer layer)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 4)]
	public PostProcessVolume GetHighestPriorityVolume(LayerMask mask)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 5)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(PostProcessVolume), Member = "get_profile")]
	[Calls(Type = typeof(PostProcessProfile), Member = "HasSettings")]
	[CalledBy(Type = typeof(ColorGrading), Member = "ApplyTempLut")]
	[CallsUnknownMethods(Count = 16)]
	public PostProcessVolume QuickVolume(int layer, float priority, PostProcessEffectSettings[] settings)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[CalledBy(Type = typeof(PostProcessVolume), Member = "Update")]
	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(PostProcessManager), Member = "Register")]
	internal void SetLayerDirty(int layer)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	internal void UpdateVolumeLayer(PostProcessVolume volume, int prevLayer, int newLayer)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[Calls(Type = typeof(PostProcessManager), Member = "SetLayerDirty")]
	[CalledBy(Type = typeof(PostProcessManager), Member = "Register")]
	[CalledBy(Type = typeof(PostProcessVolume), Member = "OnEnable")]
	[CalledBy(Type = typeof(PostProcessVolume), Member = "Update")]
	[CallsUnknownMethods(Count = 8)]
	private void Register(PostProcessVolume volume, int layer)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PostProcessManager), Member = "Register")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	internal void Register(PostProcessVolume volume)
	{
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(PostProcessManager), Member = "Unregister")]
	[CalledBy(Type = typeof(PostProcessVolume), Member = "OnDisable")]
	[CalledBy(Type = typeof(PostProcessVolume), Member = "Update")]
	[CallsUnknownMethods(Count = 4)]
	private void Unregister(PostProcessVolume volume, int layer)
	{
	}

	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(PostProcessManager), Member = "Unregister")]
	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	internal void Unregister(PostProcessVolume volume)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CalledBy(Type = typeof(PostProcessManager), Member = "UpdateSettings")]
	[CallsUnknownMethods(Count = 21)]
	private void ReplaceData(PostProcessLayer postProcessLayer)
	{
	}

	[CallsUnknownMethods(Count = 5)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	[CalledBy(Type = typeof(CameraEffects), Member = "ConfigureSSAO")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	public void EnableAO(bool enabled)
	{
	}

	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsUnknownMethods(Count = 19)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "UpdateVolumeSystem")]
	[Calls(Type = typeof(PostProcessLayer), Member = "OverrideSettings")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Collider), Member = "get_enabled")]
	[Calls(Type = typeof(PostProcessVolume), Member = "get_profileRef")]
	[Calls(Type = typeof(PostProcessVolume), Member = "get_profileRef")]
	[Calls(Type = typeof(PostProcessLayer), Member = "OverrideSettings")]
	[Calls(Type = typeof(PostProcessLayer), Member = "UpdateGlobalVolumeInfoList")]
	[Calls(Type = typeof(PostProcessLayer), Member = "HaveGlobalVolumesChanged")]
	[Calls(Type = typeof(PostProcessLayer), Member = "AreAllVolumesGlobal")]
	[Calls(Type = typeof(PostProcessManager), Member = "GrabVolumes")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PostProcessManager), Member = "ReplaceData")]
	internal void UpdateSettings(PostProcessLayer postProcessLayer, Camera camera)
	{
	}

	[CallsUnknownMethods(Count = 33)]
	[CalledBy(Type = typeof(PostProcessManager), Member = "UpdateSettings")]
	[CalledBy(Type = typeof(PostProcessManager), Member = "GetActiveVolumes")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	private List<PostProcessVolume> GrabVolumes(LayerMask mask)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 4)]
	private static void SortByPriority(List<PostProcessVolume> volumes)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	private static bool IsVolumeRenderedByCamera(PostProcessVolume volume, Camera camera)
	{
		return default(bool);
	}
}
