using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class DrawDepth : MonoBehaviour
{
	protected bool isSupported;

	protected bool supportHDRTextures;

	public Shader depthShader;

	private Material depthMaterial;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 1)]
	private void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DrawDepth), Member = "CheckSupport")]
	private bool CheckSupport()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DrawDepth), Member = "CheckResources")]
	private void Start()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate")]
	[CallsDeduplicatedMethods(Count = 1)]
	private void OnDisable()
	{
	}

	[CalledBy(Type = typeof(DrawDepth), Member = "Start")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(SystemInfo), Member = "SupportsRenderTextureFormat")]
	[Calls(Type = typeof(DrawDepth), Member = "CheckShaderAndCreateMaterial")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 3)]
	private bool CheckResources()
	{
		return false;
	}

	[CalledBy(Type = typeof(DrawDepth), Member = "CheckSupport")]
	[CalledBy(Type = typeof(DrawDepth), Member = "CheckSupport")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(SystemInfo), Member = "SupportsRenderTextureFormat")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Camera), Member = "set_depthTextureMode")]
	[Calls(Type = typeof(DrawDepth), Member = "NotSupported")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 2)]
	private bool CheckSupport(bool needDepth)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(DrawDepth), Member = "CheckSupport")]
	[Calls(Type = typeof(DrawDepth), Member = "NotSupported")]
	private bool CheckSupport(bool needDepth, bool needHdr)
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogWarning")]
	[CallsDeduplicatedMethods(Count = 2)]
	private void ReportAutoDisable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 5)]
	[CallsUnknownMethods(Count = 24)]
	private bool CheckShader(Shader s)
	{
		return false;
	}

	[CalledBy(Type = typeof(DrawDepth), Member = "CheckSupport")]
	[CalledBy(Type = typeof(DrawDepth), Member = "CheckSupport")]
	[CalledBy(Type = typeof(DrawDepth), Member = "CheckShaderAndCreateMaterial")]
	[CallerCount(Count = 3)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void NotSupported()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Camera), Member = "RenderWithShader")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	private void LateUpdate()
	{
	}

	[DeduplicatedMethod]
	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(Camera), Member = "RenderWithShader")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallsUnknownMethods(Count = 1)]
	public void DoDepthRender()
	{
	}

	[CalledBy(Type = typeof(DrawDepth), Member = "CheckResources")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Material), Member = "get_shader")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "set_hideFlags")]
	[Calls(Type = typeof(DrawDepth), Member = "NotSupported")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "LogError")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 34)]
	private Material CheckShaderAndCreateMaterial(Shader s, Material m2Create)
	{
		return null;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(Shader), Member = "get_isSupported")]
	[Calls(Type = typeof(Material), Member = ".ctor")]
	[Calls(Type = typeof(Object), Member = "set_hideFlags")]
	[Calls(Type = typeof(string), Member = "Concat")]
	[Calls(Type = typeof(Debug), Member = "Log")]
	[CallsDeduplicatedMethods(Count = 4)]
	[CallsUnknownMethods(Count = 13)]
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
