using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DrawDepth : MonoBehaviour
{
	protected bool isSupported;

	protected bool supportHDRTextures;

	public Shader depthShader;

	private Material depthMaterial;

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void OnEnable()
	{
	}

	[Calls(Type = typeof(DrawDepth), Member = "CheckSupport")]
	[CallerCount(Count = 0)]
	private bool CheckSupport()
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DrawDepth), Member = "CheckResources")]
	private void Start()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 0)]
	private void OnDisable()
	{
	}

	[Calls(Type = typeof(DrawDepth), Member = "CheckShaderAndCreateMaterial")]
	[Calls(Type = typeof(SystemInfo), Member = "SupportsRenderTextureFormat")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CalledBy(Type = typeof(DrawDepth), Member = "Start")]
	private bool CheckResources()
	{
		return default(bool);
	}

	[CalledBy(Type = typeof(DrawDepth), Member = "CheckSupport")]
	[CalledBy(Type = typeof(DrawDepth), Member = "CheckSupport")]
	[Calls(Type = typeof(DrawDepth), Member = "NotSupported")]
	[Calls(Type = typeof(SystemInfo), Member = "SupportsRenderTextureFormat")]
	[Calls(Type = typeof(SystemInfo), Member = "SupportsRenderTextureFormat")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	[Calls(Type = typeof(Camera), Member = "set_depthTextureMode")]
	private bool CheckSupport(bool needDepth)
	{
		return default(bool);
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DrawDepth), Member = "CheckSupport")]
	[Calls(Type = typeof(DrawDepth), Member = "NotSupported")]
	private bool CheckSupport(bool needDepth, bool needHdr)
	{
		return default(bool);
	}

	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	private void ReportAutoDisable()
	{
	}

	[Calls(Type = typeof(Debug), Member = "Log")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 24)]
	private bool CheckShader(Shader s)
	{
		return default(bool);
	}

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 1)]
	[CalledBy(Type = typeof(DrawDepth), Member = "CheckShaderAndCreateMaterial")]
	[CalledBy(Type = typeof(DrawDepth), Member = "CheckSupport")]
	[CalledBy(Type = typeof(DrawDepth), Member = "CheckSupport")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void NotSupported()
	{
	}

	[DeduplicatedMethod]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Camera), Member = "RenderWithShader")]
	private void LateUpdate()
	{
	}

	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(Camera), Member = "RenderWithShader")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[DeduplicatedMethod]
	public void DoDepthRender()
	{
	}

	[Calls(Type = typeof(Material), Member = ".ctor")]
	[CallsUnknownMethods(Count = 34)]
	[Calls(Type = typeof(Object), Member = "set_hideFlags")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(DrawDepth), Member = "NotSupported")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CalledBy(Type = typeof(DrawDepth), Member = "CheckResources")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Material), Member = "get_shader")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	private Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
	{
		return null;
	}

	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "set_hideFlags")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsUnknownMethods(Count = 13)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Shader), Member = "get_isSupported")]
	private Material CreateMaterial(Shader s, Material m2Create)
	{
		return null;
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = ".ctor")]
	public DrawDepth()
	{
	}
}
