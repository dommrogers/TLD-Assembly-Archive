using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

public sealed class PropertySheet
{
	private MaterialPropertyBlock _003Cproperties_003Ek__BackingField;

	private Material _003Cmaterial_003Ek__BackingField;

	public MaterialPropertyBlock properties
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 52)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 101)]
		private set
		{
		}
	}

	internal Material material
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 29)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 71)]
		private set
		{
		}
	}

	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(RuntimeUtilities), Member = "get_copyFromTexArraySheet")]
	[CalledBy(Type = typeof(RuntimeUtilities), Member = "get_copySheet")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(PropertySheetFactory), Member = "Get")]
	internal PropertySheet(Material material)
	{
	}

	[CallerCount(Count = 1)]
	[CalledBy(Type = typeof(PostProcessDebugLayer), Member = "RenderSpecialOverlays")]
	[CallsUnknownMethods(Count = 2)]
	public void ClearKeywords()
	{
	}

	[CallerCount(Count = 42)]
	[CallsUnknownMethods(Count = 2)]
	public void EnableKeyword(string keyword)
	{
	}

	[CalledBy(Type = typeof(RLPRO_SRP_JitterRenderer), Member = "ParamSwitch")]
	[CalledBy(Type = typeof(RLPRO_SRP_NoiseRenderer), Member = "Render")]
	[CalledBy(Type = typeof(RLPRO_SRP_NoiseRenderer), Member = "Render")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(RLProUltimateVignetteRenderer), Member = "Render")]
	[CalledBy(Type = typeof(RLPRO_SRP_NoiseRenderer), Member = "Render")]
	[CalledBy(Type = typeof(RLPRO_SRP_NoiseRenderer), Member = "ParamSwitch")]
	[CalledBy(Type = typeof(RLProUltimateVignetteRenderer), Member = "Render")]
	[CalledBy(Type = typeof(RLPRO_SRP_NoiseRenderer), Member = "Render")]
	[CalledBy(Type = typeof(RLPRO_SRP_JitterRenderer), Member = "Render")]
	[CalledBy(Type = typeof(RLPRO_SRP_FisheyeRenderer), Member = "ParamSwitch")]
	[CalledBy(Type = typeof(RLPRO_SRP_JitterRenderer), Member = "Render")]
	[CalledBy(Type = typeof(RLPRO_SRP_JitterRenderer), Member = "Render")]
	[CalledBy(Type = typeof(RLPRO_SRP_JitterRenderer), Member = "Render")]
	[CalledBy(Type = typeof(RLPRO_SRP_FisheyeRenderer), Member = "Render")]
	[CalledBy(Type = typeof(RLPRO_SRP_BleedRenderer), Member = "ParamSwitch")]
	[CalledBy(Type = typeof(RLPRO_SRP_BleedRenderer), Member = "Render")]
	[CalledBy(Type = typeof(RLProArtefactsRenderer), Member = "ParamSwitch")]
	[CallerCount(Count = 18)]
	[CalledBy(Type = typeof(RLPRO_SRP_JitterRenderer), Member = "Render")]
	public void DisableKeyword(string keyword)
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	internal void Release()
	{
	}
}
