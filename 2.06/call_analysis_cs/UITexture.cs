using System;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UITexture : UIBasicSprite
{
	private Rect mRect;

	private Texture mTexture;

	private Material mMat;

	private Shader mShader;

	private Vector4 mBorder;

	private bool mFixedAspect;

	[NonSerialized]
	private int mPMA;

	public override Texture mainTexture
	{
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(Material), Member = "get_mainTexture")]
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		get
		{
			return null;
		}
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UIDrawCall), Member = "set_mainTexture")]
		[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
		[CallsUnknownMethods(Count = 1)]
		set
		{
		}
	}

	public override Material material
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return null;
		}
		[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[CallsDeduplicatedMethods(Count = 1)]
		[CallerCount(Count = 0)]
		set
		{
		}
	}

	public override Shader shader
	{
		[CallsUnknownMethods(Count = 2)]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(Shader), Member = "Find")]
		get
		{
			return null;
		}
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Equality")]
		[Calls(Type = typeof(UIDrawCall), Member = "set_shader")]
		[Calls(Type = typeof(UIWidget), Member = "RemoveFromPanel")]
		[CallsUnknownMethods(Count = 1)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public override bool premultipliedAlpha
	{
		[CallsDeduplicatedMethods(Count = 2)]
		[CallsUnknownMethods(Count = 2)]
		[Calls(Type = typeof(string), Member = "IndexOf")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "get_name")]
		[Calls(Type = typeof(Material), Member = "get_shader")]
		[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
		[CallerCount(Count = 0)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		get
		{
			return default(bool);
		}
	}

	public override Vector4 border
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(Vector4);
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public Rect uvRect
	{
		[CallerCount(Count = 0)]
		get
		{
			return default(Rect);
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	public override Vector4 drawingDimensions
	{
		[CallsUnknownMethods(Count = 1)]
		[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
		[Calls(Type = typeof(NGUIMath), Member = "GetPivotOffset")]
		[CallsDeduplicatedMethods(Count = 3)]
		[CallerCount(Count = 0)]
		get
		{
			return default(Vector4);
		}
	}

	public bool fixedAspect
	{
		[CallerCount(Count = 0)]
		[DeduplicatedMethod]
		get
		{
			return default(bool);
		}
		[CallerCount(Count = 0)]
		[CallsDeduplicatedMethods(Count = 1)]
		set
		{
		}
	}

	[Calls(Type = typeof(UIWidget), Member = "MakePixelPerfect")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIBasicSprite), Member = "get_hasBorder")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "op_Inequality")]
	[Calls(Type = typeof(UIWidget), Member = "set_width")]
	[Calls(Type = typeof(UIWidget), Member = "set_height")]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 3)]
	public override void MakePixelPerfect()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIWidget), Member = "set_drawRegion")]
	[Calls(Type = typeof(UIWidget), Member = "set_drawRegion")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIWidget), Member = "OnUpdate")]
	[CallsDeduplicatedMethods(Count = 3)]
	protected override void OnUpdate()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIBasicSprite), Member = "Fill")]
	[Calls(Type = typeof(UnityEngine.Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 9)]
	public override void OnFill(BetterList<Vector3> verts, BetterList<Vector2> uvs, BetterList<Color32> cols)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(UIWidget), Member = ".ctor")]
	public UITexture()
	{
	}
}
