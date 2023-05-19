using AppDalleE.Models;
using System.Collections.ObjectModel;

namespace AppDalleE.Views;

public partial class DashBoardView : ContentPage
{
	public ObservableCollection<Profile> Profiles { get; set; }
	public ObservableCollection<GeneratedImage> GeneratedImages { get; set; }
	public DashBoardView()
	{
		InitializeComponent(); 
		LoadData();
		BindingContext = this;
	}

	private void LoadData()
	{
		Profiles = new ObservableCollection<Profile>()
		{
			new Profile()
			{
				Name = "Jorge",
				ProfileImage = "profileimage1.jpg",
				NoPhotos=12
			},
            new Profile()
            {
                Name = "Victor",
                ProfileImage = "profileimage2.jpg",
                NoPhotos=5
            },
            new Profile()
            {
                Name = "Nancy",
                ProfileImage = "profileimage3.jpg",
                NoPhotos=25
            },
        };

		GeneratedImages = new ObservableCollection<GeneratedImage>() 
		{
			new GeneratedImage()
			{
				ImagePath = "dashboard1.jpg",
				MainKeyword = "Castle",
				Keywords = new List<string>
				{
					"Epic","Hill", "Mountain","Trees","Blue Sky"
				}
			},
            new GeneratedImage()
            {
                ImagePath = "dashboard2.jpg",
                MainKeyword = "Mountains",
                Keywords = new List<string>
                {
                    "Landscape","Phothorealistic", "Mountain","Dawns","Blue Sky"
                }
            },
            new GeneratedImage()
            {
                ImagePath = "dashboard3.jpg",
                MainKeyword = "Robot",
                Keywords = new List<string>
                {
                    "Ai","Robotic", "Human","Light","Metal"
                }
            }
        };
	}
}