using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIGeometry
{
	public BetterList<Vector3> verts;

	public BetterList<Vector2> uvs;

	public BetterList<Color32> cols;

	private BetterList<Vector3> mRtpVerts;

	private Vector3 mRtpNormal;

	private Vector4 mRtpTan;

	public bool hasVertices
	{
		[CallerCount(Count = 0)]
		[CallsUnknownMethods(Count = 1)]
		get
		{
			return default(bool);
		}
	}

	public bool hasTransformed
	{
		[CallsUnknownMethods(Count = 1)]
		[CallerCount(Count = 0)]
		get
		{
			return default(bool);
		}
	}

	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(UILabel), Member = "PrintOverlay")]
	[CalledBy(Type = typeof(UIWidget), Member = "UpdateGeometry")]
	[CalledBy(Type = typeof(UIWidget), Member = "UpdateGeometry")]
	[CallsDeduplicatedMethods(Count = 1)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(UILabel), Member = "PrintOverlay")]
	public void Clear()
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 6)]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[Calls(Type = typeof(Vector3), Member = "Normalize")]
	[CalledBy(Type = typeof(UIWidget), Member = "UpdateGeometry")]
	[CallsUnknownMethods(Count = 12)]
	public void ApplyTransform(Matrix4x4 widgetToPanel)
	{
	}

	[CallerCount(Count = 2)]
	[CallsUnknownMethods(Count = 57)]
	[CalledBy(Type = typeof(UIWidget), Member = "WriteToBuffers")]
	[CalledBy(Type = typeof(UIPanel), Member = "FillDrawCall")]
	[CallsDeduplicatedMethods(Count = 9)]
	public void WriteToBuffers(BetterList<Vector3> v, BetterList<Vector2> u, BetterList<Color32> c, BetterList<Vector3> n, BetterList<Vector4> t)
	{
	}

	[CallerCount(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[CalledBy(Type = typeof(UIWidget), Member = ".ctor")]
	[CallsUnknownMethods(Count = 32)]
	public UIGeometry()
	{
	}
}
