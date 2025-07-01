using BMI.MVVM.ModelViews;

namespace BMI.MVVM.Views;

public partial class BMIView : ContentPage
{
	public BMIView()
	{
		InitializeComponent();
		BindingContext = new BMIViewModel();
    }
}