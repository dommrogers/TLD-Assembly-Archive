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
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[Calls(Type = typeof(Type), Member = "GetTypeFromHandle")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 0)]
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
		[CalledBy(Type = typeof(PostProcessVolume), Member = "Update")]
		[CallsUnknownMethods(Count = 1)]
		[CalledBy(Type = typeof(PostProcessVolume), Member = "OnDisable")]
		[CalledBy(Type = typeof(PostProcessVolume), Member = "OnEnable")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "UpdateVolumeSystem")]
		[CalledBy(Type = typeof(PostProcessVolume), Member = "Update")]
		[CalledBy(Type = typeof(ColorGrading), Member = "ApplyTempLut")]
		[CalledBy(Type = typeof(CameraEffects), Member = "ConfigureSSAO")]
		[Calls(Type = typeof(PostProcessManager), Member = ".ctor")]
		[CallerCount(Count = 8)]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "InitBundles")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 51)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public static void MarkSettingsChanged()
	{
	}

	[CallerCount(Count = 0)]
	public static void PostLateUpdate()
	{
	}

	[CallerCount(Count = 1)]
	[CallAnalysisFailed]
	[CalledBy(Type = typeof(PostProcessManager), Member = "get_instance")]
	private PostProcessManager()
	{
	}

	[CalledBy(Type = typeof(PostProcessManager), Member = "ReloadBaseTypes")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	private void CleanBaseTypes()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(PostProcessManager), Member = "CleanBaseTypes")]
	[Calls(Type = typeof(RuntimeUtilities), Member = "GetAllAssemblyTypes")]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "SetAllOverridesTo")]
	[CallsUnknownMethods(Count = 24)]
	private void ReloadBaseTypes()
	{
	}

	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(PostProcessManager), Member = "GrabVolumes")]
	[Calls(Type = typeof(PostProcessVolume), Member = "get_profileRef")]
	[Calls(Type = typeof(Collider), Member = "get_enabled")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[CallsUnknownMethods(Count = 15)]
	[CallerCount(Count = 0)]
	public void GetActiveVolumes(PostProcessLayer layer, List<PostProcessVolume> results, bool skipDisabled = true, bool skipZeroWeight = true)
	{
	}

	[CallerCount(Count = 0)]
	[CallAnalysisFailed]
	public PostProcessVolume GetHighestPriorityVolume(PostProcessLayer layer)
	{
		return null;
	}

	[CallsUnknownMethods(Count = 4)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	public PostProcessVolume GetHighestPriorityVolume(LayerMask mask)
	{
		return null;
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "set_name")]
	[Calls(Type = typeof(PostProcessVolume), Member = "get_profile")]
	[Calls(Type = typeof(PostProcessProfile), Member = "HasSettings")]
	[CalledBy(Type = typeof(ColorGrading), Member = "ApplyTempLut")]
	[CallsUnknownMethods(Count = 10)]
	public PostProcessVolume QuickVolume(int layer, float priority, PostProcessEffectSettings[] settings)
	{
		return null;
	}

	[CallerCount(Count = 2)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(PostProcessManager), Member = "Register")]
	[CalledBy(Type = typeof(PostProcessVolume), Member = "Update")]
	[CallsUnknownMethods(Count = 3)]
	internal void SetLayerDirty(int layer)
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	internal void UpdateVolumeLayer(PostProcessVolume volume, int prevLayer, int newLayer)
	{
	}

	[CalledBy(Type = typeof(PostProcessVolume), Member = "OnEnable")]
	[CallsUnknownMethods(Count = 5)]
	[CalledBy(Type = typeof(PostProcessManager), Member = "Register")]
	[CalledBy(Type = typeof(PostProcessVolume), Member = "Update")]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(PostProcessManager), Member = "SetLayerDirty")]
	[CallerCount(Count = 3)]
	private void Register(PostProcessVolume volume, int layer)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PostProcessManager), Member = "Register")]
	[CallsUnknownMethods(Count = 3)]
	internal void Register(PostProcessVolume volume)
	{
	}

	[CalledBy(Type = typeof(PostProcessVolume), Member = "Update")]
	[CalledBy(Type = typeof(PostProcessVolume), Member = "OnDisable")]
	[CallsUnknownMethods(Count = 3)]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(PostProcessManager), Member = "Unregister")]
	private void Unregister(PostProcessVolume volume, int layer)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(PostProcessManager), Member = "Unregister")]
	[CallsUnknownMethods(Count = 3)]
	internal void Unregister(PostProcessVolume volume)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CalledBy(Type = typeof(PostProcessManager), Member = "UpdateSettings")]
	[CallsUnknownMethods(Count = 17)]
	private void ReplaceData(PostProcessLayer postProcessLayer)
	{
	}

	[CallsUnknownMethods(Count = 6)]
	[CalledBy(Type = typeof(CameraEffects), Member = "ConfigureSSAO")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(PostProcessEffectSettings), Member = "set_active")]
	public void EnableAO(bool enabled)
	{
	}

	[Calls(Type = typeof(PostProcessVolume), Member = "get_profileRef")]
	[Calls(Type = typeof(PostProcessLayer), Member = "OverrideSettings")]
	[Calls(Type = typeof(PostProcessLayer), Member = "OverrideSettings")]
	[Calls(Type = typeof(Array), Member = "Clear")]
	[Calls(Type = typeof(Collider), Member = "get_enabled")]
	[Calls(Type = typeof(PostProcessVolume), Member = "get_profileRef")]
	[Calls(Type = typeof(PostProcessManager), Member = "ReplaceData")]
	[Calls(Type = typeof(PostProcessLayer), Member = "UpdateGlobalVolumeInfoList")]
	[Calls(Type = typeof(PostProcessLayer), Member = "HaveGlobalVolumesChanged")]
	[Calls(Type = typeof(PostProcessLayer), Member = "AreAllVolumesGlobal")]
	[Calls(Type = typeof(PostProcessManager), Member = "GrabVolumes")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(PostProcessLayer), Member = "UpdateVolumeSystem")]
	[CallsUnknownMethods(Count = 14)]
	internal void UpdateSettings(PostProcessLayer postProcessLayer, Camera camera)
	{
	}

	[CalledBy(Type = typeof(PostProcessManager), Member = "UpdateSettings")]
	[CallsUnknownMethods(Count = 15)]
	[CalledBy(Type = typeof(PostProcessManager), Member = "GetActiveVolumes")]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsDeduplicatedMethods(Count = 8)]
	[CallerCount(Count = 2)]
	private List<PostProcessVolume> GrabVolumes(LayerMask mask)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(System.ThrowHelper), Member = "ThrowArgumentOutOfRange_IndexException")]
	[CallsUnknownMethods(Count = 6)]
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
