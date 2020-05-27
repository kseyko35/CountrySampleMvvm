using System;
using System.Collections.Generic;
using CountrySampleMvvm.Model;

namespace CountrySampleMvvm.Mock
{
    public static class CountryData
    {


        public static IList<Country> Countries { get; set; }

        static CountryData()
        {
            Countries = new List<Country>();
            Countries.Add(new Country
            {
                cName = "Çek Cumhuriyeti",
                cDescription = "Tarihî Prag kenti, ülkenin başkenti ve en büyük kenti olmasının yanı sıra, çok ilgi çeken bir turizm merkezidir. Ülke; Bohemya, Moravya ve Silezya bölgelerinden oluşur. Çek Cumhuriyeti, 1 Mayıs 2004'te Avrupa Birliği'nin üyesi olmuştur.",
                cImgUrl = "https://cambioevistos.com.br/wp-content/uploads/2014/11/bandeira-republica-tcheca.jpg",
                cLocation = "Orta Avrupa'da bir ülkedir",
                cCity = new List<City>() { new City() { Name = "Prag", RegNumber = 123 },
                    new City() { Name = "Prag", RegNumber = 123 },
                    new City() { Name = "Bruno", RegNumber = 32 },
                    new City() { Name = "Pardubice", RegNumber = 53 },
                    new City() { Name = "Chesky Krumlov", RegNumber = 100 },
                    new City() { Name = "Ostrava", RegNumber = 99 }
               }
            });
            Countries.Add(new Country
            {
                cName = "Türkiye",
                cDescription = "Türkiye ya da resmî adıyla Türkiye Cumhuriyeti, Avrupa ve Asya'nın kavşak noktasında yer alması sayesinde önemli bir jeostratejik güce sahiptir.",
                cImgUrl = "https://cdn.webshopapp.com/shops/94414/files/54949484/turkey-flag-image-free-download.jpg",
                cLocation = "topraklarının büyük bölümü Anadolu'da, küçük bir bölümü ise Balkan Yarımadası'nın güneydoğu uzantısı olan Trakya'da yer alan ülkedir",
                cCity = new List<City>() {
                     new City() {Name = "Izmir", RegNumber=35 },
                    new City() { Name = "Ankara", RegNumber = 06 },
                    new City() { Name = "Istanbul", RegNumber = 34 },
                    new City() {Name = "Kayseri", RegNumber=38 }
                }
            });
            Countries.Add(new Country
            {
                cName = "Amerika Birleşik Devletleri",
                cDescription = "(kısaca ABD) (İngilizce: United States of America (USA), ayrıca Birleşik Devletler ve Amerika olarak da bilinir), elli eyalet ve bir federal bölgeden oluşan bir federal anayasal cumhuriyettir.",
                cImgUrl = "https://cdn.webshopapp.com/shops/94414/files/54958906/the-united-states-flag-image-free-download.jpg",
                cLocation = "Kuzey Amerika'nın ortasında, Büyük Okyanus ve Atlas Okyanusu'nun arasında bulunmaktadır.",
                cCity = new List<City>() { new City() {Name = "New york", RegNumber=43 },
                    new City() { Name = "Washington", RegNumber = 54 }
                }
            });


        }


    }
}
