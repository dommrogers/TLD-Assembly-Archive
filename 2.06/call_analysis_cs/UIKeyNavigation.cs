using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

public class UIKeyNavigation : MonoBehaviour
{
	public enum Constraint
	{
		None,
		Vertical,
		Horizontal,
		Explicit
	}

	public static BetterList<UIKeyNavigation> list;

	public static KeyCode lastKeycodeUsed;

	public Constraint constraint;

	public GameObject onUp;

	public GameObject onDown;

	public GameObject onLeft;

	public GameObject onRight;

	public GameObject onClick;

	public GameObject[] onLeftBackup;

	public GameObject[] onRightBackup;

	public GameObject[] onUpBackup;

	public GameObject[] onDownBackup;

	public bool startsSelected;

	private UIKeyNavigation onLeftNav;

	private UIKeyNavigation onRightNav;

	private UIKeyNavigation onUpNav;

	private UIKeyNavigation onDownNav;

	private BetterList<UIKeyNavigation> onLeftNavBackup;

	private BetterList<UIKeyNavigation> onRightNavBackup;

	private BetterList<UIKeyNavigation> onUpNavBackup;

	private BetterList<UIKeyNavigation> onDownNavBackup;

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 11)]
	[CallsUnknownMethods(Count = 23)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	private void Awake()
	{
	}

	[CallsDeduplicatedMethods(Count = 1)]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UICamera), Member = "get_selectedObject")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[CalledBy(Type = typeof(UIButtonKeys), Member = "OnEnable")]
	[CallsUnknownMethods(Count = 3)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[CallerCount(Count = 1)]
	protected virtual void OnEnable()
	{
	}

	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 2)]
	protected virtual void OnDisable()
	{
	}

	[CallerCount(Count = 3)]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnKey")]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnKey")]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnKey")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "Get")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	protected GameObject GetLeft()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 2)]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnKey")]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnKey")]
	[CallsUnknownMethods(Count = 4)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "Get")]
	private GameObject GetRight()
	{
		return null;
	}

	[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnKey")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "Get")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 3)]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnKey")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnKey")]
	protected GameObject GetUp()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 2)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "Get")]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnKey")]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnKey")]
	[CallsUnknownMethods(Count = 4)]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "OnKey")]
	[CallerCount(Count = 3)]
	protected GameObject GetDown()
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 8)]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "GetUp")]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "GetRight")]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "GetLeft")]
	[Calls(Type = typeof(Vector3), Member = "get_normalized")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "GetCenter")]
	[Calls(Type = typeof(Object), Member = "op_Inequality")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "GetCenter")]
	[CallsUnknownMethods(Count = 6)]
	[CallerCount(Count = 4)]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "GetDown")]
	protected GameObject Get(Vector3 myDir, bool horizontal)
	{
		return null;
	}

	[CallsDeduplicatedMethods(Count = 9)]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UICamera), Member = "get_cachedCamera")]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "Get")]
	[CallsUnknownMethods(Count = 8)]
	[CalledBy(Type = typeof(UIKeyNavigation), Member = "Get")]
	[Calls(Type = typeof(UICamera), Member = "FindCameraForLayer")]
	[CallerCount(Count = 2)]
	protected static Vector3 GetCenter(GameObject go)
	{
		return default(Vector3);
	}

	[Calls(Type = typeof(UIKeyNavigation), Member = "GetLeft")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "GetUp")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "GetLeft")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "GetLeft")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "GetUp")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "GetDown")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "GetRight")]
	[CallsDeduplicatedMethods(Count = 2)]
	[CallerCount(Count = 0)]
	[CallsUnknownMethods(Count = 1)]
	[Calls(Type = typeof(UIKeyNavigation), Member = "GetRight")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[Calls(Type = typeof(Object), Member = "CompareBaseObjects")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "GetUp")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "GetDown")]
	[Calls(Type = typeof(UIKeyNavigation), Member = "GetDown")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(Object), Member = "op_Equality")]
	protected virtual void OnKey(KeyCode key)
	{
	}

	[CallerCount(Count = 0)]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	[Calls(Type = typeof(UICamera), Member = "set_selectedObject")]
	[Calls(Type = typeof(NGUITools), Member = "GetActive")]
	protected virtual void OnClick()
	{
	}

	[CallerCount(Count = 12)]
	[DeduplicatedMethod]
	public UIKeyNavigation()
	{
	}
}
