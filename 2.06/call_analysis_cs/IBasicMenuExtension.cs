public interface IBasicMenuExtension
{
	void Init(BasicMenu menu);

	void ItemAdded(BasicMenu.BasicMenuItemModel item);

	void Update();

	void UpdateButtonLegend(ButtonLegendContainer buttonLegendContainer, int basePriority);
}
