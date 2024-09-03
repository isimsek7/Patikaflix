using System;
using System.Runtime.ConstrainedExecution;

namespace Patikaflix
{
	public class Dizi
	{
		public Dizi(string diziAdi,string yapimYili, string tur, string yayinTarihi, string yonetmen, string ilkPlatform)
		{
			_diziAdi = diziAdi;
			_yapimYili = yapimYili;
			_tur = tur;
			_yayinTarihi = yayinTarihi;
			_yonetmen = yonetmen;
			_ilkPlatform = ilkPlatform;
		}
		public string _diziAdi { get; set; }
		public string _yapimYili { get; set; }
		public string _tur { get; set; }
		public string _yayinTarihi { get; set; }
		public string _yonetmen { get; set; }
		public string _ilkPlatform { get; set; }
	}
	public class KomediDiziler
	{
		public KomediDiziler()
		{
		}
		public string komediDiziAdi { get; set; }
		public string komediTur { get; set; }
		public string komediYonetmen { get; set; }

	}
}