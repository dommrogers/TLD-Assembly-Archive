using System.Runtime.CompilerServices;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Rendering.PostProcessing;

public abstract class PostProcessEffectRenderer
{
	protected bool m_ResetHistory;

	[DeduplicatedMethod]
	[CallerCount(Count = 6)]
	public virtual void Init()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	public virtual DepthTextureMode GetCameraFlags()
	{
		return default(DepthTextureMode);
	}

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual void ResetHistory()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public virtual void Release()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	public abstract void Render(PostProcessRenderContext context);

	[DeduplicatedMethod]
	[CallerCount(Count = 101261)]
	internal abstract void SetSettings(PostProcessEffectSettings settings);

	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	protected PostProcessEffectRenderer()
	{
	}
}
public abstract class PostProcessEffectRenderer<T> : PostProcessEffectRenderer where T : PostProcessEffectSettings
{
	private T _003Csettings_003Ek__BackingField;

	public T settings
	{
		[DeduplicatedMethod]
		[CallerCount(Count = 28)]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[DeduplicatedMethod]
		[CallerCount(Count = 79)]
		[CompilerGenerated]
		internal set
		{
		}
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 3)]
	internal override void SetSettings(PostProcessEffectSettings settings)
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	protected PostProcessEffectRenderer()
	{
	}
}
