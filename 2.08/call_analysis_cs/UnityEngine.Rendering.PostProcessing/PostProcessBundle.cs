using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

public sealed class PostProcessBundle
{
	private PostProcessAttribute _003Cattribute_003Ek__BackingField;

	private PostProcessEffectSettings _003Csettings_003Ek__BackingField;

	private PostProcessEffectRenderer m_Renderer;

	public PostProcessAttribute attribute
	{
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 80)]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 279)]
		private set
		{
		}
	}

	public PostProcessEffectSettings settings
	{
		[CallerCount(Count = 28)]
		[DeduplicatedMethod]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		[DeduplicatedMethod]
		[CallerCount(Count = 79)]
		private set
		{
		}
	}

	internal PostProcessEffectRenderer renderer
	{
		[CallsUnknownMethods(Count = 3)]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderEffect")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderList")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "SetLegacyCameraFlags")]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "RenderEffect")]
		[CalledBy(Type = typeof(PostProcessBundle), Member = "CastRenderer")]
		[Calls(Type = typeof(Activator), Member = "CreateInstance")]
		[CallsDeduplicatedMethods(Count = 2)]
		[CallerCount(Count = 6)]
		[CalledBy(Type = typeof(PostProcessLayer), Member = "BuildCommandBuffers")]
		get
		{
			return null;
		}
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	internal PostProcessBundle(PostProcessEffectSettings settings)
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(RuntimeUtilities), Member = "Destroy")]
	[CallerCount(Count = 0)]
	internal void Release()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	internal void ResetHistory()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	internal T CastSettings<T>() where T : PostProcessEffectSettings
	{
		return null;
	}

	[CallsUnknownMethods(Count = 3)]
	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(PostProcessBundle), Member = "get_renderer")]
	internal T CastRenderer<T>() where T : PostProcessEffectRenderer
	{
		return null;
	}
}
