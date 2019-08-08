using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C19_Ex01_LiorFridman_206081085_DorCohen_307993959
{
	class PhotosAndLikes
	{
		public int TotalLikes { set; get; }
		public int NumOfPhotos { set; get; }
		public List<string> Pictures;
		public PhotosAndLikes(int i_NumOfPhotos, int i_TotalLikes)
		{
			NumOfPhotos = i_NumOfPhotos;
			TotalLikes = i_TotalLikes;
			Pictures = new List<string>();
		}
	}
}
