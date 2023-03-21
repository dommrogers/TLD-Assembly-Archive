using Cpp2ILInjected.CallAnalysis;

public interface IBasicMenuExtension
{
	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void Init(BasicMenu menu);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void ItemAdded(BasicMenu.BasicMenuItemModel item);

	[DeduplicatedMethod]
	[CallerCount(Count = 121780)]
	void Update();

	[CallerCount(Count = 121780)]
	[DeduplicatedMethod]
	void UpdateButtonLegend(ButtonLegendContainer buttonLegendContainer, int basePriority);
}
