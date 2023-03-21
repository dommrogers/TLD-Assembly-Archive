using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UICursor : MonoBehaviour
{
	public static UICursor instance;

	public Camera uiCamera;

	private Transform mTrans;

	private UISprite mSprite;

	private UIAtlas mAtlas;

	private string mSpriteName;

	[CallerCount(Count = 0)]
	private void Awake()
	{
	}

	[CallerCount(Count = 0)]
	private void OnDestroy()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(UIWidget), Member = "set_depth")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(NGUITools), Member = "FindCameraForLayer")]
	private void Start()
	{
	}

	[CallsUnknownMethods(Count = 16)]
	[CalledBy(Type = typeof(UICursor), Member = "Set")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 10)]
	[CallerCount(Count = 1)]
	private void Update()
	{
	}

	[CallAnalysisFailed]
	[CallerCount(Count = 0)]
	public static void Clear()
	{
	}

	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UISprite), Member = "set_atlas")]
	[Calls(Type = typeof(UISprite), Member = "set_spriteName")]
	[Calls(Type = typeof(UICursor), Member = "Update")]
	[CalledBy(Type = typeof(UIItemSlot), Member = "UpdateCursor")]
	[CalledBy(Type = typeof(UIItemSlot), Member = "UpdateCursor")]
	[CallsUnknownMethods(Count = 1)]
	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(Object), Member = "op_Implicit")]
	[CallerCount(Count = 2)]
	public static void Set(UIAtlas atlas, string sprite)
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public UICursor()
	{
	}
}
