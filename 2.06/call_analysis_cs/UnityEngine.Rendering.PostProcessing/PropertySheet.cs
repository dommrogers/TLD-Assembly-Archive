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
		[CallerCount(Count = 98)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 265)]
		private set
		{
		}
	}

	internal Material material
	{
		[CallerCount(Count = 44)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[CallerCount(Count = 85)]
		[CompilerGenerated]
		[DeduplicatedMethod]
		private set
		{
		}
	}

	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(PropertySheetFactory), Member = "Get")]
	[CalledBy(Type = typeof(RuntimeUtilities), Member = "get_copySheet")]
	[CalledBy(Type = typeof(RuntimeUtilities), Member = "get_copyFromTexArraySheet")]
	[CallsUnknownMethods(Count = 7)]
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

	[CalledBy(Type = typeof(RLPRO_SRP_NoiseRenderer), Member = "Render")]
	[CalledBy(Type = typeof(RLPRO_SRP_NoiseRenderer), Member = "Render")]
	[CalledBy(Type = typeof(RLPRO_SRP_NoiseRenderer), Member = "Render")]
	[CalledBy(Type = typeof(RLPRO_SRP_JitterRenderer), Member = "ParamSwitch")]
	[CalledBy(Type = typeof(RLProUltimateVignetteRenderer), Member = "Render")]
	[CalledBy(Type = typeof(RLProUltimateVignetteRenderer), Member = "Render")]
	[CallsUnknownMethods(Count = 2)]
	[CalledBy(Type = typeof(RLPRO_SRP_NoiseRenderer), Member = "ParamSwitch")]
	[CalledBy(Type = typeof(RLPRO_SRP_JitterRenderer), Member = "Render")]
	[CalledBy(Type = typeof(RLPRO_SRP_NoiseRenderer), Member = "Render")]
	[CalledBy(Type = typeof(RLPRO_SRP_JitterRenderer), Member = "Render")]
	[CallerCount(Count = 18)]
	[CalledBy(Type = typeof(RLProArtefactsRenderer), Member = "ParamSwitch")]
	[CalledBy(Type = typeof(RLPRO_SRP_BleedRenderer), Member = "Render")]
	[CalledBy(Type = typeof(RLPRO_SRP_BleedRenderer), Member = "ParamSwitch")]
	[CalledBy(Type = typeof(RLPRO_SRP_JitterRenderer), Member = "Render")]
	[CalledBy(Type = typeof(RLPRO_SRP_FisheyeRenderer), Member = "ParamSwitch")]
	[CalledBy(Type = typeof(RLPRO_SRP_JitterRenderer), Member = "Render")]
	[CalledBy(Type = typeof(RLPRO_SRP_JitterRenderer), Member = "Render")]
	[CalledBy(Type = typeof(RLPRO_SRP_FisheyeRenderer), Member = "Render")]
	public void DisableKeyword(string keyword)
	{
	}

	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[CallerCount(Count = 0)]
	internal void Release()
	{
	}
}
