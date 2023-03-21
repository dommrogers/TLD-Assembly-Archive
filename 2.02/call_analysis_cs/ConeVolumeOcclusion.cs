using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class ConeVolumeOcclusion : VolumetricObjectBase
{
	public float coneHeight;

	public float coneAngle;

	public float startOffset;

	public int occlusionTextureSize;

	private float previousConeHeight;

	private float previousConeAngle;

	private float previousStartOffset;

	private int previousOcclusionTextureSize;

	private Transform coneCameraTransform;

	private Camera coneCamera;

	private RenderTexture coneCameraRT;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(string), Member = "EqualsHelper")]
	[Calls(Type = typeof(VolumetricObjectBase), Member = "OnEnable")]
	[Calls(Type = typeof(ConeVolumeOcclusion), Member = "SetupCamera")]
	[CallsDeduplicatedMethods(Count = 2)]
	protected override void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "DestroyImmediate")]
	[CallsDeduplicatedMethods(Count = 2)]
	protected override void CleanUp()
	{
	}

	[CallerCount(Count = 0)]
	[CallsDeduplicatedMethods(Count = 1)]
	public override void PopulateShaderName()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumetricObjectBase), Member = "HasChanged")]
	public override bool HasChanged()
	{
		return false;
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumetricObjectBase), Member = "SetChangedValues")]
	[Calls(Type = typeof(ConeVolumeOcclusion), Member = "SetupCamera")]
	protected override void SetChangedValues()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Vector3), Member = "get_up")]
	[Calls(Type = typeof(VolumetricObjectBase), Member = "ScaleMesh")]
	[Calls(Type = typeof(Bounds), Member = "SetMinMax")]
	[Calls(Type = typeof(Material), Member = "SetVector")]
	[Calls(Type = typeof(Material), Member = "SetFloat")]
	[Calls(Type = typeof(Material), Member = "SetColor")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallsUnknownMethods(Count = 9)]
	public override void UpdateVolume()
	{
	}

	[CalledBy(Type = typeof(ConeVolumeOcclusion), Member = "SetupCamera")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Transform), Member = "Find")]
	[Calls(Type = typeof(GameObject), Member = ".ctor")]
	[Calls(Type = typeof(Transform), Member = "set_parent")]
	[Calls(Type = typeof(Component), Member = "GetComponent")]
	[Calls(Type = typeof(GameObject), Member = "AddComponent")]
	[CallsDeduplicatedMethods(Count = 7)]
	[CallsUnknownMethods(Count = 22)]
	private void CreateDepthCamera()
	{
	}

	[CalledBy(Type = typeof(ConeVolumeOcclusion), Member = "SetupCamera")]
	[CallerCount(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[Calls(Type = typeof(Object), Member = "Destroy")]
	[Calls(Type = typeof(RenderTexture), Member = "GetCompatibleFormat")]
	[Calls(Type = typeof(RenderTexture), Member = ".ctor")]
	[Calls(Type = typeof(Material), Member = "SetTexture")]
	[CallsDeduplicatedMethods(Count = 3)]
	[CallsUnknownMethods(Count = 10)]
	private RenderTexture ConeRenderTexture()
	{
		return null;
	}

	[CalledBy(Type = typeof(ConeVolumeOcclusion), Member = "OnEnable")]
	[CalledBy(Type = typeof(ConeVolumeOcclusion), Member = "SetChangedValues")]
	[CallerCount(Count = 2)]
	[Calls(Type = typeof(ConeVolumeOcclusion), Member = "CreateDepthCamera")]
	[Calls(Type = typeof(Transform), Member = "get_up")]
	[Calls(Type = typeof(Transform), Member = "get_forward")]
	[Calls(Type = typeof(ConeVolumeOcclusion), Member = "ConeRenderTexture")]
	[CallsDeduplicatedMethods(Count = 14)]
	[CallsUnknownMethods(Count = 24)]
	private void SetupCamera()
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(VolumetricObjectBase), Member = ".ctor")]
	public ConeVolumeOcclusion()
	{
	}
}
